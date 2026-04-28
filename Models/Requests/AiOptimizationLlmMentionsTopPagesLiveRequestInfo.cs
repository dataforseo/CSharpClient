using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationLlmMentionsTopPagesLiveRequestInfo 
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
        /// links source scopeoptional fieldthis parameter specifies which links will be used to extract pages and aggregation datapossible values: sources, search_resultsdefault value: sources
        /// </summary>
        [JsonProperty("links_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LinksScope { get; set; }

        /// <summary>
        /// array of filter expressions applied before aggregationoptional fieldyou can use this array to filter expressions applied to the raw mentions database before aggregation to limit the rows contributing to the result;you can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe following operators are supported:=, &lt;&gt;, in, not_in, like, not_like, ilike, not_ilike, match, not_matchyou can use the % operator with like and not_like to match any string of zero or more charactersexample:['ai_search_volume','&gt;','1000']the full list of possible filters is available here.learn more about the initial dataset filters in this help center article.
        /// </summary>
        [JsonProperty("initial_dataset_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> InitialDatasetFilters { get; set; }

        /// <summary>
        /// maximum number of results in the items arrayoptional fieldyou can use this parameter to limit the number of data objects you receive in the items arrayminimum value: 1maximum value: 10default value: 5
        /// </summary>
        [JsonProperty("items_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemsListLimit { get; set; }

        /// <summary>
        /// maximum number of elements within internal arraysoptional fieldyou can use this field to limit the number of elements within the following arrays:sources_domainsearch_results_domainminimum value: 1maximum value: 10default value: 5
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

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