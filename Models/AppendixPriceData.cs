namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixPriceData
    {
        [Newtonsoft.Json.JsonProperty("keywords_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordsDataPriceData KeywordsData { get; set; }

        [Newtonsoft.Json.JsonProperty("merchant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixMerchantPriceData Merchant { get; set; }

        [Newtonsoft.Json.JsonProperty("serp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixSerpPriceData Serp { get; set; }

        [Newtonsoft.Json.JsonProperty("appendix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAppendixPriceData Appendix { get; set; }

        [Newtonsoft.Json.JsonProperty("app_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAppDataPriceData AppData { get; set; }

        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBacklinksPriceData Backlinks { get; set; }

        [Newtonsoft.Json.JsonProperty("business_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBusinessDataPriceData BusinessData { get; set; }

        [Newtonsoft.Json.JsonProperty("content_analysis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixContentAnalysisPriceData ContentAnalysis { get; set; }

        [Newtonsoft.Json.JsonProperty("content_generation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixContentGenerationPriceData ContentGeneration { get; set; }

        [Newtonsoft.Json.JsonProperty("dataforseo_labs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixDataforseoLabsPriceData DataforseoLabs { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_analytics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixDomainAnalyticsPriceData DomainAnalytics { get; set; }

        [Newtonsoft.Json.JsonProperty("on_page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixOnPagePriceData OnPage { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}