using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsBingDomainIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// domain
        /// <br/>required field
        /// <br/>the domain name of the first target website
        /// <br/>the domain should be specified without https:// and www.
        /// </summary>
        [JsonProperty("target1", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target1 { get; set; }

        /// <summary>
        /// domain
        /// <br/>required field
        /// <br/>the domain name of the second target website
        /// <br/>the domain should be specified without https:// and www.
        /// </summary>
        [JsonProperty("target2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target2 { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don’t specify location_code
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>Note: this endpoint currently supports the US location only;
        /// <br/>example:
        /// <br/>United States
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don’t specify location_name
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages;
        /// <br/>Note: this endpoint currently supports the US location only;
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
        /// domain intersections in SERP
        /// <br/>optional field
        /// <br/>if you set intersections to true, you will get the keywords for which both target domains specified as target1 and target2 have results within the same SERP; the corresponding SERP elements for both domains will be provided in the results array
        /// <br/>Note: this endpoint will not provide results if the number of intersecting keywords exceeds 10 million
        /// <br/>if you specify intersections: false, you will get the keywords for which the domain specified as target1 has results in SERP, and the domain specified as target2 doesn’t;
        /// <br/>thus, the corresponding SERP elements and other data will be provided for the domain specified as target1only
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intersections { get; set; }

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
        /// include data from SERP for each keyword
        /// <br/>optional field
        /// <br/>if set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

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
        /// <br/>if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, ilike, not_ilike, like, not_like, match, not_match
        /// <br/>you can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['keyword_data.keyword_info.search_volume','in',[100,1000]]
        /// <br/>[['first_domain_serp_element.etv','&gt;',0],'and',['first_domain_serp_element.description','like','%goat%']]
        /// <br/>[['keyword_data.keyword_info.search_volume','&gt;',100],
        /// <br/>'and',
        /// <br/>[['first_domain_serp_element.description','like','%goat%'],
        /// <br/>'or',
        /// <br/>['second_domain_serp_element.type','=','organic']]]
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