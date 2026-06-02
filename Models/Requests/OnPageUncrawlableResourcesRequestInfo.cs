using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageUncrawlableResourcesRequestInfo 
    {

        /// <summary>
        /// ID of the taskrequired fieldyou can get this ID in the response of the Task POST endpointexample:'07131248-1535-0216-1000-17384017ad04'
        /// </summary>
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// the maximum number of returned uncrawlable resourcesoptional fielddefault value: 100maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned uncrawlable resourcesoptional fielddefault value: 0 maximum value: 2000000if you specify the 10 value, the first ten invalid resources in the results array will be omitted and the data will be provided for the successive invalid resources
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// results sorting rulesoptional fieldyou can use the same values as in the filters array to sort the resultspossible sorting types:asc - results will be sorted in the ascending orderdesc - results will be sorted in the descending orderyou should use a comma to set up a sorting typeexample:['meta.content_type,desc']note that you can set no more than three sorting rules in a single requestyou should use a comma to separate several sorting rulesexample:['meta.content_type,asc','fetch_time,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// array of results filtering parametersoptional fieldyou can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe following operators are supported:regex, not_regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, like, not_likeyou can use the % operator with like and not_like to match any string of zero or more charactersexample: [['meta.content_type','=','image/jpeg'],'and',['url','not_like','%/help-center/%']]The full list of possible filters is available by this link.
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}