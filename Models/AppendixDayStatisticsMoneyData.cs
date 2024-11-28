namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixDayStatisticsMoneyData
    {
        [Newtonsoft.Json.JsonProperty("serp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixSerpDayStatisticsMoneyData Serp { get; set; }

        /// <summary>
        /// total amount of money deposited to your account
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

        [Newtonsoft.Json.JsonProperty("total_serp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSerp { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordsDataDayStatisticsMoneyData KeywordsData { get; set; }

        [Newtonsoft.Json.JsonProperty("total_keywords_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalKeywordsData { get; set; }

        [Newtonsoft.Json.JsonProperty("appendix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAppendixsRatesDataInfo Appendix { get; set; }

        [Newtonsoft.Json.JsonProperty("total_appendix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAppendix { get; set; }

        [Newtonsoft.Json.JsonProperty("dataforseo_labs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixDataforseoLabsDayStatisticsRatesData DataforseoLabs { get; set; }

        [Newtonsoft.Json.JsonProperty("total_dataforseo_labs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalDataforseoLabs { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_analytics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixDomainAnalyticsLimitsRatesDataInfo DomainAnalytics { get; set; }

        [Newtonsoft.Json.JsonProperty("total_domain_analytics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalDomainAnalytics { get; set; }

        [Newtonsoft.Json.JsonProperty("merchant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixMerchantLimitsRatesDataInfo Merchant { get; set; }

        [Newtonsoft.Json.JsonProperty("total_merchant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalMerchant { get; set; }

        [Newtonsoft.Json.JsonProperty("on_page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixOnPageDayStatisticsMoneyData OnPage { get; set; }

        [Newtonsoft.Json.JsonProperty("total_on_page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalOnPage { get; set; }

        [Newtonsoft.Json.JsonProperty("business_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBusinessDataDayStatisticsMoneyData BusinessData { get; set; }

        [Newtonsoft.Json.JsonProperty("total_business_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalBusinessData { get; set; }

        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBacklinksDayStatisticsRatesData Backlinks { get; set; }

        [Newtonsoft.Json.JsonProperty("total_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalBacklinks { get; set; }

        [Newtonsoft.Json.JsonProperty("app_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixAppDataDayStatisticsMoneyData AppData { get; set; }

        [Newtonsoft.Json.JsonProperty("total_app_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAppData { get; set; }

        [Newtonsoft.Json.JsonProperty("content_analysis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixContentAnalysisLimitsRatesDataInfo ContentAnalysis { get; set; }

        [Newtonsoft.Json.JsonProperty("total_content_analysis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalContentAnalysis { get; set; }

        [Newtonsoft.Json.JsonProperty("content_generation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixContentGenerationLimitsRatesDataInfo ContentGeneration { get; set; }

        [Newtonsoft.Json.JsonProperty("total_content_generation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalContentGeneration { get; set; }

        /// <summary>
        /// time period for grouping
        /// <br/>day in the yyyy-MM-dd format
        /// <br/>minute in the yyyy-MM-dd HH:mm format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("total_traffic_analytics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalTrafficAnalytics { get; set; }

        [Newtonsoft.Json.JsonProperty("total_reviews", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalReviews { get; set; }

        [Newtonsoft.Json.JsonProperty("reviews", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixDayLimitsRatesDataInfo Reviews { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}