using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AggregatedMetricsItemInfo 
    {

        /// <summary>
        /// grouping identifier
        /// <br/>the specific identifier for the grouping dimension
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// total LLM mentions count
        /// <br/>the number of times the target keyword or domain were mentioned in relation to this specific grouping key
        /// </summary>
        [JsonProperty("mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mentions { get; set; }

        /// <summary>
        /// aggregated AI search volume for mentions within this grouping
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AiSearchVolume { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}