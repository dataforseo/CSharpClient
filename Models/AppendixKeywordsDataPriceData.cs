namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixKeywordsDataPriceData
    {
        [Newtonsoft.Json.JsonProperty("tasks_ready", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo TasksReady { get; set; }

        [Newtonsoft.Json.JsonProperty("ad_traffic_by_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo AdTrafficByKeywords { get; set; }

        [Newtonsoft.Json.JsonProperty("audience_estimation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo AudienceEstimation { get; set; }

        [Newtonsoft.Json.JsonProperty("bing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceData Bing { get; set; }

        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Categories { get; set; }

        [Newtonsoft.Json.JsonProperty("clickstream_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixClickstreamDataKeywordsDataPriceData ClickstreamData { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("google_ads", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixGoogleAdsKeywordsDataPriceData GoogleAds { get; set; }

        [Newtonsoft.Json.JsonProperty("keyword_performance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordPerformance { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordsForKeywords { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_site", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordsForSite { get; set; }

        [Newtonsoft.Json.JsonProperty("keyword_suggestions_for_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo KeywordSuggestionsForUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("languages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Languages { get; set; }

        [Newtonsoft.Json.JsonProperty("locations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Locations { get; set; }

        [Newtonsoft.Json.JsonProperty("locations_and_languages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo LocationsAndLanguages { get; set; }

        [Newtonsoft.Json.JsonProperty("search_volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAKeywordsDataPriceDataInfo SearchVolume { get; set; }

        [Newtonsoft.Json.JsonProperty("dataforseo_trends", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixDataforseoTrendsKeywordsDataPriceData DataforseoTrends { get; set; }

        [Newtonsoft.Json.JsonProperty("explore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixExploreKeywordsDataPriceData Explore { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}