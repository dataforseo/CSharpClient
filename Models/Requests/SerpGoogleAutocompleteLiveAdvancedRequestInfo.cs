using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleAutocompleteLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// keywordrequired fieldyou can specify up to 700 characters in the keyword fieldall %## will be decoded (plus character ‘+’ will be decoded to a space character)if you need to use the “%” character for your keyword, please specify it as “%25”;if you need to use the “+” character for your keyword, please specify it as “%2B”;learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine location coderequired field if you don't specify location_name;you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/serp/google/locationsexample:2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language coderequired field if you don't specify language_nameif you use this field, you don't need to specify language_name;you can receive the list of available languages of the search engine with their language_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/languagesexample:en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search bar cursor pointeroptional fieldthe horizontal numerical position of the cursor pointer within the keyword in the search bar;by modifying the position of the cursor pointer, you will obtain different autocomplete suggestions for the same seed keyword;minimal value: 0default value: the number of the last character of the specified keywordexample:|which query are s - 'cursor_pointer': 0which query is s| - 'cursor_pointer': 16which que|ry is s - 'cursor_pointer': 9
        /// </summary>
        [JsonProperty("cursor_pointer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CursorPointer { get; set; }

        /// <summary>
        /// full name of search engine locationrequired field if you don't specify location_codeif you use this field, you don't need to specify location_code;you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/serp/google/autocomplete/locationsexample:London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// full name of search engine languagerequired field if you don't specify language_codeif you use this field, you don't need to specify language_code;you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/serp/google/languagesexample:English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search client for autocompleteoptional fieldautocomplete results may differ depending on the search client;possible values:chrome — used when google search is opened in google chrome;chrome-omni — used in the address bar in chrome;gws-wiz — used in google search home page;gws-wiz-serp — used in google search engine results page;safari — used when google search is opened in safari browser;firefox — used when google search is opened in firefox browser;psy-ab — may be used when google search is opened in google chrome browser;toolbar — returns XML;youtube — returns JSONP;gws-wiz-local — used in google local;img — used in google's image search;products-cc — used in google shopping search
        /// </summary>
        [JsonProperty("client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Client { get; set; }

        /// <summary>
        /// user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response
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