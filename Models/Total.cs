using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Total 
    {

        /// <summary>
        /// location-based grouping
        /// <br/>array of objects containing mention metrics segmented by geographical location
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> Location { get; set; }

        /// <summary>
        /// language-based grouping
        /// <br/>array of objects containing mention metrics segmented by content language
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> Language { get; set; }

        /// <summary>
        /// platform-based grouping
        /// <br/>array of group elements containing mention metrics segmented by AI platform
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> Platform { get; set; }

        /// <summary>
        /// found source domains relevant to the target
        /// <br/>array of objects containing data on top domains that are cited as sources in LLM responses
        /// </summary>
        [JsonProperty("sources_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> SourcesDomain { get; set; }

        /// <summary>
        /// found search results domains relevant to the target
        /// <br/>array of objects containing data on top domains that appear in search results related to LLM queries
        /// </summary>
        [JsonProperty("search_results_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> SearchResultsDomain { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}