using System.Text.Json.Serialization;

namespace RokuRip
{
    public class TvInfo
    {
        [JsonPropertyName("title")]
        public String Title { get; set; }

        [JsonPropertyName("type")]
        public String Type { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonPropertyName("releaseYear")]
        public Int64 ReleaseYear { get; set; }

        [JsonPropertyName("runTimeSeconds")]
        public Int64 RunTimeSeconds { get; set; }

        [JsonPropertyName("credits")]
        public List<WelcomeCredit> Credits { get; set; }

        [JsonPropertyName("genres")]
        public List<String> Genres { get; set; }

        [JsonPropertyName("categoryObjects")]
        public List<CategoryObject> CategoryObjects { get; set; }

        [JsonPropertyName("viewOptions")]
        public List<WelcomeViewOption> ViewOptions { get; set; }

        [JsonPropertyName("parentalRatings")]
        public List<ParentalRating> ParentalRatings { get; set; }

        [JsonPropertyName("seasons")]
        public List<Season> Seasons { get; set; }

        [JsonPropertyName("kidsDirected")]
        public Boolean KidsDirected { get; set; }

        [JsonPropertyName("reverseChronological")]
        public Boolean ReverseChronological { get; set; }

        [JsonPropertyName("contentRatingClass")]
        public Int64 ContentRatingClass { get; set; }

        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        [JsonPropertyName("description")]
        public String Description { get; set; }

        [JsonPropertyName("descriptions")]
        public Dictionary<String, Description> Descriptions { get; set; }

        [JsonPropertyName("imageMap")]
        public WelcomeImageMap ImageMap { get; set; }

        [JsonPropertyName("savable")]
        public Boolean Savable { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("currentTime")]
        public DateTime CurrentTime { get; set; }

        [JsonPropertyName("features")]
        public Features Features { get; set; }
    }

    public class CategoryObject
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("zoneId")]
        public String ZoneId { get; set; }

        [JsonPropertyName("browsable")]
        public Boolean Browsable { get; set; }

        [JsonPropertyName("searchable")]
        public Boolean Searchable { get; set; }

        [JsonPropertyName("kidsAppropriate")]
        public Boolean KidsAppropriate { get; set; }

        [JsonPropertyName("enabled")]
        public Boolean Enabled { get; set; }

        [JsonPropertyName("requiresUserInfo")]
        public Boolean RequiresUserInfo { get; set; }

        [JsonPropertyName("editoriallyGenerated")]
        public Boolean EditoriallyGenerated { get; set; }

        [JsonPropertyName("title")]
        public String Title { get; set; }

        [JsonPropertyName("type")]
        public String Type { get; set; }

        [JsonPropertyName("isPrivate")]
        public Boolean IsPrivate { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonPropertyName("ampIds")]
        public List<Object> AmpIds { get; set; }

        [JsonPropertyName("genreAppropriate")]
        public Boolean GenreAppropriate { get; set; }

        [JsonPropertyName("zone")]
        public Zone Zone { get; set; }

        [JsonPropertyName("clicks")]
        public Int64 Clicks { get; set; }

        [JsonPropertyName("recentClicks")]
        public Int64 RecentClicks { get; set; }

        [JsonPropertyName("todayClicks")]
        public Int64 TodayClicks { get; set; }

        [JsonPropertyName("isAvailable")]
        public Boolean IsAvailable { get; set; }

        [JsonPropertyName("viewOptions")]
        public List<Object> ViewOptions { get; set; }

        [JsonPropertyName("channelIds")]
        public List<Object> ChannelIds { get; set; }

        [JsonPropertyName("providerProductIds")]
        public List<Object> ProviderProductIds { get; set; }

        [JsonPropertyName("channelStoreCode")]
        public String ChannelStoreCode { get; set; }

        [JsonPropertyName("kidsDirected")]
        public Boolean KidsDirected { get; set; }

        [JsonPropertyName("tags")]
        public List<Object> Tags { get; set; }

        [JsonPropertyName("minFirmwareVersion")]
        public Int64 MinFirmwareVersion { get; set; }

        [JsonPropertyName("isPromoted")]
        public Boolean IsPromoted { get; set; }

        [JsonPropertyName("contentRatingClass")]
        public Int64 ContentRatingClass { get; set; }

        [JsonPropertyName("imageUrls")]
        public List<Object> ImageUrls { get; set; }

        [JsonPropertyName("images")]
        public List<Object> Images { get; set; }

        [JsonPropertyName("titles")]
        public List<Title> Titles { get; set; }

        [JsonPropertyName("descriptions")]
        public Descriptions Descriptions { get; set; }

        [JsonPropertyName("savable")]
        public Boolean Savable { get; set; }
    }

    public class Descriptions
    {
    }

    public class Meta
    {
        [JsonPropertyName("id")]
        public String Id { get; set; }

        [JsonPropertyName("mediaType")]
        public String MediaType { get; set; }

        [JsonPropertyName("source")]
        public String Source { get; set; }

        [JsonPropertyName("href")]
        public String Href { get; set; }

        [JsonPropertyName("cid")]
        public String Cid { get; set; }

        [JsonPropertyName("sid")]
        public String Sid { get; set; }

        [JsonPropertyName("hasViewOptions")]
        public Boolean? HasViewOptions { get; set; }
    }

    public class Title
    {
        [JsonPropertyName("title")]
        public String TitleTitle { get; set; }

        [JsonPropertyName("type")]
        public String Type { get; set; }

        [JsonPropertyName("lang")]
        public String Lang { get; set; }
    }

    public class Zone
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class WelcomeCredit
    {
        [JsonPropertyName("personId")]
        public String PersonId { get; set; }

        [JsonPropertyName("role")]
        public String Role { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }

        [JsonPropertyName("order")]
        public Int64 Order { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }
    }

    public class Image
    {
        [JsonPropertyName("path")]
        public String Path { get; set; }

        [JsonPropertyName("aspectRatio")]
        public String AspectRatio { get; set; }

        [JsonPropertyName("width")]
        public Int64 Width { get; set; }

        [JsonPropertyName("height")]
        public Int64 Height { get; set; }

        [JsonPropertyName("type")]
        public String Type { get; set; }

        [JsonPropertyName("tmsImageType")]
        public String TmsImageType { get; set; }

        [JsonPropertyName("tier")]
        public String Tier { get; set; }
    }

    public class Description
    {
        [JsonPropertyName("text")]
        public String Text { get; set; }

        [JsonPropertyName("size")]
        public Int64 Size { get; set; }

        [JsonPropertyName("type")]
        public String Type { get; set; }
    }

    public class Features
    {
        [JsonPropertyName("bookmark")]
        public Bookmark Bookmark { get; set; }
    }

    public class Bookmark
    {
        [JsonPropertyName("duration")]
        public Int64 Duration { get; set; }

        [JsonPropertyName("playId")]
        public String PlayId { get; set; }

        [JsonPropertyName("providerId")]
        public String ProviderId { get; set; }

        [JsonPropertyName("position")]
        public Int64 Position { get; set; }

        [JsonPropertyName("isFinished")]
        public Boolean IsFinished { get; set; }

        [JsonPropertyName("saveTime")]
        public DateTime SaveTime { get; set; }

        [JsonPropertyName("episodeId")]
        public String EpisodeId { get; set; }

        [JsonPropertyName("hiddenFromCw")]
        public Boolean HiddenFromCw { get; set; }
    }

    public class WelcomeImageMap
    {
        [JsonPropertyName("detailBackground")]
        public DetailBackground DetailBackground { get; set; }
    }

    public class DetailBackground
    {
        [JsonPropertyName("path")]
        public String Path { get; set; }

        [JsonPropertyName("aspectRatio")]
        public String AspectRatio { get; set; }
    }

    public class ParentalRating
    {
        [JsonPropertyName("code")]
        public String Code { get; set; }

        [JsonPropertyName("ratingSource")]
        public String RatingSource { get; set; }
    }

    public class Season
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("title")]
        public String Title { get; set; }

        [JsonPropertyName("releaseYear")]
        public Int64 ReleaseYear { get; set; }

        [JsonPropertyName("seasonNumber")]
        public String SeasonNumber { get; set; }

        [JsonPropertyName("credits")]
        public List<SeasonCredit> Credits { get; set; }

        [JsonPropertyName("episodes")]
        public List<Episode> Episodes { get; set; }

        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        [JsonPropertyName("descriptions")]
        public Descriptions Descriptions { get; set; }

        [JsonPropertyName("imageMap")]
        public WelcomeImageMap ImageMap { get; set; }
    }

    public class SeasonCredit
    {
        [JsonPropertyName("personId")]
        public String PersonId { get; set; }

        [JsonPropertyName("role")]
        public String Role { get; set; }

        [JsonPropertyName("birthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }

        [JsonPropertyName("order")]
        public Int64 Order { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class Episode
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("title")]
        public String Title { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonPropertyName("episodeNumber")]
        public String EpisodeNumber { get; set; }

        [JsonPropertyName("seasonNumber")]
        public String SeasonNumber { get; set; }

        [JsonPropertyName("viewOptions")]
        public List<EpisodeViewOption> ViewOptions { get; set; }

        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        [JsonPropertyName("description")]
        public String Description { get; set; }

        [JsonPropertyName("descriptions")]
        public Dictionary<String, Description> Descriptions { get; set; }

        [JsonPropertyName("imageMap")]
        public EpisodeImageMap ImageMap { get; set; }

        [JsonPropertyName("currentTime")]
        public DateTime CurrentTime { get; set; }
    }

    public class EpisodeImageMap
    {
        [JsonPropertyName("grid")]
        public DetailBackground Grid { get; set; }
    }

    public class EpisodeViewOption
    {
        [JsonPropertyName("isPrivate")]
        public Boolean IsPrivate { get; set; }

        [JsonPropertyName("installedOnly")]
        public Boolean InstalledOnly { get; set; }

        [JsonPropertyName("playId")]
        public String PlayId { get; set; }

        [JsonPropertyName("media")]
        public Media Media { get; set; }

        [JsonPropertyName("viewOptionSourceId")]
        public String ViewOptionSourceId { get; set; }

        [JsonPropertyName("license")]
        public String License { get; set; }

        [JsonPropertyName("higherPrice")]
        public Boolean HigherPrice { get; set; }

        [JsonPropertyName("price")]
        public Int64 Price { get; set; }

        [JsonPropertyName("inHd")]
        public Boolean InHd { get; set; }

        [JsonPropertyName("in4k")]
        public Boolean In4K { get; set; }

        [JsonPropertyName("priceDisplay")]
        public String PriceDisplay { get; set; }

        [JsonPropertyName("currency")]
        public String Currency { get; set; }

        [JsonPropertyName("providerId")]
        public String ProviderId { get; set; }

        [JsonPropertyName("adsProviderId")]
        public String AdsProviderId { get; set; }

        [JsonPropertyName("seriesTags")]
        public List<String> SeriesTags { get; set; }

        [JsonPropertyName("feedId")]
        public String FeedId { get; set; }

        [JsonPropertyName("providerDetails")]
        public Zone ProviderDetails { get; set; }

        [JsonPropertyName("adsContentId")]
        public String AdsContentId { get; set; }

        [JsonPropertyName("validityStartTime")]
        public DateTime ValidityStartTime { get; set; }

        [JsonPropertyName("validityEndTime")]
        public DateTime ValidityEndTime { get; set; }

        [JsonPropertyName("dateAdded")]
        public DateTime DateAdded { get; set; }

        [JsonPropertyName("isTrcInGlobal")]
        public Boolean IsTrcInGlobal { get; set; }

        [JsonPropertyName("providerName")]
        public String ProviderName { get; set; }

        [JsonPropertyName("providerType")]
        public String ProviderType { get; set; }

        [JsonPropertyName("creditCuePoints")]
        public List<CreditCuePoint> CreditCuePoints { get; set; }

        [JsonPropertyName("businessModel")]
        public String BusinessModel { get; set; }

        [JsonPropertyName("hasMedia")]
        public Boolean HasMedia { get; set; }
    }

    public class CreditCuePoint
    {
        [JsonPropertyName("creditType")]
        public String CreditType { get; set; }

        [JsonPropertyName("start")]
        public Int64 Start { get; set; }

        [JsonPropertyName("end")]
        public Int64 End { get; set; }

        [JsonPropertyName("skippable")]
        public Boolean Skippable { get; set; }
    }

    public class Media
    {
        [JsonPropertyName("captions")]
        public List<Caption> Captions { get; set; }

        [JsonPropertyName("videos")]
        public List<Video> Videos { get; set; }
    }

    public class Caption
    {
        [JsonPropertyName("url")]
        public String Url { get; set; }

        [JsonPropertyName("language")]
        public String Language { get; set; }

        [JsonPropertyName("captionType")]
        public String CaptionType { get; set; }
    }

    public class TrickPlayFile
    {
        [JsonPropertyName("url")]
        public String Url { get; set; }

        [JsonPropertyName("quality")]
        public String Quality { get; set; }
    }

    public class Video
    {
        [JsonPropertyName("url")]
        public String Url { get; set; }

        [JsonPropertyName("videoType")]
        public String VideoType { get; set; }

        [JsonPropertyName("quality")]
        public String Quality { get; set; }

        [JsonPropertyName("drmAuthentication")]
        public DrmAuthentication DrmAuthentication { get; set; }
    }

    public class DrmAuthentication
    {
        [JsonPropertyName("drmContentProvider")]
        public String DrmContentProvider { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("pid")]
        public String Pid { get; set; }
    }

    public class WelcomeViewOption
    {
        [JsonPropertyName("isPrivate")]
        public Boolean IsPrivate { get; set; }

        [JsonPropertyName("installedOnly")]
        public Boolean InstalledOnly { get; set; }

        [JsonPropertyName("playId")]
        public String PlayId { get; set; }

        [JsonPropertyName("viewOptionSourceId")]
        public String ViewOptionSourceId { get; set; }

        [JsonPropertyName("episodeCount")]
        public Int64 EpisodeCount { get; set; }

        [JsonPropertyName("license")]
        public String License { get; set; }

        [JsonPropertyName("higherPrice")]
        public Boolean HigherPrice { get; set; }

        [JsonPropertyName("price")]
        public Int64 Price { get; set; }

        [JsonPropertyName("inHd")]
        public Boolean InHd { get; set; }

        [JsonPropertyName("in4k")]
        public Boolean In4K { get; set; }

        [JsonPropertyName("allSeasonsIn4k")]
        public Boolean AllSeasonsIn4K { get; set; }

        [JsonPropertyName("priceDisplay")]
        public String PriceDisplay { get; set; }

        [JsonPropertyName("currency")]
        public String Currency { get; set; }

        [JsonPropertyName("latestEpisodeAirDate")]
        public Int64 LatestEpisodeAirDate { get; set; }

        [JsonPropertyName("providerId")]
        public String ProviderId { get; set; }

        [JsonPropertyName("adsProviderId")]
        public String AdsProviderId { get; set; }

        [JsonPropertyName("feedId")]
        public String FeedId { get; set; }

        [JsonPropertyName("providerDetails")]
        public ProviderDetails ProviderDetails { get; set; }

        [JsonPropertyName("adsContentId")]
        public String AdsContentId { get; set; }

        [JsonPropertyName("validityStartTime")]
        public DateTime ValidityStartTime { get; set; }

        [JsonPropertyName("validityEndTime")]
        public DateTime ValidityEndTime { get; set; }

        [JsonPropertyName("dateAdded")]
        public DateTime DateAdded { get; set; }

        [JsonPropertyName("isTrcInGlobal")]
        public Boolean IsTrcInGlobal { get; set; }

        [JsonPropertyName("providerName")]
        public String ProviderName { get; set; }

        [JsonPropertyName("providerType")]
        public String ProviderType { get; set; }

        [JsonPropertyName("creditCuePoints")]
        public List<CreditCuePoint> CreditCuePoints { get; set; }

        [JsonPropertyName("hasMedia")]
        public Boolean HasMedia { get; set; }
    }

    public class ProviderDetails
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("title")]
        public String Title { get; set; }

        [JsonPropertyName("type")]
        public String Type { get; set; }

        [JsonPropertyName("isPrivate")]
        public Boolean IsPrivate { get; set; }

        [JsonPropertyName("providerProductIds")]
        public List<Object> ProviderProductIds { get; set; }

        [JsonPropertyName("otaStationIds")]
        public List<Object> OtaStationIds { get; set; }

        [JsonPropertyName("providerIds")]
        public List<Object> ProviderIds { get; set; }

        [JsonPropertyName("channelStoreCode")]
        public String ChannelStoreCode { get; set; }

        [JsonPropertyName("kidsDirected")]
        public Boolean KidsDirected { get; set; }

        [JsonPropertyName("searchable")]
        public Boolean Searchable { get; set; }

        [JsonPropertyName("tags")]
        public List<Object> Tags { get; set; }

        [JsonPropertyName("minFirmwareVersion")]
        public Int64 MinFirmwareVersion { get; set; }

        [JsonPropertyName("isPromoted")]
        public Boolean IsPromoted { get; set; }

        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        [JsonPropertyName("description")]
        public String Description { get; set; }

        [JsonPropertyName("savable")]
        public Boolean Savable { get; set; }
    }
}
