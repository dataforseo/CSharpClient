using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleRankedKeywordsLiveRequestInfo 
    {

        /// <summary>
        /// domain name or page url
        /// <br/>required field
        /// <br/>the domain name of the target website or URL of the target webpage;
        /// <br/>the domain name must be specified without https:// or www.;
        /// <br/>the webpage URL must be specified with https:// or www.
        /// <br/>Note: if you specify the webpage URL without https:// or www., the result will be returned for the entire domain rather than the specific page
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

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
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to true only core keywords will be returned, all highly similar keywords will be excluded;
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// display results by item type
        /// <br/>optional field
        /// <br/>indicates the type of search results included in the response
        /// <br/>Note: if the item_types array contains item types that are different from organic, the results will be ordered by the first item type in the array; you will not be able to sort and filter results by the types of search results not included in the response;
        /// <br/>possible values:
        /// <br/>['organic', 'paid', 'featured_snippet', 'local_pack']
        /// <br/>default value:
        /// <br/>['organic', 'paid']
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>optional field
        /// <br/>if the parameter is set to true, you will receive clickstream_keyword_info, clickstream_etv, clickstream_gender_distribution, clickstream_age_distribution, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the response
        /// <br/>default value: false
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>learn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

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
        /// return rankings distribution by rank_absolute
        /// <br/>optional field
        /// <br/>default value: false
        /// <br/>if set to true, we will return the field metrics_absolute containing rankings distribution by the rank_absolute parameter that indicates the result’s position among all SERP elements
        /// </summary>
        [JsonProperty("load_rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadRankAbsolute { get; set; }

        /// <summary>
        /// data collection mode
        /// <br/>optional field
        /// <br/>you can use this field to filter the results;
        /// <br/>possible types of filtering:
        /// <br/>live — return keywords for which the specified target currently has ranking results in SERP;
        /// <br/>lost — return keywords for which the specified target had previously had ranking results in SERP, but didn’t have them during the last check;
        /// <br/>all — return both types of keywords.
        /// <br/>default value: live
        /// </summary>
        [JsonProperty("historical_serp_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HistoricalSerpMode { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, match, not_match, ilike, not_ilike, like, not_like
        /// <br/>you can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['ranked_serp_element.serp_item.rank_group','&lt;=',10]
        /// <br/>[['ranked_serp_element.serp_item.rank_group','&lt;=',10],
        /// <br/>'and',
        /// <br/>['ranked_serp_element.serp_item.type','&lt;&gt;','paid']]
        /// <br/>[['keyword_data.keyword_info.search_volume','&lt;&gt;',0],
        /// <br/>'and',
        /// <br/>[['ranked_serp_element.serp_item.type','&lt;&gt;','paid'],'or',['ranked_serp_element.serp_item.is_malicious','=',false]]]
        /// <br/>if you want to get the keywords a particular webpage ranks for, you can use a target field or filter by the ranked_serp_element.serp_item.relative_url parameter
        /// <br/>example:
        /// <br/>['ranked_serp_element.serp_item.relative_url', '=', '/apis/rank-tracker-api']
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
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/>['keyword_data.keyword_info.competition,desc']
        /// <br/>default rule:
        /// <br/>['ranked_serp_element.serp_item.rank_group,asc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['keyword_data.keyword_info.search_volume,desc','keyword_data.keyword_info.cpc,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

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