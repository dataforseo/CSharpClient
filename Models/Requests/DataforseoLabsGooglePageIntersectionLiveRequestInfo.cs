using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGooglePageIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// target URLs of pages
        /// <br/>required field
        /// <br/>you can set up to 20 pages in this object
        /// <br/>the pages should be specified with absolute URLs (including http:// or https://)
        /// <br/>example:
        /// <br/>'pages': {
        /// <br/>'1':'https://www.apple.com/mac/*',
        /// <br/>'2':'https://dataforseo.com/*',
        /// <br/>'3':'https://support.microsoft.com/'
        /// <br/>}if you specify a single page here, we will return results only for this page;
        /// <br/>you can also use a wildcard (‘*’) character to specify the search pattern
        /// <br/>example:
        /// <br/>'example.com'
        /// <br/>search for the exact URL
        /// <br/>'example.com/eng/*'
        /// <br/>search for the example.com page and all its related URLs which start with ‘/eng/’, such as “example.com/eng/index.html” and “example.com/eng/help/”, etc.
        /// <br/>note: a wilcard should be placed after the slash (‘/’) character in the end of the URL, it is not possible to place it after the domain in the following way:
        /// <br/>https://dataforseo.com*
        /// <br/>use https://dataforseo.com/* instead
        /// <br/>Note: this endpoint will not provide results if the number of intersecting keywords exceeds 10 million
        /// </summary>
        [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Pages { get; set; }

        /// <summary>
        /// URLs of pages you want to exclude
        /// <br/>optional field
        /// <br/>you can set up to 10 pages in this array
        /// <br/>if you use this array, results will contain the keywords for which URLs from the pages object rank, but URLs from exclude_pages array do not;
        /// <br/>note that if you specify this field, the results will be based on the keywords any URL from pages ranks for regardless of intersections between them. However, you can set intersection_mode to intersect and results will contain the keywords all URLs from pages rank for in the same SERP and URLs from exclude_pages do not.
        /// <br/>use a wildcard (‘*’) character to specify the search pattern
        /// <br/>example:
        /// <br/>'exclude_pages': [
        /// <br/>'https://www.apple.com/iphone/*',
        /// <br/>'https://dataforseo.com/apis/*',
        /// <br/>'https://www.microsoft.com/en-us/industry/services/'
        /// <br/>]
        /// </summary>
        [JsonProperty("exclude_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExcludePages { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don’t specify location_code
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don’t specify location_name
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don’t specify language_code
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available languages with their language_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search results type
        /// <br/>indicates type of search results included in the response
        /// <br/>optional field
        /// <br/>possible values:
        /// <br/>['organic', 'paid', 'featured_snippet', 'local_pack']
        /// <br/>default value:
        /// <br/>['organic', 'paid']
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// the maximum number of returned keywords
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the items array of returned keywords
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify 10 here, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// indicates if the subdomains will be included in the search
        /// <br/>optional field
        /// <br/>if set to false, the subdomains will be ignored
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates whether to intersect keywords
        /// <br/>optional field
        /// <br/>use this field to intersect or merge results for the specified URLs
        /// <br/>possible values: union, intersect
        /// <br/>union – results are based on all keywords any URL from pages rank for;
        /// <br/>intersect – results are based on the keywords all URLs from pages rank for in the same SERP:
        /// <br/>by default, results are based on the intersect mode if you specify only pages array. If you specify exclude_pages as well, results are based on the union mode
        /// </summary>
        [JsonProperty("intersection_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionMode { get; set; }

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
        /// <br/>if the parameter is set to true, you will receive clickstream_keyword_info, clickstream_etv, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the response
        /// <br/>default value: false
        /// <br/>with this parameter enabled, you will be charged double the price for the request
        /// <br/>learn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

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
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, ilike, not_ilike, like, not_like, match, not_match
        /// <br/>you can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more characters
        /// <br/>note that if you want to filter by any field in the intersection_result array you need to specify the number of corresponding page
        /// <br/>for instance, if you want to filter results by the ranking of the first specified URL, you should set the following filter:
        /// <br/>[intersection_result.1.rank_absolute,'=',1]
        /// <br/>if you want to filter results and receive only organic listings for the third specified URL, you should set the following filter:
        /// <br/>[intersection_result.3.type,'=','organic'] , etc.example:
        /// <br/>['keyword_data.keyword_info.search_volume','in',[100,1000]]
        /// <br/>[['intersection_result.1.etv','&gt;',0],'and',['intersection_result.1.description','like','%goat%']][['keyword_data.keyword_info.search_volume','&gt;',100],
        /// <br/>'and',
        /// <br/>[['intersection_result.2.description','like','%goat%'],
        /// <br/>'or',
        /// <br/>['intersection_result.2.type','=','organic']]]
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
        /// <br/>you should use a comma to set up a sorting parameter
        /// <br/>example:
        /// <br/>['keyword_data.keyword_info.competition,desc']
        /// <br/>default rule:
        /// <br/>['keyword_data.keyword_info.search_volume,desc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['intersection_result.1.rank_group,asc','intersection_result.2.rank_absolute,asc']
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