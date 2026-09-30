using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGooglePageIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// target URLs of pagesrequired fieldyou can set up to 20 pages in this objectthe pages should be specified with absolute URLs (including http:// or https://)example:'pages': {'1':'https://www.apple.com/mac/*','2':'https://dataforseo.com/*','3':'https://support.microsoft.com/'}if you specify a single page here, we will return results only for this page;you can also use a wildcard ('') character to specify the search patternexample:'example.com'search for the exact URL'example.com/eng/'search for the example.com page and all its related URLs which start with '/eng/', such as 'example.com/eng/index.html' and 'example.com/eng/help/', etc.note: a wilcard should be placed after the slash ('/') character in the end of the URL, it is not possible to place it after the domain in the following way:https://dataforseo.comuse https://dataforseo.com/ insteadNote: this endpoint will not provide results if the number of intersecting keywords exceeds 10 million
        /// </summary>
        [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Pages { get; set; }

        /// <summary>
        /// URLs of pages you want to excludeoptional fieldyou can set up to 10 pages in this arrayif you use this array, results will contain the keywords for which URLs from the pages object rank, but URLs from exclude_pages array do not;note that if you specify this field, the results will be based on the keywords any URL from pages ranks for regardless of intersections between them. However, you can set intersection_mode to intersect and results will contain the keywords all URLs from pages rank for in the same SERP and URLs from exclude_pages do not. use a wildcard ('*') character to specify the search patternexample:'exclude_pages':['https://www.apple.com/iphone/*','https://dataforseo.com/apis/*','https://www.microsoft.com/en-us/industry/services/']
        /// </summary>
        [JsonProperty("exclude_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExcludePages { get; set; }

        /// <summary>
        /// full name of the locationrequired field if you don't specify location_codeNote: it is required to specify either location_name or location_codeyou can receive the list of available locations with their location_name by making a separate request to the https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languagesexample:United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location coderequired field if you don't specify location_nameNote: it is required to specify either location_name or location_codeyou can receive the list of available locations with their location_code by making a separate request to the https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languagesexample:2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the languagerequired field if you don't specify language_codeNote: it is required to specify either language_name or language_codeyou can receive the list of available languages with their language_name by making a separate request to the https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languagesexample:English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language coderequired field if you don't specify language_nameNote: it is required to specify either language_name or language_codeyou can receive the list of available languages with their language_code by making a separate request to the https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languagesexample:en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search results typeindicates type of search results included in the responseoptional fieldpossible values: ['organic', 'paid', 'featured_snippet', 'local_pack']default value: ['organic', 'paid']
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// the maximum number of returned keywordsoptional fielddefault value: 100maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the items array of returned keywordsoptional fielddefault value: 0if you specify 10 here, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// indicates if the subdomains will be included in the searchoptional fieldif set to false, the subdomains will be ignoreddefault value: true
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates whether to intersect keywordsoptional fielduse this field to intersect or merge results for the specified URLspossible values: union, intersectunion - results are based on all keywords any URL from pages rank for;intersect - results are based on the keywords all URLs from pages rank for in the same SERP:by default, results are based on the intersect mode if you specify only pages array. If you specify exclude_pages as well, results are based on the union mode
        /// </summary>
        [JsonProperty("intersection_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IntersectionMode { get; set; }

        /// <summary>
        /// include data from SERP for each keywordoptional fieldif set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the responsedefault value: false
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the resultoptional fieldif the parameter is set to true, you will receive clickstream_keyword_info, clickstream_etv, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the responsedefault value: falsewith this parameter enabled, you will be charged double the price for the requestlearn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// ignore highly similar keywordsoptional fieldif set to true only core keywords will be returned, all highly similar keywords will be excluded;  default value: false
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// array of results filtering parametersoptional fieldyou can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe following operators are supported:regex, not_regex, , &gt;=, =, &lt;&gt;, in, not_in, ilike, not_ilike, like, not_like, match, not_matchyou can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more charactersnote that if you want to filter by any field in the intersection_result array you need to specify the number of corresponding pagefor instance, if you want to filter results by the ranking of the first specified URL, you should set the following filter:[intersection_result.1.rank_absolute,'=',1]if you want to filter results and receive only organic listings for the third specified URL, you should set the following filter:[intersection_result.3.type,'=','organic'] , etc.example:['keyword_data.keyword_info.search_volume','in',[100,1000]][['intersection_result.1.etv','&gt;',0],'and',['intersection_result.1.description','like','%goat%']][['keyword_data.keyword_info.search_volume','&gt;',100],'and',[['intersection_result.2.description','like','%goat%'],'or',['intersection_result.2.type','=','organic']]]for more information about filters, please refer to Dataforseo Labs - Filters or this help center guide
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rulesoptional fieldyou can use the same values as in the filters array to sort the resultspossible sorting types:asc - results will be sorted in the ascending orderdesc - results will be sorted in the descending orderyou should use a comma to set up a sorting parameterexample:['keyword_data.keyword_info.competition,desc']default rule:['keyword_data.keyword_info.search_volume,desc']note that you can set no more than three sorting rules in a single requestyou should use a comma to separate several sorting rulesexample:['intersection_result.1.rank_group,asc','intersection_result.2.rank_absolute,asc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

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