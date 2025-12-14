using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionssLiveItem 
    {

        /// <summary>
        /// URL of a found page
        /// <br/>the URL of a page found in LLM mentions for the specified target
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// location-based grouping
        /// <br/>array of objects containing page mention metrics segmented by geographical location
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> Location { get; set; }

        /// <summary>
        /// language-based grouping
        /// <br/>array of objects containing page mention metrics segmented by content language
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> Language { get; set; }

        /// <summary>
        /// platform-based grouping
        /// <br/>array of group elements containing page mention metrics segmented by AI platform
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> Platform { get; set; }

        /// <summary>
        /// source domains relevant to the specific page
        /// <br/>array of objects containing data on domains that are cited as sources in LLM responses
        /// </summary>
        [JsonProperty("sources_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> SourcesDomain { get; set; }

        /// <summary>
        /// search results domains relevant to the specific page
        /// <br/>array of objects containing data on domains that appear in search results related to LLM queries
        /// </summary>
        [JsonProperty("search_results_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> SearchResultsDomain { get; set; }

        /// <summary>
        /// data on brand entities relevant to the target
        /// <br/>array of objects containing data on brand entity titles that appear in search results related to LLM queries
        /// </summary>
        [JsonProperty("brand_entities_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> BrandEntitiesTitle { get; set; }

        /// <summary>
        /// data on brand entities relevant to the target
        /// <br/>array of objects containing data on brand entity categories that appear in search results related to LLM queries
        /// </summary>
        [JsonProperty("brand_entities_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GroupElement> BrandEntitiesCategory { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}