using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiAiModeAiOverviewVideoElementItem  : BaseSerpApiAiModeAiOverviewElementItem 
    {

        /// <summary>
        /// title of the element in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// additional information for the video
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// relevant URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain name of the reference
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// URL of the image
        /// <br/>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available)
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// reference source name or title
        /// </summary>
        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// date when the video was published or indexed
        /// <br/>example:
        /// <br/>Apr 26, 2024
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// date and time when the video was published or indexed
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}