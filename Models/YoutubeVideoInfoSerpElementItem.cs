namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class YoutubeVideoInfoSerpElementItem : BaseSerpElementItem
    {
        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP for the target domain
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// ID of the video received in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VideoId { get; set; }

        /// <summary>
        /// title of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the URL of the page where the thumbnail is hosted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thumbnail_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// the ID of the channel where the video is published
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChannelId { get; set; }

        /// <summary>
        /// the name of the channel where the video is published
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChannelName { get; set; }

        /// <summary>
        /// the URL of the channel where the video is published
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// the URL of the page where the logo image of the channel is hosted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_logo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChannelLogo { get; set; }

        /// <summary>
        /// description of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// number of views of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("views_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ViewsCount { get; set; }

        /// <summary>
        /// number of likes on the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("likes_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LikesCount { get; set; }

        /// <summary>
        /// number of comments on the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comments_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CommentsCount { get; set; }

        /// <summary>
        /// the date when the video is published
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publication_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// date and time when the result is published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2022-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// keywords relevant to the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

        /// <summary>
        /// the category the video belongs to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// indicates whether the video is on live
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_live", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// duration of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DurationTime { get; set; }

        /// <summary>
        /// duration of the video in seconds
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration_time_seconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DurationTimeSeconds { get; set; }

        /// <summary>
        /// subtitles in the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subtitles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subtitles { get; set; }

        /// <summary>
        /// array of elements that contain information about all possible streaming qualities of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streaming_quality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<StreamingQualityElement> StreamingQuality { get; set; }

    }
}