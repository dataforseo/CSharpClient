using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
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
        /// indicates if the subdomains of the target domain will be included in the search
        /// <br/>optional field
        /// <br/>if set to true, the subdomains will be included in the search
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

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