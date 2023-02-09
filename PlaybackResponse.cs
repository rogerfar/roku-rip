using System.Text.Json.Serialization;

namespace RokuRip
{
    public class PlaybackResponse
    {
        [JsonPropertyName("url")]
        public String Url { get; set; }

        [JsonPropertyName("drm")]
        public Drm Drm { get; set; }

        [JsonPropertyName("mediaFormat")]
        public String MediaFormat { get; set; }

        [JsonPropertyName("adPolicy")]
        public AdPolicy AdPolicy { get; set; }

        [JsonPropertyName("playbackMedia")]
        public PlaybackMedia PlaybackMedia { get; set; }

        [JsonPropertyName("playbackContent")]
        public String PlaybackContent { get; set; }
    }

    public class AdPolicy
    {
        [JsonPropertyName("id")]
        public String Id { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }

        [JsonPropertyName("noAds")]
        public Boolean NoAds { get; set; }

        [JsonPropertyName("author")]
        public String Author { get; set; }

        [JsonPropertyName("bumper")]
        public Bumper Bumper { get; set; }

        [JsonPropertyName("sizzle")]
        public Bumper Sizzle { get; set; }

        [JsonPropertyName("midRoll")]
        public MidRoll MidRoll { get; set; }

        [JsonPropertyName("preRoll")]
        public PreRoll PreRoll { get; set; }

        [JsonPropertyName("adPolicyName")]
        public String AdPolicyName { get; set; }

        [JsonPropertyName("kidsDirected")]
        public Boolean KidsDirected { get; set; }

        [JsonPropertyName("rokuNielsenId")]
        public String RokuNielsenId { get; set; }

        [JsonPropertyName("adPrefetchThreshold")]
        public Int64 AdPrefetchThreshold { get; set; }

        [JsonPropertyName("adViewRequiredPercent")]
        public Decimal AdViewRequiredPercent { get; set; }

        [JsonPropertyName("adUpperBitrateLimitKbps")]
        public Int64 AdUpperBitrateLimitKbps { get; set; }

        [JsonPropertyName("adPrefetchThresholdInSec")]
        public Int64 AdPrefetchThresholdInSec { get; set; }

        [JsonPropertyName("developerAdInventorySharePercent")]
        public Decimal DeveloperAdInventorySharePercent { get; set; }
    }

    public class Bumper
    {
        [JsonPropertyName("rokuExclusiveAdUrl")]
        public String RokuExclusiveAdUrl { get; set; }
    }

    public class MidRoll
    {
        [JsonPropertyName("rokuSharedAdUrl")]
        public String RokuSharedAdUrl { get; set; }

        [JsonPropertyName("rokuExclusiveAdUrl")]
        public String RokuExclusiveAdUrl { get; set; }

        [JsonPropertyName("postInstallAdFreeSeconds")]
        public Int64 PostInstallAdFreeSeconds { get; set; }

        [JsonPropertyName("minimumAdFreeContentSeconds")]
        public Int64 MinimumAdFreeContentSeconds { get; set; }
    }

    public class PreRoll
    {
        [JsonPropertyName("enableOnAdBreaks")]
        public Boolean EnableOnAdBreaks { get; set; }

        [JsonPropertyName("showOnNewSession")]
        public Boolean ShowOnNewSession { get; set; }

        [JsonPropertyName("postInstallAdFreeSeconds")]
        public Int64 PostInstallAdFreeSeconds { get; set; }

        [JsonPropertyName("showOnFirstEpisodeOfSeries")]
        public Boolean ShowOnFirstEpisodeOfSeries { get; set; }

        [JsonPropertyName("minimumAdFreeContentSeconds")]
        public Int64 MinimumAdFreeContentSeconds { get; set; }

        [JsonPropertyName("rokuExclusiveAdUrl")]
        public String RokuExclusiveAdUrl { get; set; }

        [JsonPropertyName("rokuSharedAdUrl")]
        public String RokuSharedAdUrl { get; set; }
    }

    public class Drm
    {
        [JsonPropertyName("widevine")]
        public Widevine Widevine { get; set; }
    }

    public class Widevine
    {
        [JsonPropertyName("licenseServer")]
        public String LicenseServer { get; set; }
    }

    public class PlaybackMedia
    {
        [JsonPropertyName("videos")]
        public List<Video> Videos { get; set; }

        [JsonPropertyName("trickPlayFiles")]
        public List<TrickPlayFile> TrickPlayFiles { get; set; }

        [JsonPropertyName("captions")]
        public List<Caption> Captions { get; set; }

        [JsonPropertyName("creditCuePoints")]
        public List<CreditCuePoint> CreditCuePoints { get; set; }

        [JsonPropertyName("validityStartTime")]
        public DateTimeOffset ValidityStartTime { get; set; }

        [JsonPropertyName("validityEndTime")]
        public DateTimeOffset ValidityEndTime { get; set; }

        [JsonPropertyName("duration")]
        public Int64 Duration { get; set; }
    }
    
    public class DrmParams
    {
        [JsonPropertyName("keySystem")]
        public String KeySystem { get; set; }

        [JsonPropertyName("licenseServerURL")]
        public String LicenseServerUrl { get; set; }
    }
}
