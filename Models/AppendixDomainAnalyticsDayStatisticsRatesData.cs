using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixDomainAnalyticsDayStatisticsRatesData 
    {
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("whois", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixWhoisDomainAnalyticsLimitsRatesDataInfo Whois { get; set; }
        [JsonProperty("technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTechnologiesDomainAnalyticsLimitsRatesDataInfo Technologies { get; set; }
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