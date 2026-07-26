using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLlmMentionsTopMentionedBrandsLiveItem 
    {

        /// <summary>
        /// brand name
        /// <br/>name of the brand found in LLM mentions for the specified target
        /// </summary>
        [JsonProperty("brand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// location-based grouping
        /// <br/>array of objects containing mention metrics segmented by geographical location
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AggregatedMetricsItemInfo> Location { get; set; }

        /// <summary>
        /// language-based grouping
        /// <br/>array of objects containing mention metrics segmented by content language
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AggregatedMetricsItemInfo> Language { get; set; }

        /// <summary>
        /// platform-based grouping
        /// <br/>array of group elements containing mention metrics segmented by AI platform
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AggregatedMetricsItemInfo> Platform { get; set; }

        /// <summary>
        /// found top source domains relevant to the target
        /// <br/>array of objects containing data on top domains that are cited as sources in LLM responses
        /// <br/>learn more about the sources and how to retrieve LLM citation data at our <see href="https://dataforseo.com/help-center/how-to-get-llm-citation-data-with-llm-mentions-api">Help Center</see>
        /// </summary>
        [JsonProperty("sources_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AggregatedMetricsItemInfo> SourcesDomain { get; set; }

        /// <summary>
        /// found top search results domains relevant to the target
        /// <br/>array of objects containing data on top domains that appear in search results related to LLM queries
        /// </summary>
        [JsonProperty("search_results_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AggregatedMetricsItemInfo> SearchResultsDomain { get; set; }

        /// <summary>
        /// data on brand entities relevant to the target
        /// <br/>array of objects containing data on brand entity titles that appear in search results related to LLM queries
        /// </summary>
        [JsonProperty("brand_entities_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AggregatedMetricsItemInfo> BrandEntitiesTitle { get; set; }

        /// <summary>
        /// data on brand entities relevant to the target
        /// <br/>array of objects containing data on brand entity categories that appear in search results related to LLM queries
        /// </summary>
        [JsonProperty("brand_entities_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AggregatedMetricsItemInfo> BrandEntitiesCategory { get; set; }

        /// <summary>
        /// aggregated mentions metrics summary
        /// <br/>contains overall aggregated LLM mention metrics across all dimensions
        /// </summary>
        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AggregatedMetricsInfoTotalInfo Total { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}