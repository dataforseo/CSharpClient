using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixPriceData 
    {
        [JsonProperty("keywords_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixKeywordsDataPriceData KeywordsData { get; set; }
        [JsonProperty("merchant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixMerchantPriceData Merchant { get; set; }
        [JsonProperty("serp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpPriceData Serp { get; set; }
        [JsonProperty("appendix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAppendixPriceData Appendix { get; set; }
        [JsonProperty("app_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAppDataPriceData AppData { get; set; }
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBacklinksPriceData Backlinks { get; set; }
        [JsonProperty("business_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessDataPriceData BusinessData { get; set; }
        [JsonProperty("content_analysis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixContentAnalysisPriceData ContentAnalysis { get; set; }
        [JsonProperty("content_generation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixContentGenerationPriceData ContentGeneration { get; set; }
        [JsonProperty("dataforseo_labs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDataforseoLabsPriceData DataforseoLabs { get; set; }
        [JsonProperty("domain_analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDomainAnalyticsPriceData DomainAnalytics { get; set; }
        [JsonProperty("on_page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixOnPagePriceData OnPage { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}