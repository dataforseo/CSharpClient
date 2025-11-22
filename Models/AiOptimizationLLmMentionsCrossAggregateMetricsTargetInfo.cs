using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLLmMentionsCrossAggregateMetricsTargetInfo 
    {
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseAiOptimizationLLmMentionsTargetElement> Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("aggregation_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AggregationKey { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}