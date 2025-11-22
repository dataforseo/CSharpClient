using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsTopDomainsLiveResultInfo 
    {

        /// <summary>
        /// aggregated mentions metrics summary
        /// <br/>contains overall aggregated LLM mention metrics across all found domains, grouped by various dimensions
        /// </summary>
        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Total Total { get; set; }

        /// <summary>
        /// individual domain results
        /// <br/>array containing detailed mention metrics for each of the found top domains
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiOptimizationLlmMentionssLiveItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}