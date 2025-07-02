using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class FetchTiming 
    {

        /// <summary>
        /// indicates how many milliseconds it took to fetch a resource
        /// </summary>
        [JsonProperty("duration_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationTime { get; set; }

        /// <summary>
        /// time to start downloading the resource
        /// <br/>the amount of time a browser needs to start downloading a resource
        /// </summary>
        [JsonProperty("fetch_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchStart { get; set; }

        /// <summary>
        /// time to complete downloading the resource
        /// <br/>the amount of time a browser needs to complete downloading a resource
        /// </summary>
        [JsonProperty("fetch_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchEnd { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}