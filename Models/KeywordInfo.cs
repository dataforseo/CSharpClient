using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordInfo 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// date and time when keyword data was updatedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// competitionrepresents the relative amount of competition associated with the given keyword. This value is based on Google Ads data and can be between 0 and 1 (inclusive)
        /// </summary>
        [JsonProperty("competition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Competition { get; set; }

        /// <summary>
        /// competition levelrepresents the relative level of competition associated with the given keyword in paid SERP only;possible values: LOW, MEDIUM, HIGHif competition level is unknown, the value is null;learn more about the metric in this help center article
        /// </summary>
        [JsonProperty("competition_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CompetitionLevel { get; set; }

        /// <summary>
        /// cost-per-clickrepresents the average cost per click (USD) historically paid for the keyword
        /// </summary>
        [JsonProperty("cpc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cpc { get; set; }

        /// <summary>
        /// average monthly search volume raterepresents the (approximate) number of searches for the given keyword idea on google.com
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// minimum bid for the ad to be displayed at the top of the first pageindicates the value greater than about 20% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)the value may differ depending on the location specified in a POST request
        /// </summary>
        [JsonProperty("low_top_of_page_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LowTopOfPageBid { get; set; }

        /// <summary>
        /// maximum bid for the ad to be displayed at the top of the first pageindicates the value greater than about 80% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)the value may differ depending on the location specified in a POST request
        /// </summary>
        [JsonProperty("high_top_of_page_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HighTopOfPageBid { get; set; }

        /// <summary>
        /// product and service categoriesyou can download the_full list of possible categoriesn
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<int?> Categories { get; set; }

        /// <summary>
        /// monthly searchesrepresents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations
        /// </summary>
        [JsonProperty("monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MonthlySearchesInfo> MonthlySearches { get; set; }

        /// <summary>
        /// search volume trend changesrepresents search volume change in percent compared to the previous period
        /// </summary>
        [JsonProperty("search_volume_trend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SearchVolumeTrend SearchVolumeTrend { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}