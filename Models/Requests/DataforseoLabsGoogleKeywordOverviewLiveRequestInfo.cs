using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleKeywordOverviewLiveRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>The maximum number of keywords you can specify: 700
        /// <br/>The maximum number of characters for each keyword: 80
        /// <br/>The maximum number of words for each keyword phrase: 10
        /// <br/>the specified keywords will be converted to lowercase format, data will be provided in a separate array
        /// <br/>note that if some of the keywords specified in this array are omitted in the results you receive, then our database doesn't contain such keywords and cannot return data on them
        /// <br/>you will not be charged for the keywords omitted in the results
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don't specify <c>location_code</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don't specify <c>location_name</c>
        /// <br/>Note: it is required to specify either <c>location_name</c> or <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>you can receive the list of available locations with their <c>language_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>Note: it is required to specify either <c>language_name</c> or <c>language_code</c>
        /// <br/>you can receive the list of available locations with their <c>language_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// include data from SERP for each keyword
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, we will return a <c>serp_info</c> array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>optional field
        /// <br/>if the parameter is set to <c>true</c>, you will receive <c>clickstream_keyword_info</c>, <c>keyword_info_normalized_with_clickstream</c>, and <c>keyword_info_normalized_with_bing</c> fields in the response
        /// <br/>default value: <c>false</c>
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>learn more about how clickstream-based metrics are calculated in this <see href="https://dataforseo.com/help-center/what-are-clickstream-based-metrics-and-how-do-we-calculate-them">help center article</see>
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

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