using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 1000
        /// <br/>The maximum number of characters for each keyword: 80
        /// <br/>The maximum number of words for each keyword phrase: 10
        /// <br/>the keywords you specify will be converted to a lowercase format
        /// <br/>Note: Google Ads may return no data for certain groups of keywords
        /// <br/>visit our Help Center to learn more
        /// <br/>Also note that Google Ads doesn’t allow using certain symbols and characters (e.g., UTF symbols, emojis), so you can’t use them when setting a task;
        /// <br/>to learn more about which symbols and characters can be used, please refer to this article
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// the maximum custom bid
        /// <br/>required field
        /// <br/>the collected data will be based on this value
        /// <br/>it stands for the price you are willing to pay for an ad; the higher value you specify here, the higher values you will get in the returned metrics
        /// <br/>learn more in this help center article
        /// </summary>
        [JsonProperty("bid", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? Bid { get; set; }

        /// <summary>
        /// keywords match-type
        /// <br/>required field
        /// <br/>can take the following values: exact, broad, phrase
        /// </summary>
        [JsonProperty("match", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Match { get; set; }

        /// <summary>
        /// include Google search partners
        /// <br/>optional field
        /// <br/>if you specify true, the results will be delivered for owned, operated, and syndicated networks across Google and partner sites that host Google search;
        /// <br/>default value: false – results are returned for Google search sites
        /// </summary>
        [JsonProperty("search_partners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate;
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>optional field
        /// <br/>if you do not indicate the location, you will receive worldwide results, i.e., for all available locations;
        /// <br/>if you use this field, you don’t need to specify location_name or location_code;
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude” format;
        /// <br/>the data will be provided for the country the specified coordinates belong to;
        /// <br/>example:
        /// <br/>52.6178549,-155.352142
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/google_ads/languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// starting date of the forecasting time range
        /// <br/>required field if you specify date_to
        /// <br/>if you indicate date_from and date_to, you don’t need to specify date_interval
        /// <br/>minimum value is tomorrow’s date
        /// <br/>the value you specify in date_from shouldn’t be further than date_to
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2021-10-30'if Status endpoint returns false in the actual_data field, date_from can be set to the month before last and prior;
        /// <br/>if Status endpoint returns true in the actual_data field, date_from can be set to the last month and prior
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the forecasting time range
        /// <br/>required field if you specify date_from
        /// <br/>if you indicate date_from and date_to, you don’t need to specify date_interval
        /// <br/>minimum value is date_from +1 day
        /// <br/>maximum value is current day and month of the next year
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2022-10-30'
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// forecasting date interval
        /// <br/>optional field
        /// <br/>if you specify date_interval, you don’t need to indicate date_from and date_to
        /// <br/>possible values: next_week, next_month, next_quarter
        /// <br/>default value: next_month
        /// </summary>
        [JsonProperty("date_interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateInterval { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>Use these parameters to sort the results by relevance, impressions, ctr, average_cpc, cost, or clicks in the descending order
        /// <br/>default value: relevance
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}