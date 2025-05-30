using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class YoutubeVideoInfoSerpElementItem  : BaseYoutubeSerpElementItem 
    {

        /// <summary>
        /// ID of the video received in a POST array
        /// </summary>
        [JsonProperty("video_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }

        /// <summary>
        /// title of the video
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL of the video
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the URL of the page where the thumbnail is hosted
        /// </summary>
        [JsonProperty("thumbnail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// the ID of the channel where the video is published
        /// </summary>
        [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelId { get; set; }

        /// <summary>
        /// the name of the channel where the video is published
        /// </summary>
        [JsonProperty("channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelName { get; set; }

        /// <summary>
        /// the URL of the channel where the video is published
        /// </summary>
        [JsonProperty("channel_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// the URL of the page where the logo image of the channel is hosted
        /// </summary>
        [JsonProperty("channel_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelLogo { get; set; }

        /// <summary>
        /// description of the video
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// number of views of the video
        /// </summary>
        [JsonProperty("views_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ViewsCount { get; set; }

        /// <summary>
        /// number of likes on the video
        /// </summary>
        [JsonProperty("likes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LikesCount { get; set; }

        /// <summary>
        /// number of comments on the video
        /// </summary>
        [JsonProperty("comments_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CommentsCount { get; set; }

        /// <summary>
        /// number of subscribers of the channel
        /// </summary>
        [JsonProperty("channel_subscribers_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChannelSubscribersCount ChannelSubscribersCount { get; set; }

        /// <summary>
        /// the date when the video is published
        /// </summary>
        [JsonProperty("publication_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// date and time when the result is published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2022-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// keywords relevant to the video
        /// </summary>
        [JsonProperty("keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// the category the video belongs to
        /// </summary>
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// indicates whether the video is on live
        /// </summary>
        [JsonProperty("is_live", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// indicates whether the video is embeddable
        /// </summary>
        [JsonProperty("is_embeddable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEmbeddable { get; set; }

        /// <summary>
        /// duration of the video
        /// </summary>
        [JsonProperty("duration_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DurationTime { get; set; }

        /// <summary>
        /// duration of the video in seconds
        /// </summary>
        [JsonProperty("duration_time_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DurationTimeSeconds { get; set; }

        /// <summary>
        /// array of elements describing properties of subtitles in the video
        /// </summary>
        [JsonProperty("subtitles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Subtitles> Subtitles { get; set; }

        /// <summary>
        /// array of elements that contain information about all possible streaming qualities of the video
        /// </summary>
        [JsonProperty("streaming_quality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<StreamingQualityElement> StreamingQuality { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}