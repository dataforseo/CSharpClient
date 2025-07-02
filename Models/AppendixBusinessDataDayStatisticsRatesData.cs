using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixBusinessDataDayStatisticsRatesData 
    {
        [JsonProperty("google", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessDataGoogleInfo Google { get; set; }
        [JsonProperty("locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Locations { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("yelp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessDataDayLimitsRatesDataInfo Yelp { get; set; }
        [JsonProperty("social_media", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixSocialMediaBusinessDataLimitsRatesDataInfo SocialMedia { get; set; }
        [JsonProperty("tripadvisor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessDataDayLimitsRatesDataInfo Tripadvisor { get; set; }
        [JsonProperty("trustpilot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessDataDayLimitsRatesDataInfo Trustpilot { get; set; }
        [JsonProperty("business_listings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBusinessListingsBusinessDataLimitsRatesDataInfo BusinessListings { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableFilters { get; set; }
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