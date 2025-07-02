using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixAppDataDayStatisticsRatesData 
    {
        [JsonProperty("app_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo AppInfo { get; set; }
        [JsonProperty("app_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo AppList { get; set; }
        [JsonProperty("app_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo AppReviews { get; set; }
        [JsonProperty("app_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo AppSearches { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Locations { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Categories { get; set; }
        [JsonProperty("app_listings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessListingsBusinessDataLimitsRatesDataInfo AppListings { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IdList { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}