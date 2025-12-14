using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("domain", typeof(AiOptimizationLLmMentionsDomainElement))]
    [JsonInheritance("keyword", typeof(AiOptimizationLLmMentionsKeywordElement))]

    public class BaseAiOptimizationLLmMentionsTargetElement 
    {

        /// <summary>
        /// target domain search scope
        /// <br/>optional field
        /// <br/>possible values:
        /// <br/>any, sources, search_results
        /// <br/>default value: any
        /// </summary>
        [JsonProperty("search_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SearchScope { get; set; }

        /// <summary>
        /// target domain search filter
        /// <br/>optional field
        /// <br/>possible values:
        /// <br/>include, exclude
        /// <br/>default value: include
        /// </summary>
        [JsonProperty("search_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchFilter { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}