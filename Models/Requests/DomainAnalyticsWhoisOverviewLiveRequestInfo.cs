using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DomainAnalyticsWhoisOverviewLiveRequestInfo 
    {

        /// <summary>
        /// the maximum number of returned domainsoptional fielddefault value: 100maximum value: 1000
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned itemsoptional fielddefault value: 0if you specify the 10 value, the first ten items in the results array will be omitted and the data will be provided for the successive items;Note: we recommend using this parameter only when retrieving up to 10,000 results for retrieving over 10,000 results, use the offset_token instead
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// token for subsequent requestsoptional fieldprovided in the identical filed of the response to each request;use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;by specifying the unique offset_token value from the response array, you will get the subsequent results of the initial task;offset_token values are unique for each subsequent taskNote: if the offset_token is specified in the request, all other parameters should be identical to the previous requestlearn more about this parameter on our Help Center
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

        /// <summary>
        /// array of results filtering parametersoptional fieldyou can add several filters at once (8 filters maximum)you should set a logical operator and, or between the conditionsthe following operators are supported:regex, &lt;, &lt;=, &gt;, &gt;=, =, &lt;&gt;, in, not_in, like, not_likeyou can use the % operator with like and not_like to match any string of zero or more characters
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rulesoptional fieldyou can use the same values as in the filters array to sort the resultspossible sorting types:asc - results will be sorted in the ascending orderdesc - results will be sorted in the descending orderthe comma is used as a separatorexample:['metrics.organic.pos_1,desc']default rule:['metrics.organic.count,desc']note that you can set no more than three sorting rules in a single requestyou should use a comma to separate several sorting rulesexample:['expiration_datetime,asc','metrics.organic.etv,desc','metrics.organic.pos_1,desc']
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

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