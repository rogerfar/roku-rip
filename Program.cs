using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Serilog;
using Serilog.Events;

namespace RokuRip
{
    class Program
    {
        private const String ROOT = @"C:\Temp\RokuRip";

        private static async Task Main()
        {
            Log.Logger = new LoggerConfiguration()
                         .MinimumLevel.Debug()
                         .WriteTo.Console(LogEventLevel.Debug)
                         .WriteTo.File(@$"{ROOT}\log.txt")
                         .CreateLogger();

            Log.Debug("Starting");

            var tvInfoFile = await File.ReadAllTextAsync(@$"{ROOT}\tv.json");

            var tvInfo = JsonSerializer.Deserialize<TvInfo>(tvInfoFile);

            var episodes = tvInfo.Seasons.SelectMany(m => m.Episodes).ToList();
            
            ParallelOptions parallelOptions = new()
            {
                MaxDegreeOfParallelism = 4
            };

            await Parallel.ForEachAsync(episodes,
                                  parallelOptions,
                                  async (episode, token) =>
                                  {
                                      try
                                      {
                                          await ProcessEpisode(episode);
                                      }
                                      catch (Exception ex)
                                      {
                                          Log.Error(ex, ex.Message);
                                      }
                                  });

            Log.Debug("Finished");
        }

        private static async Task ProcessEpisode(Episode episode)
        {
            var seasonNumber = episode.SeasonNumber;
            var episodeNumber = Int32.Parse(episode.EpisodeNumber).ToString($"00");

            var identifier = $"S{seasonNumber}E{episodeNumber}";

            var workDir = @$"{ROOT}\{identifier}";

            var finalFile = @$"{ROOT}\processed\{identifier}.mp4";

            if (!Directory.Exists(workDir))
            {
                Directory.CreateDirectory(workDir);
            }

            if (File.Exists(finalFile))
            {
                Log.Warning($"Skipping {identifier}, file exists");

                return;
            }

            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            var page = await browser.NewPageAsync();

            PlaybackResponse playbackResponse = null;

            page.RequestFinished += async (sender, request) =>
            {
                if (request.Url.Contains("/api/v3/playback"))
                {
                    var response = await request.ResponseAsync();
                    var responseBody = await response.BodyAsync();
                    var str = Encoding.Default.GetString(responseBody);
                    playbackResponse = JsonSerializer.Deserialize<PlaybackResponse>(str);
                }
            };

            Log.Debug($"{identifier} - Starting {episode.Title}");

            var url = $"https://therokuchannel.roku.com/watch/{episode.Meta.Id}";

            Log.Debug($"{identifier} - Getting URL {url}");

            await page.GotoAsync(url);

            while (playbackResponse == null)
            {
                await Task.Delay(100);
            }

            var httpClient = new HttpClient();
            var mpdContents = await (await httpClient.GetAsync(playbackResponse.Url)).Content.ReadAsStringAsync();

            var psshMatch = Regex.Match(mpdContents, @"<cenc:pssh xmlns:cenc=""urn:mpeg:cenc:2013"">(.*?)</cenc:pssh>");

            var pssh = psshMatch.Groups[1].Captures[0].ToString();
            var licenseServer = playbackResponse.Drm.Widevine.LicenseServer;

            await browser.CloseAsync();

            ExecuteCommand(@$"{ROOT}\yt-dlp.exe", $@"--no-progress --allow-u -f bv,ba --concurrent-fragments 10 ""{playbackResponse.PlaybackMedia.Videos[0].Url}""", workDir);
            
            var keys = await GetWVKeys(pssh, licenseServer);

            ExecuteCommand($@"{ROOT}\mp4decrypt.exe", $@"--key {keys} ""index [index.mpdaws].mp4"" ""video.mp4""", workDir);
            ExecuteCommand($@"{ROOT}\mp4decrypt.exe", $@"--key {keys} ""index [index.mpdaws].m4a"" ""audio.m4a""", workDir);
            ExecuteCommand($@"{ROOT}\ffmpeg.exe", $@"-i video.mp4 -i audio.m4a -c copy ""{finalFile}""", workDir);

            foreach (var caption in playbackResponse.PlaybackMedia.Captions)
            {
                var srtContents = await (await httpClient.GetAsync(caption.Url)).Content.ReadAsByteArrayAsync();

                var ext = Path.GetExtension(caption.Url);

                var path = $@"{ROOT}\processed\{identifier}{ext}";

                await File.WriteAllBytesAsync(path, srtContents);
            }

            Log.Debug($"{identifier} - Finished");
        }

        private static async Task<String> GetWVKeys(String pssh, String licenseServer)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36 Edg/97.0.1072.55");

            var headers = @"accept-encoding: gzip, deflate, br
accept-language: en-US,en;q=0.9,nl;q=0.8
content-length: ""4174""
content-type: application/octet-stream
origin: https://therokuchannel.roku.com
referer: https://therokuchannel.roku.com/
user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36 Edg/97.0.1072.55";
            
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<String, String>("pssh", pssh), 
                new KeyValuePair<String, String>("license", licenseServer),
                new KeyValuePair<String, String>("headers", headers),
                new KeyValuePair<String, String>("proxy", ""),
                new KeyValuePair<String, String>("json", ""),
            });

            var response = await httpClient.PostAsync("http://getwvkeys.herokuapp.com/wv", formContent);
            var responseString = await response.Content.ReadAsStringAsync();

            var responseRegex = Regex.Match(responseString, $">([0-9a-z:]*)<");

            return responseRegex.Groups[1].Captures[0].Value;
        }

        private static void ExecuteCommand(String executable, String arguments, String workDir)
        {
            Log.Debug($"Executing {executable} {arguments} in {workDir}");

            arguments = $"{arguments}";

            var start = new ProcessStartInfo
            {
                FileName = executable,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = false,
                RedirectStandardError = false,
                RedirectStandardInput = false,
                WorkingDirectory = workDir,
                CreateNoWindow = true
            };

            using var process = Process.Start(start);

            if (process == null)
            {
                throw new Exception("Unable to start process");
            }
            
            process.WaitForExit((Int32) TimeSpan.FromMinutes(30).TotalMilliseconds);
        }
    }
}