using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleAutocompleteLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the keyword field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your keyword, please specify it as “%2B”;
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify location_name;
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/serp/google/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify language_name
        /// <br/>if you use this field, you don't need to specify language_name;
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search bar cursor pointer
        /// <br/>optional field
        /// <br/>the horizontal numerical position of the cursor pointer within the keyword in the search bar;
        /// <br/>by modifying the position of the cursor pointer, you will obtain different autocomplete suggestions for the same seed keyword;
        /// <br/>minimal value: 0
        /// <br/>default value: the number of the last character of the specified keyword
        /// <br/>example:
        /// <br/>|which query are s - 'cursor_pointer': 0
        /// <br/>which query is s| - 'cursor_pointer': 16
        /// <br/>which que|ry is s - 'cursor_pointer': 9
        /// </summary>
        [JsonProperty("cursor_pointer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CursorPointer { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify location_code
        /// <br/>if you use this field, you don't need to specify location_code;
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/serp/google/autocomplete/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify language_code
        /// <br/>if you use this field, you don't need to specify language_code;
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/serp/google/languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search client for autocomplete
        /// <br/>optional field
        /// <br/>autocomplete results may differ depending on the search client;
        /// <br/>possible values:
        /// <br/>chrome — used when google search is opened in google chrome;
        /// <br/>chrome-omni — used in the address bar in chrome;
        /// <br/>gws-wiz — used in google search home page;
        /// <br/>gws-wiz-serp — used in google search engine results page;
        /// <br/>safari — used when google search is opened in safari browser;
        /// <br/>firefox — used when google search is opened in firefox browser;
        /// <br/>psy-ab — may be used when google search is opened in google chrome browser;
        /// <br/>toolbar — returns XML;
        /// <br/>youtube — returns JSONP;
        /// <br/>gws-wiz-local — used in google local;
        /// <br/>img — used in google's image search;
        /// <br/>products-cc — used in google shopping search
        /// </summary>
        [JsonProperty("client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Client { get; set; }

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