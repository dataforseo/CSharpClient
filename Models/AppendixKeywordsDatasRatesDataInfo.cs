using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixKeywordsDatasRatesDataInfo 
    {
        [JsonProperty("keywords_for_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsForKeywords { get; set; }
        [JsonProperty("keywords_for_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsForSite { get; set; }
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SearchVolume { get; set; }
        [JsonProperty("ad_traffic_by_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo AdTrafficByKeywords { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Locations { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("explore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Explore { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Categories { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("bing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataLimitsRatesDataInfo Bing { get; set; }
        [JsonProperty("keyword_performance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordPerformance { get; set; }
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LocationsAndLanguages { get; set; }
        [JsonProperty("google_ads", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixGoogleAdsKeywordsDataLimitsRatesDataInfo GoogleAds { get; set; }
        [JsonProperty("dataforseo_trends", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDataforseoTrendsKeywordsDataLimitsRatesDataInfo DataforseoTrends { get; set; }
        [JsonProperty("clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixClickstreamDataKeywordsDataLimitsRatesDataInfo ClickstreamData { get; set; }
        [JsonProperty("audience_estimation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo AudienceEstimation { get; set; }
        [JsonProperty("keyword_suggestions_for_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordSuggestionsForUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}