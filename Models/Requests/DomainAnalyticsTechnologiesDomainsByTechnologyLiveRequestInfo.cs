using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsTechnologiesDomainsByTechnologyLiveRequestInfo 
    {

        /// <summary>
        /// target technology paths
        /// <br/>required field if you don’t specify groups, technologies, keywords or categories
        /// <br/>at least one field (technology_paths, groups, technologies, keywords or categories) must be set;
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
        /// <br/>required field if you don’t specify technologies, technology_paths, keywords or categories
        /// <br/>you can find the full list of technology group ids on this page
        /// <br/>note: you can specify up to 10 technology groups in this array
        /// <br/>example:
        /// <br/>['sales', 'marketing']
        /// </summary>
        [JsonProperty("groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Groups { get; set; }

        /// <summary>
        /// ids of the target technology categories
        /// <br/>required field if you don’t specify groups, technology_paths, keywords or technologies
        /// <br/>you can find the full list of technology category ids on this page
        /// <br/>note: you can specify up to 10 technology categories in this array
        /// <br/>example:
        /// <br/>['payment_processors','crm']
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// target technologies
        /// <br/>required field if you don’t specify groups, technology_paths, keywords or categories
        /// <br/>you can find the full list of technologies you can specify here on this page
        /// <br/>note: you can specify up to 10 technologies in this array
        /// <br/>example:
        /// <br/>['Google Pay','Salesforce']
        /// </summary>
        [JsonProperty("technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Technologies { get; set; }

        /// <summary>
        /// target keywords in the domain’s title, description or meta keywords
        /// <br/>required field if you don’t specify groups, technology_paths, technologies or categories
        /// <br/>optional field
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
        /// <br/>&lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, like, not_like
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['country_iso_code','=','US']
        /// <br/>[['country_iso_code','=','US'],
        /// <br/>'and',
        /// <br/>['domain_rank','&gt;',100]]
        /// <br/>[['domain_rank','&gt;',100],
        /// <br/>'and',
        /// <br/>[['country_iso_code','=','US'],'or',['country_iso_code','=','CA']]]
        /// <br/>for more information about filters, please refer to Domain Analytics Technologies API – Filters
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>available fields:
        /// <br/>domain_rank, domain, last_visited, country_iso_code, language_code, content_language_code
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in the ascending order
        /// <br/>desc – results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/>['last_visited,desc']
        /// <br/>default rule:
        /// <br/>['domain_rank,desc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['last_visited,desc','domain_rank,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// the maximum number of returned domains
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
        /// <br/>if you specify the 10 value, the first ten domains in the results array will be omitted and the data will be provided for the successive domains;
        /// <br/>Note: the maximum value is 9999, the sum of limit and offset must not exceed 10000;
        /// <br/>use the offset_token if you would like to offset more results
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;
        /// <br/>by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;
        /// <br/>offset_token values are unique for each subsequent task
        /// <br/>Note: if the offset_token is specified in the request, all other parameters should be identical to the previous request
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}