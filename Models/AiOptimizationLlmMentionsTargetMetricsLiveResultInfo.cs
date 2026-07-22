using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsTargetMetricsLiveResultInfo 
    {

        /// <summary>
        /// total amount of results relevant to the request
        /// <br/>in this case, always equals 0
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// the number of mentions objects that are omitted in the items array
        /// <br/>in this case, always equals 0
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// the number of results returned in the items array
        /// <br/>in this case, always equals 0
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// aggregated mentions metrics
        /// <br/>contains aggregated LLM mention metrics across all found domains, grouped by various dimensions
        /// </summary>
        [JsonProperty("aggregated_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LlmMentionsAggregatedMetricsInfo AggregatedMetrics { get; set; }

        /// <summary>
        /// individual target results
        /// <br/>in this case, equals null
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}