using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PreviewVideos 
    {

        /// <summary>
        /// ID of the video
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