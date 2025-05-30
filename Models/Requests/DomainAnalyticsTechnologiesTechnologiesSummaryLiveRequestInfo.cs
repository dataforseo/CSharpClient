using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsTechnologiesTechnologiesSummaryLiveRequestInfo 
    {

        /// <summary>
        /// target technology paths
        /// <br/>required field if you don’t specify groups, technologies and categories
        /// <br/>each technology path should be specified as a separate object containing “path” and “name”, where “path” is specified as “$group_id.$category_id” and “name” – as the name of the target technology;
        /// <br/>each object with a technology path should be separated with a comma
        /// <br/>you can find the full list of technology group ids, category ids and technology names on this page
        /// <br/>note: you can specify up to 10 technology paths in this array
        /// <br/>example:
        /// <br/>[{'path': 'content.cms','name': 'wordpress'}, {'path': 'marketing.crm','name': 'salesforce'}]
        /// </summary>
        [JsonProperty("technology_paths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> TechnologyPaths { get; set; }

        /// <summary>
        /// ids of the target technology groups
        /// <br/>required field if you don’t specify technologies, technology_paths, categories, or keywords
        /// <br/>you can find the full list of technology group ids on this page
        /// <br/>note: you can specify up to 10 technology groups in this array
        /// <br/>example:
        /// <br/>['sales', 'marketing']
        /// </summary>
        [JsonProperty("groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Groups { get; set; }

        /// <summary>
        /// ids of the target technology categories
        /// <br/>required field if you don’t specify groups, technology_paths, technologies, or keywords
        /// <br/>you can find the full list of technology category ids on this page
        /// <br/>note: you can specify up to 10 technology categories in this array
        /// <br/>example:
        /// <br/>['payment_processors','crm']
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// target technologies
        /// <br/>required field if you don’t specify groups, technology_paths, categories, or keywords
        /// <br/>you can find the full list of technologies you can specify here on this page
        /// <br/>note: you can specify up to 10 technologies in this array
        /// <br/>example:
        /// <br/>['Google Pay','Salesforce']
        /// </summary>
        [JsonProperty("technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Technologies { get; set; }

        /// <summary>
        /// target keywords in the domain’s title, description or meta keywords
        /// <br/>required field if you don’t specify groups, technology_paths, categories, or technologies
        /// <br/>you can specify the maximum of 10 keywords;
        /// <br/>UTF-8 encoding;
        /// <br/>example:
        /// <br/>['seo','software']
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

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
        /// <br/>example:
        /// <br/>[['country_iso_code','=','US'],
        /// <br/>'and',
        /// <br/>['domain_rank','&gt;',800]]
        /// <br/>for more information about filters, please refer to Domain Analytics Technologies API – Filters
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/>countries, languages, content_languages, keywords
        /// <br/>default value: 10
        /// <br/>minimum value: 1
        /// <br/>maximum value: 10000
        /// </summary>
        [JsonProperty("internal_list_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

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