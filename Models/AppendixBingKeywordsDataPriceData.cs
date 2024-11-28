namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixBingKeywordsDataPriceData
    {
        [Newtonsoft.Json.JsonProperty("audience_estimation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo AudienceEstimation { get; set; }

        [Newtonsoft.Json.JsonProperty("keyword_performance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordPerformance { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordsForKeywords { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_site", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordsForSite { get; set; }

        [Newtonsoft.Json.JsonProperty("keyword_suggestions_for_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordSuggestionsForUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("search_volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo SearchVolume { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}