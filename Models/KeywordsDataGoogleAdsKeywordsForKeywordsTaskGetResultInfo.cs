using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResultInfo 
    {

        /// <summary>
        /// keyword in a POST array
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }
        [JsonProperty("spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Spell { get; set; }

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, the value is null
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>if there is no data, the value is null
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// include Google search partners
        /// <br/>the value you specified when setting the task
        /// <br/>if true, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;
        /// <br/>if false, the results are returned for Google search sites only
        /// </summary>
        [JsonProperty("search_partners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// competition
        /// <br/>represents the relative level of competition associated with the given keyword in paid SERP only
        /// <br/>possible values: LOW, MEDIUM, HIGH
        /// <br/>if competition level is unknown, the value is null;
        /// <br/>learn more about the metric in this help center article
        /// </summary>
        [JsonProperty("competition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Competition { get; set; }

        /// <summary>
        /// competition index
        /// <br/>the competition index for the query indicating how competitive ad placement is for the keyword
        /// <br/>can take values from 0 to 100
        /// <br/>the level of competition from 0 to 100 is determined by the number of ad slots filled divided by the total number of ad slots available
        /// <br/>if not enough data is available, the value is null;
        /// <br/>learn more about the metric in this help center article
        /// </summary>
        [JsonProperty("competition_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CompetitionIndex { get; set; }

        /// <summary>
        /// monthly average search volume rate
        /// <br/>represents the (approximate) number of searches for the given keyword idea either on google.com or google.com and partners, depending on the user’s targeting
        /// <br/>if there is no data, the value is null
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// minimum bid for the ad to be displayed at the top of the first page
        /// <br/>indicates the value greater than about 20% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)
        /// <br/>the value may differ depending on the location specified in a POST request
        /// </summary>
        [JsonProperty("low_top_of_page_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LowTopOfPageBid { get; set; }

        /// <summary>
        /// maximum bid for the ad to be displayed at the top of the first page
        /// <br/>indicates the value greater than about 80% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)
        /// <br/>the value may differ depending on the location specified in a POST request
        /// </summary>
        [JsonProperty("high_top_of_page_bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HighTopOfPageBid { get; set; }

        /// <summary>
        /// cost per click
        /// <br/>indicates the amount paid (USD) for each click on the ad displayed for a given keyword
        /// </summary>
        [JsonProperty("cpc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cpc { get; set; }

        /// <summary>
        /// monthly searches
        /// <br/>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations
        /// <br/>if there is no data, the value is null
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