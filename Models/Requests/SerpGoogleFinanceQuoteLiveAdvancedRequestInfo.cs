using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleFinanceQuoteLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// ticker or stock symbol
        /// <br/>required field
        /// <br/>in this field you can pass the ticker symbol of publicly traded shares of a particular stock or security on a particular stock exchange;
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> field;
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your <c>keyword</c>, please specify it as “%2B”;
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/serp/google/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>return results for a specific device type
        /// <br/>possible value: <c>desktop</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to  <c>https://api.dataforseo.com/v3/serp/google/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c> 
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>possible values: <c>windows</c>
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// time window for <c>google_finance_quote</c> graph
        /// <br/>optional field
        /// <br/>possible values: <c>1D</c>, <c>5D</c>, <c>1M</c>, <c>6M</c>, <c>YTD</c>, <c>1Y</c>, <c>5Y</c>, <c>MAX</c>
        /// <br/>default value: <c>1D</c>
        /// <br/>Note: if you specify a value that is different from <c>1D</c>, the charge per task will be multiplied by 2
        /// </summary>
        [JsonProperty("window", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Window { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}