using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPagePagesRequestInfo 
    {

        /// <summary>
        /// ID of the task
        /// <br/>required field
        /// <br/>you can get this ID in the response of the Task POST endpoint
        /// <br/>example:
        /// <br/>“07131248-1535-0216-1000-17384017ad04”
        /// </summary>
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// the maximum number of returned pages
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned pages
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten pages in the results array will be omitted and the data will be provided for the successive pages
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, like, not_like
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>['meta.external_links_count','&lt;=',50]['url','like','https://dataforseo.com/apis/dataforseo-labs-api'][['checks.high_waiting_time','=',false],
        /// <br/>'and',['resource_type','=','html']][['page_timing.duration_time','&lt;',100],'and',[['checks.large_page_size','=',false],'or',['checks.high_waiting_time','=',false]]]The full list of possible filters is available by this link.
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
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/>['meta.external_links_count,desc']
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>['page_timing.dom_complete,asc','size,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over 20,000 results in a single request;
        /// <br/>by specifying the unique search_after_token value from the response array, you will get the subsequent results of the initial task;
        /// <br/>search_after_token values are unique for each subsequent task ;
        /// <br/>Note: if the search_after_token is specified in the request, all other parameters should be identical to the previous request
        /// </summary>
        [JsonProperty("search_after_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchAfterToken { get; set; }

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