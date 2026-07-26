using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleAutocompleteLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your <c>keyword</c>, please specify it as “%2B”;
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c>;
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/serp/google/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>;
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search bar cursor pointer
        /// <br/>optional field
        /// <br/>the horizontal numerical position of the cursor pointer within the keyword in the search bar;
        /// <br/>by modifying the position of the cursor pointer, you will obtain different autocomplete suggestions for the same seed keyword;
        /// <br/>minimal value: <c>0</c>
        /// <br/>default value: the number of the last character of the specified <c>keyword</c>
        /// <br/>example:
        /// <br/><c>|which query are s</c> - <c>'cursor_pointer': 0</c>
        /// <br/><c>which query is s|</c> - <c>'cursor_pointer': 16</c>
        /// <br/><c>which que|ry is s</c> - <c>'cursor_pointer': 9</c>
        /// </summary>
        [JsonProperty("cursor_pointer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CursorPointer { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>;
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/serp/google/autocomplete/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>;
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/serp/google/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search client for autocomplete
        /// <br/>optional field
        /// <br/>autocomplete results may differ depending on the search client;
        /// <br/>possible values:
        /// <br/><c>chrome</c> — used when google search is opened in google chrome;
        /// <br/><c>chrome-omni</c> — used in the address bar in chrome;
        /// <br/><c>gws-wiz</c> — used in google search home page;
        /// <br/><c>gws-wiz-serp</c> — used in google search engine results page;
        /// <br/><c>safari</c> — used when google search is opened in safari browser;
        /// <br/><c>firefox</c> — used when google search is opened in firefox browser;
        /// <br/><c>psy-ab</c> — may be used when google search is opened in google chrome browser;
        /// <br/><c>toolbar</c> — returns XML;
        /// <br/><c>youtube</c> — returns JSONP;
        /// <br/><c>gws-wiz-local</c> — used in google local;
        /// <br/><c>img</c> — used in google's image search;
        /// <br/><c>products-cc</c> — used in google shopping search
        /// </summary>
        [JsonProperty("client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Client { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
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