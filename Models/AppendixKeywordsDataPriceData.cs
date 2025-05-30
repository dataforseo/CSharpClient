using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixKeywordsDataPriceData 
    {
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo TasksReady { get; set; }
        [JsonProperty("ad_traffic_by_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo AdTrafficByKeywords { get; set; }
        [JsonProperty("audience_estimation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo AudienceEstimation { get; set; }
        [JsonProperty("bing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceData Bing { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Categories { get; set; }
        [JsonProperty("clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixClickstreamDataKeywordsDataPriceData ClickstreamData { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }
        [JsonProperty("google_ads", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleAdsKeywordsDataPriceData GoogleAds { get; set; }
        [JsonProperty("keyword_performance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordPerformance { get; set; }
        [JsonProperty("keywords_for_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordsForKeywords { get; set; }
        [JsonProperty("keywords_for_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordsForSite { get; set; }
        [JsonProperty("keyword_suggestions_for_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordSuggestionsForUrl { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Languages { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Locations { get; set; }
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo LocationsAndLanguages { get; set; }
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo SearchVolume { get; set; }
        [JsonProperty("dataforseo_trends", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDataforseoTrendsKeywordsDataPriceData DataforseoTrends { get; set; }
        [JsonProperty("explore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixExploreKeywordsDataPriceData Explore { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}