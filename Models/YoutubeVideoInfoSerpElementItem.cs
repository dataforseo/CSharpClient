namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class YoutubeVideoInfoSerpElementItem : BaseYoutubeSerpElementItem
    {
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
        /// number of subscribers of the channel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_subscribers_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChannelSubscribersCount ChannelSubscribersCount { get; set; }

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
        /// indicates whether the video is embeddable
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_embeddable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsEmbeddable { get; set; }

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
        /// array of elements describing properties of subtitles in the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subtitles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Subtitles> Subtitles { get; set; }

        /// <summary>
        /// array of elements that contain information about all possible streaming qualities of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streaming_quality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<StreamingQualityElement> StreamingQuality { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}