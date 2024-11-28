using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleAdsSearchVolumeTaskGetResultInfo
    {
        /// <summary>
        /// keyword
        /// <br/>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// correct spelling of the keyword
        /// <br/>Note:if the keyword in the POST array appears to be misspelled, data will be returned for the correctly spelled keyword;
        /// <br/>we use the functionality of Google Ads API to check and validate the spelling of keywords, learn more by this link
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spell", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Spell { get; set; }

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// indicates whether data from partner networks included in the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_partners", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// competition
        /// <br/>represents the relative amount of competition associated with the given keyword in paid SERP only;
        /// <br/>this value is based on Google Ads data and can take the following values: HIGH, MEDIUM, LOW;
        /// <br/>if there is no data the value is null;
        /// <br/>learn more about the metric in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("competition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Competition { get; set; }

        /// <summary>
        /// competition
        /// <br/>represents the relative amount of competition associated with the given keyword in paid SERP only;
        /// <br/>this value is based on Google Ads data and can be between 0 and 100 (inclusive);
        /// <br/>if there is no data the value is null;
        /// <br/>learn more about the metric in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("competition_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CompetitionIndex { get; set; }

        /// <summary>
        /// monthly average search volume rate;
        /// <br/>represents either the (approximate) number of searches for the given keyword idea on google.com or google.com and partners, depending on the user’s targeting;
        /// <br/>if there is no data then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// minimum bid for the ad to be displayed at the top of the first page
        /// <br/>indicates the value greater than about 20% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers);
        /// <br/>the value may differ depending on the location specified in a POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("low_top_of_page_bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? LowTopOfPageBid { get; set; }

        /// <summary>
        /// maximum bid for the ad to be displayed at the top of the first page
        /// <br/>indicates the value greater than about 80% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers);
        /// <br/>the value may differ depending on the location specified in a POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("high_top_of_page_bid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? HighTopOfPageBid { get; set; }

        /// <summary>
        /// cost per click
        /// <br/>indicates the amount paid for each click on the ad displayed for a given keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Cpc { get; set; }

        /// <summary>
        /// monthly searches
        /// <br/>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months by default), targeted to the specified geographic locations;
        /// <br/>if there is no data then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("monthly_searches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MonthlySearches> MonthlySearches { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}