using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsTechnologiesAggregationTechnologiesLiveRequestInfo 
    {

        /// <summary>
        /// id of the target technology group
        /// <br/>required field if you don’t specify technology, category  or keyword
        /// <br/>at least one field (group, category, keyword, technology) must be set
        /// <br/>you can find the full list of technology group ids on this page
        /// <br/>example:
        /// <br/>'marketing'
        /// </summary>
        [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// id of the target technology category
        /// <br/>required field if you don’t specify group, keyword or technology
        /// <br/>at least one field (group, category, keyword, technology) must be set
        /// <br/>you can find the full list of technology category ids on this page
        /// <br/>example:
        /// <br/>'crm'
        /// </summary>
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// target technology
        /// <br/>required field if you don’t specify group, keyword or category
        /// <br/>at least one field (group, category, keyword, technology) must be set
        /// <br/>you can find the full list of technologies on this page
        /// <br/>example:
        /// <br/>'Salesforce'
        /// </summary>
        [JsonProperty("technology", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Technology { get; set; }

        /// <summary>
        /// target keyword in the domain’s meta keywords
        /// <br/>required field if you don’t specify group, category or technology
        /// <br/>at least one field (group, category, keyword, technology) must be set
        /// <br/>UTF-8 encoding
        /// <br/>example:
        /// <br/>'seo'
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search mode
        /// <br/>optional field
        /// <br/>possible search mode types:
        /// <br/>as_is – search for results exactly matching the specified group ids, category ids, or technology names
        /// <br/>entry – search for results matching a part of the specified group ids, category ids, or technology names
        /// <br/>default value: as_is
        /// </summary>
        [JsonProperty("mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>&lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, like,not_like
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>you can use the following parameters to filter the results: domain_rank, last_visited, country_iso_code, language_code, content_language_code
        /// <br/>Note: all filtering parameters are taken from the domain_technology_item of the domain_technologies endpoint;
        /// <br/>example:
        /// <br/>[['country_iso_code','=','US'],
        /// <br/>'and',
        /// <br/>['domain_rank','&gt;',800]]for more information about filters, please refer to Domain Analytics Technologies API – Filters
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the following values to sort the results: groups_count, categories_count, technologies_count
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in the ascending order
        /// <br/>desc – results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/>['groups_count,desc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['groups_count,desc','technologies_count,desc']
        /// <br/>default value:
        /// <br/>['groups_count,desc','categories_count,desc','technologies_count,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// maximum number of returned technology groups
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of items with identical 'group' in the results
        /// <br/>default value: 5
        /// <br/>minimum value: 1
        /// <br/>maximum value: 10000
        /// </summary>
        [JsonProperty("internal_groups_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalGroupsListLimit { get; set; }

        /// <summary>
        /// maximum number of returned technology categories within the same group
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of items with identical 'category' in the results
        /// <br/>default value: 5
        /// <br/>minimum value: 1
        /// <br/>maximum value: 10000
        /// </summary>
        [JsonProperty("internal_categories_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalCategoriesListLimit { get; set; }

        /// <summary>
        /// maximum number of returned technologies within the same category
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of items with identical 'technology' in the results
        /// <br/>default value: 10
        /// <br/>minimum value: 1
        /// <br/>maximum value: 10000
        /// </summary>
        [JsonProperty("internal_technologies_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalTechnologiesListLimit { get; set; }

        /// <summary>
        /// maximum number of items with identical 'category', 'group', and 'technology'
        /// <br/>optional field
        /// <br/>if you use this field, the values specified in internal_groups_list_limit, internal_categories_list_limit and internal_technologies_list_limit will be ignored;
        /// <br/>you can use this field to limit the number of items with identical 'category', 'group', or 'technology'
        /// <br/>default value: 10
        /// <br/>minimum value: 1
        /// <br/>maximum value: 10000
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// the maximum number of returned technologies
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 10000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned domains
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>maximum value: 9999
        /// <br/>if you specify the 10 value, the first ten technologies in the results array will be omitted and the data will be provided for the successive technologies
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

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