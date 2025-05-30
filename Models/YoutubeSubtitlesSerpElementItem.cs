using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class YoutubeSubtitlesSerpElementItem  : BaseYoutubeSerpElementItem 
    {

        /// <summary>
        /// text translated in subtitles
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// the second subtitled text starts
        /// </summary>
        [JsonProperty("start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? StartTime { get; set; }

        /// <summary>
        /// the second subtitled text ends
        /// </summary>
        [JsonProperty("end_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? EndTime { get; set; }

        /// <summary>
        /// duration of subtitles in seconds
        /// </summary>
        [JsonProperty("duration_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DurationTime { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}