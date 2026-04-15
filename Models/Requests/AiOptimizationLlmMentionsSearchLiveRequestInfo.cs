using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationLlmMentionsSearchLiveRequestInfo 
    {

        /// <summary>
        /// array of objects containing target entities
        /// <br/>required field
        /// <br/>you can specify up to 10 entities (objects) in the target field
        /// <br/>one target entity can contain either one domain or one keyword and related parameters
        /// <br/>examples:
        /// <br/>
        /// <br/>target array with a domain entity
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseAiOptimizationLLmMentionsTargetElement> Target { get; set; }

        /// <summary>
        /// domain entity in the target arrayexample:{'domain': 'en.wikipedia.org', 'search_filter': 'exclude', 'search_scope': ['sources']}
        /// </summary>
        [JsonProperty("domain_entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object DomainEntity { get; set; }

        /// <summary>
        /// target domainrequired field if you don't specify keywordyou can specify up to 63 characters in the domain field;a domain should be specified without https:// and www.
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// target keyword search filteroptional fieldpossible values:include, excludedefault value: include
        /// </summary>
        [JsonProperty("search_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchFilter { get; set; }

        /// <summary>
        /// target keyword search scopeoptional fieldpossible values:any, question, answer, brand_entities, fan_out_queriesdefault value: any
        /// </summary>
        [JsonProperty("search_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SearchScope { get; set; }

        /// <summary>
        /// indicates if the subdomains of the target domain will be included in the searchoptional fieldif set to true, the subdomains will be included in the searchdefault value: false
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// keyword entity in the target arrayexample:{'keyword': 'bmw', 'search_filter': 'include', 'search_scope': ['question'], 'match_type ': 'partial_match'}
        /// </summary>
        [JsonProperty("keyword_entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object KeywordEntity { get; set; }

        /// <summary>
        /// target keywordrequired field if you don't specify domainyou can specify up to 250 characters in the keyword fieldall %## will be decoded (plus character ‘+’ will be decoded to a space character)if you need to use the “%” character for your keyword, please specify it as “%25”;if you need to use the “+” character for your keyword, please specify it as “%2B”learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// target keyword match typedefines how the specified keyword is matchedoptional fieldpossible values:word_match - full-text search for terms that match the specified seed keyword with additional words included before, after, or within the key phrase (e.g., search for 'light' will return results with 'light bulb', 'light switch');partial_match - substring search that finds all instances containing the specified sequence of characters, even if it appears inside a longer word (e.g., search for 'light' will return results with 'lighting', 'highlight');default value: word_match
        /// </summary>
        [JsonProperty("match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// full name of search locationoptional fieldif you use this field, you don't need to specify location_codeif you don't specify this field, the location_code with 2840 value will be used by default;you can receive the list of available locations of the search engine with their location_name by making a separate request to the https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languagesNote: chat_gpt data is available for United States only
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search location codeoptional fieldif you use this field, you don't need to specify location_nameyou can receive the list of available locations of the search engine with their location_code by making a separate request to the https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languagesdefault value: 2840Note: chat_gpt data is available for 2840 only
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of search languageoptional fieldif you use this field, you don't need to specify language_code;if you don't specify this field, the language_code with en value will be used by default;you can receive the list of available languages of the search engine with their language_name by making a separate request to the https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languagesNote: chat_gpt data is available for English only
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search language codeoptional fieldif you use this field, you don't need to specify language_name;you can receive the list of available languages of the search engine with their language_code_by making a separate request to the https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languagesdefault value: enNote: chat_gpt data is available for en onlyn
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// target platformoptional fieldpossible values:chat_gpt, googledefault value: googleNote: the data returned depends on the selected platformNote #2:chat_gpt data is available for the United States and English only
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// array of results filtering parametersoptional fieldyou can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe following operators are supported:=, &lt;&gt;, in, not_in, like, not_like, ilike, not_ilike, match, not_matchyou can use the % operator with like and not_like to match any string of zero or more charactersexample:['ai_search_volume','&gt;','1000']The full list of possible filters is available here.
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rulesoptional fieldyou can use the same values as in the filters array to sort the resultspossible sorting types:asc - results will be sorted in the ascending orderdesc - results will be sorted in the descending orderyou should use a comma to set up a sorting typeexample:['ai_search_volume,desc']note that you can set no more than three sorting rules in a single requestyou should use a comma to separate several sorting rules
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// offset in the results array of the returned mentions dataoptional fielddefault value: 0example: if you specify the 10 value, the first ten mentions objects in the results array will be omitted and the data will be provided for the successive objects;Note: the maximum value is 9,000, use the search_after_token if you would like to offset more results
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// token for subsequent requestsoptional fieldprovided in the identical filed of the response to each request;use this parameter to avoid timeouts while trying to obtain over 20,000 results in a single request;by specifying the unique search_after_token value from the response array, you will get the subsequent results of the initial task;search_after_token values are unique for each subsequent task ;Note: if the search_after_token is specified in the request, all other parameters should be identical to the previous request
        /// </summary>
        [JsonProperty("search_after_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchAfterToken { get; set; }

        /// <summary>
        /// the maximum number of returned objectsoptional fielddefault value: 100maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

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