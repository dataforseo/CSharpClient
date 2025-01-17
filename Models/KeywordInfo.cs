namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordInfo
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// date and time when keyword data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_updated_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// competition
        /// <br/>represents the relative amount of competition associated with the given keyword. This value is based on Google Ads data and can be between 0 and 1 (inclusive)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("competition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Competition { get; set; }

        /// <summary>
        /// competition level
        /// <br/>represents the relative level of competition associated with the given keyword in paid SERP only;
        /// <br/>possible values: LOW, MEDIUM, HIGH
        /// <br/>if competition level is unknown, the value is null;
        /// <br/>learn more about the metric in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("competition_level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompetitionLevel { get; set; }

        /// <summary>
        /// cost-per-click
        /// <br/>represents the average cost per click (USD) historically paid for the keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Cpc { get; set; }

        /// <summary>
        /// average monthly search volume rate
        /// <br/>represents the (approximate) number of searches for the given keyword idea on google.com
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// minimum bid for the ad to be displayed at the top of the first page
        /// <br/>indicates the value greater than about 20% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)
        /// <br/>the value may differ depending on the location specified in a POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("low_top_of_page_bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? LowTopOfPageBid { get; set; }

        /// <summary>
        /// maximum bid for the ad to be displayed at the top of the first page
        /// <br/>indicates the value greater than about 80% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)
        /// <br/>the value may differ depending on the location specified in a POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("high_top_of_page_bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? HighTopOfPageBid { get; set; }

        /// <summary>
        /// product and service categories
        /// <br/>you can download the full list of possible categories
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> Categories { get; set; }

        /// <summary>
        /// monthly searches
        /// <br/>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations
        /// </summary>
        [Newtonsoft.Json.JsonProperty("monthly_searches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MonthlySearches> MonthlySearches { get; set; }

        /// <summary>
        /// search volume trend changes\nrepresents search volume change in percent compared to the previous period
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_volume_trend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SearchVolumeTrendInfo SearchVolumeTrend { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}