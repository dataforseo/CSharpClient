using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AggregatedMetricsInfoTotalInfo 
    {

        /// <summary>
        /// total LLM mentions count
        /// <br/>the number of times the target keyword or domain were mentioned in relation to this specific grouping key
        /// </summary>
        [JsonProperty("mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mentions { get; set; }

        /// <summary>
        /// aggregated AI search volume for mentions within this grouping
        /// <br/>learn more about this metric <see href="https://dataforseo.com/help-center/how-the-ai-search-volume-metric-works-in-llm-mentions">here</see>
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