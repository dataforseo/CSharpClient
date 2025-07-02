using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixBingKeywordsDataDayStatisticsDataInfo 
    {
        [JsonProperty("keyword_performance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordPerformance { get; set; }
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SearchVolume { get; set; }
        [JsonProperty("keywords_for_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsForSite { get; set; }
        [JsonProperty("keywords_for_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsForKeywords { get; set; }
        [JsonProperty("audience_estimation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo AudienceEstimation { get; set; }
        [JsonProperty("keyword_suggestions_for_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordSuggestionsForUrl { get; set; }
        [JsonProperty("search_volume_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SearchVolumeHistory { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}