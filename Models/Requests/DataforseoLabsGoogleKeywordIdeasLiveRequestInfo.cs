using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleKeywordIdeasLiveRequestInfo 
    {

        /// <summary>
        /// keywords
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>The maximum number of keywords you can specify: 200.
        /// <br/>The keywords will be converted to lowercase format
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
        /// unique location identifier
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
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// <br/>Note: if omitted, results default to the language with the most keyword records in the specified location;
        /// <br/>refer to the <c>available_languages.keywords</c> field of the <see href="https://docs.dataforseo.com/v3/dataforseo_labs/locations_and_languages">Locations and Languages endpoint</see> to determine the default language
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// <br/>Note: if omitted, results default to the language with the most keyword records in the specified location;
        /// <br/>refer to the <c>available_languages.keywords</c> field of the <see href="https://docs.dataforseo.com/v3/dataforseo_labs/locations_and_languages">Locations and Languages endpoint</see> to determine the default language
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search mode
        /// <br/>optional field
        /// <br/>if set to_<c>true</c> the results will be based on the phrase-match search algorithm
        /// <br/>if set to <c>false</c> the results will be based on the broad-match search algorithm
        /// <br/>default value: <c>false</c>n
        /// </summary>
        [JsonProperty("closely_variants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloselyVariants { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to_<c>true</c> only core keywords will be returned, all highly similar keywords will be excluded;  
        /// <br/>default value: <c>false</c>n
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

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
        /// <br/>if the parameter is set to_<c>true</c>, you will receive <c>clickstream_keyword_info</c>, <c>keyword_info_normalized_with_clickstream</c>, and <c>keyword_info_normalized_with_bing</c> fields in the response
        /// <br/>default value: <c>false</c>
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>learn more about how clickstream-based metrics are calculated in this <see href="https://dataforseo.com/help-center/what-are-clickstream-based-metrics-and-how-do-we-calculate-them">help center article</see>n
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// the maximum number of keywords in the results array
        /// <br/>optional field
        /// <br/>default value: <c>700</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned keywords
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// <br/>Note: we recommend using this parameter only when retrieving up to 10,000 results
        /// <br/>for retrieving over 10,000 results, use the <c>offset_token</c> instead.
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// offset token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over 10,000 results in a single request;
        /// <br/>by specifying the unique <c>offset_token</c> value from the response array, you will get the subsequent results of the initial task;
        /// <br/><c>offset_token</c> values are unique for each subsequent task 
        /// <br/>Note: if the <c>offset_token</c> is specified in the request, all other parameters except <c>limit</c> will not be taken into account when processing a task.
        /// <br/>learn more about this parameter on our <see href="https://dataforseo.com/help-center/what-is-the-difference-between-the-offset-and-offset_token-parameters#offset_token">Help Center</see>
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>match</c>, <c>not_match</c>, <c>ilike</c>, <c>not_ilike</c>, <c>like</c>, <c>not_like</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c>,as well as <c>ilike</c>, <c>not_ilike</c> to match any string of zero or more characters
        /// <br/>note that you can not filter the results by <c>relevance</c>
        /// <br/>example:
        /// <br/><c>['keyword_info.search_volume','&gt;',0]</c>
        /// <br/><c>[['keyword_info.search_volume','in',[0,1000]],'and',['keyword_info.competition_level','=','LOW']]</c>
        /// <br/><c>[['keyword_info.search_volume','&gt;',100],'and',[['keyword_info.cpc',''or',['keyword_info.high_top_of_page_bid','&lt;=',0.5]]]</c>
        /// <br/>for more information about filters, please refer to <see href="/v3/dataforseo_labs/filters">Dataforseo Labs - Filters</see> or this <see href="https://dataforseo.com/help-center/how-to-use-filters-in-dataforseo-labs-api">help center guide</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting parameter
        /// <br/>default rule:
        /// <br/><c>['relevance,desc']</c>
        /// <br/>relevance is used as the default sorting rule to provide you with the closest keyword ideas. We recommend using this sorting rule to get highly-relevant search terms. Note that <c>relevance</c> is only our internal system identifier, so it can not be used as a filter, and you will not find this field in the <c>result</c> array. The relevance score is based on a similar principle as used in <see href="/v3/keywords_data/google/keywords_for_keywords/live/?php">the Keywords For Keywords</see> endpoint.
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['relevance,desc','keyword_info.search_volume,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

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