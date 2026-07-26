using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AiOptimizationLlmMentionsTopMentionedDomainsLiteLiveRequestInfo 
    {

        /// <summary>
        /// array of objects containing target entities
        /// <br/>required field
        /// <br/>you can specify up to 10 entities (objects) in the target field
        /// <br/>one target entity can contain either one domain or one keyword and related parameters
        /// <br/>examples:
        /// <br/>target array with a domain entity
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseAiOptimizationLLmMentionsTargetElement> Target { get; set; }

        /// <summary>
        /// full name of search location
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_code</c>
        /// <br/>if you don't specify this field, the <c>location_code</c> with <c>2840</c> value will be used by default;
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>United States</c> only
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search location code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>location_name</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>default value: <c>2840</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>2840</c> only
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of search language
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>;
        /// <br/>if you don't specify this field, the <c>language_code</c> with <c>en</c> value will be used by default;
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>English</c> only
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search language code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>;
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c>_by making a separate request to the <c>https://api.dataforseo.com/v3/ai_optimization/llm_mentions/locations_and_languages</c>
        /// <br/>default value: <c>en</c>
        /// <br/>Note: <c>chat_gpt</c> data is available for <c>en</c> onlyn
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// target platform
        /// <br/>optional field
        /// <br/>possible values:
        /// <br/><c>chat_gpt</c>, <c>google</c>
        /// <br/>default value: <c>google</c>
        /// <br/>Note: if the <c>platform</c> is not specified, the data is returned for both platforms
        /// <br/>Note #2:<c>chat_gpt</c> data is available for the <c>United States</c> and <c>English</c> only
        /// </summary>
        [JsonProperty("platform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// links source scope
        /// <br/>optional field
        /// <br/>this parameter specifies which links will be used to extract domains and aggregation data
        /// <br/>possible values: <c>sources</c>, <c>search_results</c>
        /// <br/>default value: <c>sources</c>
        /// </summary>
        [JsonProperty("links_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LinksScope { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>, <c>ilike</c>, <c>not_ilike</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['ai_search_volume','&gt;',1000]</c>
        /// <br/>The full list of possible filters is available <see href="/v3/ai_optimization/llm_mentions/filters/">here.</see>
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// array of filter expressions applied before aggregation
        /// <br/>optional field
        /// <br/>you can use this array to filter expressions applied to the raw mentions database before aggregation to limit the rows contributing to the result;
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>, <c>ilike</c>, <c>not_ilike</c>, <c>match</c>, <c>not_match</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['ai_search_volume','&gt;',1000]</c>
        /// <br/>the full list of possible filters is available <see href="/v3/ai_optimization/llm_mentions/filters">here.</see>
        /// <br/>learn more about the initial dataset filters in <see href="https://dataforseo.com/help-center/what-are-the-initial-dataset-filters-and-how-do-they-work">this help center article.</see>
        /// </summary>
        [JsonProperty("initial_dataset_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> InitialDatasetFilters { get; set; }

        /// <summary>
        /// maximum number of results in the items array
        /// <br/>optional field
        /// <br/>you can use this parameter to limit the number of data objects you receive in the <c>items</c> array
        /// <br/>minimum value: <c>1</c>
        /// <br/>maximum value: <c>1000</c>
        /// <br/>default value: <c>100</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/><c>sources_domain</c>, <c>search_results_domain</c>, <c>brand_entities_title</c>, <c>brand_entities_category</c>
        /// <br/>minimum value: <c>1</c>
        /// <br/>maximum value: <c>10</c>
        /// <br/>default value: <c>5</c>
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/><c>['ai_search_volume,desc']</c>
        /// <br/>Note: you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// offset in the results array of the returned mentions data
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>example: if you specify the <c>10</c> value, the first ten mentions objects in the results array will be omitted and the data will be provided for the successive objects;
        /// <br/>Note: the maximum value is <c>1000000</c>
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of domains to include in the response
        /// <br/>optional field
        /// <br/>if specified, only the listed domains will be returned in the <c>items</c> array
        /// <br/>example:
        /// <br/><c>['dataforseo.com','seoinsider.com']</c>
        /// </summary>
        [JsonProperty("include_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> IncludeDomains { get; set; }

        /// <summary>
        /// array of domains to exclude from the response
        /// <br/>optional field
        /// <br/>if specified, the listed domains will be omitted from the <c>items</c> array
        /// <br/>example:
        /// <br/><c>['google.com','bing.com']</c>
        /// </summary>
        [JsonProperty("exclude_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExcludeDomains { get; set; }

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