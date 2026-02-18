using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiYoutubeVideoElementItem  : BaseSerpApiYoutubeOrganicElementItem 
    {

        /// <summary>
        /// title of the video
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// ID of the video
        /// </summary>
        [JsonProperty("video_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }

        /// <summary>
        /// the URL of the page where the thumbnail is hosted
        /// </summary>
        [JsonProperty("thumbnail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

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
        /// description of the channel
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// highlighted keywords in the description
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        /// <summary>
        /// video badges
        /// <br/>example:
        /// <br/>New, CC, 4K
        /// </summary>
        [JsonProperty("badges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Badges { get; set; }

        /// <summary>
        /// indicates whether the video is a live broadcast
        /// </summary>
        [JsonProperty("is_live", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLive { get; set; }

        /// <summary>
        /// indicates whether the video is shorts
        /// </summary>
        [JsonProperty("is_shorts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShorts { get; set; }

        /// <summary>
        /// indicates whether the video is a movie
        /// </summary>
        [JsonProperty("is_movie", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMovie { get; set; }

        /// <summary>
        /// number of views of the video
        /// </summary>
        [JsonProperty("views_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ViewsCount { get; set; }

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
        /// duration of the video
        /// </summary>
        [JsonProperty("duration_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DurationTime { get; set; }

        /// <summary>
        /// duration of the video in seconds
        /// </summary>
        [JsonProperty("duration_time_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationTimeSeconds { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}