using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>the keywords will be converted to lowercase format;
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>ignore this field to get the results for all available locations
        /// <br/>example:
        /// <br/>United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify location_name
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>ignore this field to get the results for all available locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages with their language_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>English
        /// <br/>Note: if omitted, results default to the language with the most keyword records in the specified location;
        /// <br/>refer to the available_languages.keywords field of the Locations and Languages endpoint to determine the default language
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>en
        /// <br/>Note: if omitted, results default to the language with the most keyword records in the specified location;
        /// <br/>refer to the available_languages.keywords field of the Locations and Languages endpoint to determine the default language
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// include data for the seed keyword
        /// <br/>optional field
        /// <br/>if set to true, data for the seed keyword specified in the keyword field will be provided in the seed_keyword_data array of the response
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("include_seed_keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSeedKeyword { get; set; }

        /// <summary>
        /// include data from SERP for each keyword
        /// <br/>optional field
        /// <br/>if set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>optional field
        /// <br/>if the parameter is set to true, you will receive clickstream_keyword_info, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the response
        /// <br/>default value: false
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>learn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// search for the exact phrase
        /// <br/>optional field
        /// <br/>if set to true, the returned keywords will include the exact keyword phrase you specified, with potentially other words before or after that phrase
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("exact_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExactMatch { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to true only core keywords will be returned, all highly similar keywords will be excluded;
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, match, not_match, ilike, not_ilike, like, not_like
        /// <br/>you can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['keyword_info.search_volume','&gt;',0]
        /// <br/>[['keyword_info.search_volume','in',[0,1000]],
        /// <br/>'and',
        /// <br/>['keyword_info.competition_level','=','LOW']][['keyword_info.search_volume','&gt;',100],
        /// <br/>'and',
        /// <br/>[['keyword_info.cpc','&lt;',0.5],
        /// <br/>'or',
        /// <br/>['keyword_info.high_top_of_page_bid','&lt;=',0.5]]]
        /// <br/>for more information about filters, please refer to Dataforseo Labs – Filters or this help center guide
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the filters array to sort the results
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in the ascending order
        /// <br/>desc – results will be sorted in the descending order
        /// <br/>a comma is used as a separator
        /// <br/>example:
        /// <br/>['keyword_info.competition,desc']
        /// <br/>default rule:
        /// <br/>['keyword_info.search_volume,desc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['keyword_info.search_volume,desc','keyword_info.cpc,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// the maximum number of returned keywords
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned keywords
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// offset token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over 10,000 results in a single request;
        /// <br/>by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;
        /// <br/>offset_token values are unique for each subsequent task
        /// <br/>Note: if the offset_token is specified in the request, all other parameters except limit will not be taken into account when processing a task.
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

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