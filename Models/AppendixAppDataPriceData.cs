using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAppDataPriceData 
    {
        [JsonProperty("app_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixProductGoogleMerchantPriceDataInfo AppInfo { get; set; }
        [JsonProperty("app_listings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixAppListingsAppDataPriceData AppListings { get; set; }
        [JsonProperty("app_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixProductGoogleMerchantPriceDataInfo AppList { get; set; }
        [JsonProperty("app_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixPriceDataInfo AppReviews { get; set; }
        [JsonProperty("app_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixProductGoogleMerchantPriceDataInfo AppSearches { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Categories { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Languages { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Locations { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo TasksReady { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}