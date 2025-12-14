using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsAggregatedMetricsLiveResultInfo 
    {

        /// <summary>
        /// aggregated mentions metrics summary
        /// <br/>contains overall aggregated LLM mention metrics across all found domains, grouped by various dimensions
        /// </summary>
        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AiOptimizationResultTotalInfo Total { get; set; }

        /// <summary>
        /// individual pages results
        /// <br/>array containing detailed mention metrics for each of the found top pages
        /// <br/>in this case, equals null
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}