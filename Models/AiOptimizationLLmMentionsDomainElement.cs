using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLLmMentionsDomainElement  : BaseAiOptimizationLLmMentionsTargetElement 
    {

        /// <summary>
        /// target domain
        /// <br/>required field if you don’t specify keyword
        /// <br/>a domain should be specified without https:// and www.
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// indicates if the subdomains of the target domain will be included in the search
        /// <br/>optional field
        /// <br/>if set to true, the subdomains will be included in the search
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}