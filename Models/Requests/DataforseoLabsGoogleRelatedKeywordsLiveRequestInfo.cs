using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo 
    {

        /// <summary>
        /// keywordrequired fieldUTF-8 encodingthe keywords will be converted to lowercase formatlearn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

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
        /// full name of the languagerequired field if you don't specify language_codeNote: it is required to specify either language_name or language_codeyou can receive the list of available locations with their language_name by making a separate request to the https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languagesexample:English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language coderequired field if you don't specify language_nameNote: it is required to specify either language_name or language_codeyou can receive the list of available locations with their language_code by making a separate request to the https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languagesexample:en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// keyword search depthoptional fielddefault value: 1number of the returned results depends on the value you set in this fieldyou can specify a level from 0 to 4estimated number of keywords for each level (maximum):0 - the keyword set in the keyword field1 – 8 keywords2 – 72 keywords3 – 584 keywords4 – 4680 keywords
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// include data for the seed keywordoptional fieldif set to true, data for the seed keyword specified in the keyword field will be provided in the seed_keyword_data array of the responsedefault value: false
        /// </summary>
        [JsonProperty("include_seed_keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSeedKeyword { get; set; }

        /// <summary>
        /// include data from SERP for each keywordoptional fieldif set to true, we will return a serp_info array containing SERP data (number of search results, relevant URL, and SERP features) for every keyword in the responsedefault value: false
        /// </summary>
        [JsonProperty("include_serp_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSerpInfo { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the resultoptional fieldif the parameter is set to true, you will receive clickstream_keyword_info, keyword_info_normalized_with_clickstream, and keyword_info_normalized_with_bing fields in the responsedefault value: falsewith this parameter enabled, you will be charged double the price for the requestlearn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [JsonProperty("include_clickstream_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

        /// <summary>
        /// ignore highly similar keywordsoptional fieldif set to true only core keywords will be returned, all highly similar keywords will be excluded;  default value: false
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// return data for core keywordoptional fieldif true, serp_info and related_keywords will be returned for the main keyword in the group that the specified keyword belongs to;if false, serp_info and related_keywords will be returned for the specified keyword (if available);refer to this help center article for more details;default value: false
        /// </summary>
        [JsonProperty("replace_with_core_keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReplaceWithCoreKeyword { get; set; }

        /// <summary>
        /// array of results filtering parametersoptional fieldyou can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe following operators are supported:regex, not_regex, , &gt;=, =, &lt;&gt;, in, not_in, match, not_match, ilike, not_ilike, like,not_likeyou can use the % operator with like and not_like, as well as ilike and not_ilike to match any string of zero or more charactersexample:['keyword_data.keyword_info.search_volume','&gt;',0][['keyword_info.search_volume','in',[0,1000]],'and',['keyword_data.keyword_info.competition_level','=','LOW']][['keyword_data.keyword_info.search_volume','&gt;',100],'and',[['keyword_data.keyword_info.cpc','&lt;',0.5],'or',['keyword_info.high_top_of_page_bid','&lt;=',0.5]]]for more information about filters, please refer to Dataforseo Labs - Filters or this help center guide
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rulesoptional fieldyou can use the same values as in the filters array to sort the resultspossible sorting types:asc - results will be sorted in the ascending orderdesc - results will be sorted in the descending orderyou should use a comma to set up a sorting typeexample:['keyword_data.keyword_info.competition,desc']default rule:['keyword_data.keyword_info.search_volume,desc']note that you can set no more than three sorting rules in a single requestyou should use a comma to separate several sorting rulesexample:['keyword_data.keyword_info.search_volume,desc','keyword_data.keyword_info.cpc,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// the maximum number of returned keywordsoptional fielddefault value: 100maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned keywordsoptional fielddefault value: 0if you specify the 10 value, the first ten keywords in the results array will be omitted and the data will be provided for the successive keywords
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

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