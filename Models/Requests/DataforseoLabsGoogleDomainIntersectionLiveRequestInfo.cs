using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleDomainIntersectionLiveRequestInfo 
    {

        /// <summary>
        /// domain            required field            the domain name of the first target website            the domain should be specified without https:// and www.
        /// </summary>
        [JsonProperty("target1", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target1 { get; set; }

        /// <summary>
        /// domain            required field            the domain name of the second target website            the domain should be specified without https:// and www.
        /// </summary>
        [JsonProperty("target2", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target2 { get; set; }

        /// <summary>
        /// full name of the location            required field if you don't specify location_code            Note: it is required to specify either location_name or location_code            you can receive the list of available locations with their location_name by making a separate request to the            https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages            example:            United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code            required field if you don't specify location_name            Note: it is required to specify either location_name or location_code            you can receive the list of available locations with their location_code by making a separate request to the            https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages            example:            2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language            required field if you don't specify language_code            Note: it is required to specify either language_name or language_code            you can receive the list of available languages with their language_name by making a separate request to the            https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages            example:            English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code            required field if you don't specify language_name            Note: it is required to specify either language_name or language_code            you can receive the list of available languages with their language_code by making a separate request to the            https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages            example:            en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// domain intersections in SERP            optional field            if you set intersections to true, you will get the keywords for which both target domains specified as target1 and target2 have results within the same SERP; the corresponding SERP elements for both domains will be provided in the results array            Note: this endpoint will not provide results if the number of intersecting keywords exceeds 10 million            if you specify intersections: false, you will get the keywords for which the domain specified as target1 has results in SERP, and the domain specified as target2 doesn't;            thus, the corresponding SERP elements and other data will be provided for the domain specified as target1only            default value: true
        /// </summary>
        [JsonProperty("intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intersections { get; set; }

        /// <summary>
        /// search results type            indicates type of search results included in the response            optional field            possible values:            ['organic', 'paid', 'featured_snippet', 'local_pack']            default value:            ['organic', 'paid']
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// include data from SERP for each keyword            optional field            if set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the response            default value: false
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result            optional field            if the parameter is set to true, you will receive clickstream_keyword_info, clickstream_etv, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the response            default value: false            with this parameter enabled, you will be charged double the price for the request            learn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// the maximum number of returned keywords            optional field            default value: 100            maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the items array of returned keywords            optional field            default value: 0            if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters            optional field            you can add several filters at once (8 filters maximum)            you should set a logical operator and, or between the conditions            the following operators are supported:            regex, not_regex, , &gt;=, =, &lt;&gt;, in, not_in, match, not_match, ilike, not_ilike, like, not_like            you can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more characters            example:            ['keyword_data.keyword_info.search_volume','in',[100,1000]]            [['first_domain_serp_element.etv','&gt;',0],'and',['first_domain_serp_element.description','like','%goat%']]            [['keyword_data.keyword_info.search_volume','&gt;',100],                'and',                [['first_domain_serp_element.description','like','%goat%'],                'or',                ['second_domain_serp_element.type','=','organic']]]            for more information about filters, please refer to Dataforseo Labs - Filters or this help center guide
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules            optional field            you can use the same values as in the filters array to sort the results            possible sorting types:            asc - results will be sorted in the ascending order            desc - results will be sorted in the descending order            you should use a comma to set up a sorting parameter            example:            ['keyword_data.keyword_info.competition,desc']            default rule:            ['keyword_data.keyword_info.search_volume,desc']            note that you can set no more than three sorting rules in a single request            you should use a comma to separate several sorting rules            example:            ['keyword_data.keyword_info.search_volume,desc','keyword_data.keyword_info.cpc,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// user-defined task identifier            optional field            the character limit is 255            you can use this parameter to identify the task and match it with the result            you will find the specified tag value in the data object of the response
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