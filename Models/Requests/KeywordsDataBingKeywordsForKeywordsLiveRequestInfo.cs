using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataBingKeywordsForKeywordsLiveRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>you can specify the maximum of 200 keywords with each keyword containing no more than 100 characters;
        /// <br/>the specified keywords will be converted to lowercase, data will be provided in a separate array
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don’t specify location_name or location_code
        /// <br/>if you use this field, you don’t need to specify location_name or location_code
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude” format
        /// <br/>the data will be provided for the country the specified coordinates belong to
        /// <br/>example:
        /// <br/>52.6178549,-155.352142
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don’t specify language_code
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>supported languages:
        /// <br/>English, French, German
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>supported languages:
        /// <br/>en, fr, de
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>Use these parameters to sort the results by search_volume, cpc, competition or relevance in the descending order
        /// <br/>default value: relevance
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// keywords negative array
        /// <br/>optional field
        /// <br/>These keywords will be ignored in the results array;
        /// <br/>You can specify a maximum of 200 terms that you want to exclude from the results;
        /// <br/>the specified keywords will be converted to lowercase format
        /// </summary>
        [JsonProperty("keywords_negative", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> KeywordsNegative { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>specify this field if you want to get the data for a particular device type;
        /// <br/>possible values: all, mobile, desktop, tablet
        /// <br/>default value: all
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>you can specify a date from the past 24 months
        /// <br/>if you don’t specify this field, data will be provided for the last 12 months
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2020-01-01'
        /// <br/>Note: we do not recommend using a custom time range for the past year’s dates
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, data will be provided for the last 12 months;
        /// <br/>minimum value: two years back from today’s date;
        /// <br/>maximum value: one month from today’s date;
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2020-03-15'
        /// <br/>Note: we do not recommend using a custom time range for the past year’s dates
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// Bing search partners type
        /// <br/>optional field
        /// <br/>if you specify true, the results will be delivered for owned, operated, and syndicated networks across Bing, Yahoo, AOL and partner sites that host Bing, AOL, and Yahoo search.
        /// <br/>default value: false – results are returned for Bing, AOL, and Yahoo search networks
        /// </summary>
        [JsonProperty("search_partners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

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