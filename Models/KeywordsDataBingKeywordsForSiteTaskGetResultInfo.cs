using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataBingKeywordsForSiteTaskGetResultInfo 
    {

        /// <summary>
        /// keyword in a POST array
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data the value is null
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>if there is no data the value is null
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// indicates whether data from partner networks included in the response
        /// </summary>
        [JsonProperty("search_partners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// device type in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// competition
        /// <br/>represents the relative amount of competition associated with the given keyword in paid SERP only. This value is based on Bing Ads data.
        /// <br/>Possible values: 0.1, 0.5,0.9 
        /// <br/>0.1 – low competition,
        /// <br/>0.5 – medium competition,
        /// <br/>0.9 – high competition;
        /// <br/>if there is no data the value is null
        /// </summary>
        [JsonProperty("competition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Competition { get; set; }

        /// <summary>
        /// cost-per-click
        /// <br/>represents the average cost per click (USD) historically paid for the keyword.
        /// <br/>if there is no data the value is null
        /// </summary>
        [JsonProperty("cpc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Cpc { get; set; }

        /// <summary>
        /// monthly average search volume rate
        /// <br/>represents the (approximate) number of searches for the given keyword idea on Bing search engine depending on the user’s targeting
        /// <br/>if there is no data then the value is null
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// product and service categories
        /// <br/>legacy field, the value will always be null
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// monthly searches
        /// <br/>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations
        /// <br/>search volume is rounded to the closest decimal values
        /// <br/>if there is no data the value is null
        /// </summary>
        [JsonProperty("monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MonthlySearches> MonthlySearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}