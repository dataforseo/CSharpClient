using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ClickstreamKeywordInfo 
    {

        /// <summary>
        /// average monthly search volume raterepresents the (approximate) number of searches for the given keyword idea on google.com
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// date and time when keyword data was updatedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// distribution of estimated clickstream-based metrics by genderlearn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("gender_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> GenderDistribution { get; set; }

        /// <summary>
        /// distribution of clickstream-based metrics by agelearn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("age_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> AgeDistribution { get; set; }

        /// <summary>
        /// monthly searchesrepresents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations
        /// </summary>
        [JsonProperty("monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MonthlySearchesInfo> MonthlySearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}