namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixBingKeywordsDataPriceData
    {
        [Newtonsoft.Json.JsonProperty("keyword_performance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo KeywordPerformance { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo KeywordsForKeywords { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_site", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo KeywordsForSite { get; set; }

        [Newtonsoft.Json.JsonProperty("search_volume_history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo SearchVolumeHistory { get; set; }

        [Newtonsoft.Json.JsonProperty("search_volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo SearchVolume { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}