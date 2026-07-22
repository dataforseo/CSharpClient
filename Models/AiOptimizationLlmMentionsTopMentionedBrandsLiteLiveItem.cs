using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsTopMentionedBrandsLiteLiveItem 
    {

        /// <summary>
        /// brand name
        /// <br/>brand identifier of aggregated metrics
        /// </summary>
        [JsonProperty("brand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// location identifier
        /// <br/>location of aggregated metrics
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Location { get; set; }

        /// <summary>
        /// language identifier
        /// <br/>language of aggregated metrics
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// LLM platform identifiers
        /// <br/>LLM platform of aggregated metrics
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// LLM metrics
        /// <br/>metrics aggregated by specific parameters and respective identifiers
        /// </summary>
        [JsonProperty("metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AggregatedMetricsInfoTotalInfo Metrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}