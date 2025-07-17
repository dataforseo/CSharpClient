using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class FetchTiming 
    {

        /// <summary>
        /// indicates how many seconds it took to download a page
        /// </summary>
        [JsonProperty("duration_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationTime { get; set; }

        /// <summary>
        /// time to start downloading the HTML resource
        /// <br/>the amount of time the browser needs to start downloading a page
        /// </summary>
        [JsonProperty("fetch_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchStart { get; set; }

        /// <summary>
        /// time to complete downloading the HTML resource
        /// <br/>the amount of time the browser needs to complete downloading a page
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