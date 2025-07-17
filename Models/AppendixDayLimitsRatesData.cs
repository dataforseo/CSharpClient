using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixDayLimitsRatesData 
    {
        [JsonProperty("serp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpDaysRatesDataInfo Serp { get; set; }

        /// <summary>
        /// total amount of money deposited to your account
        /// </summary>
        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }
        [JsonProperty("total_serp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalSerp { get; set; }
        [JsonProperty("keywords_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixKeywordsDataDaysRatesDataInfo KeywordsData { get; set; }
        [JsonProperty("total_keywords_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalKeywordsData { get; set; }
        [JsonProperty("appendix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAppendixDaysRatesDataInfo Appendix { get; set; }
        [JsonProperty("total_appendix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAppendix { get; set; }
        [JsonProperty("dataforseo_labs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDataforseoLabsLimitsRatesDataInfo DataforseoLabs { get; set; }
        [JsonProperty("total_dataforseo_labs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalDataforseoLabs { get; set; }
        [JsonProperty("domain_analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDomainAnalyticsLimitsRatesDataInfo DomainAnalytics { get; set; }
        [JsonProperty("total_domain_analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalDomainAnalytics { get; set; }
        [JsonProperty("merchant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixMerchantLimitsRatesDataInfo Merchant { get; set; }
        [JsonProperty("total_merchant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalMerchant { get; set; }
        [JsonProperty("on_page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixOnPageLimitsRatesDataInfo OnPage { get; set; }
        [JsonProperty("total_on_page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalOnPage { get; set; }
        [JsonProperty("business_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessDataLimitsRatesDataInfo BusinessData { get; set; }
        [JsonProperty("total_business_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalBusinessData { get; set; }
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBacklinksLimitsRatesDataInfo Backlinks { get; set; }
        [JsonProperty("total_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalBacklinks { get; set; }
        [JsonProperty("app_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAppDataLimitsRatesDataInfo AppData { get; set; }
        [JsonProperty("total_app_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAppData { get; set; }
        [JsonProperty("content_analysis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixContentAnalysisLimitsRatesDataInfo ContentAnalysis { get; set; }
        [JsonProperty("total_content_analysis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalContentAnalysis { get; set; }
        [JsonProperty("content_generation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixContentGenerationLimitsRatesDataInfo ContentGeneration { get; set; }
        [JsonProperty("total_content_generation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalContentGeneration { get; set; }
        [JsonProperty("total_traffic_analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalTrafficAnalytics { get; set; }
        [JsonProperty("total_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalReviews { get; set; }
        [JsonProperty("total_social", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalSocial { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}