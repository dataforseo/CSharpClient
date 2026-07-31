using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AppDataAppleAppListingsSearchLiveRequestInfo 
    {

        /// <summary>
        /// app categories
        /// <br/>optional field
        /// <br/>the categories you specify are used to search for app listings;
        /// <br/>you can get the full list of available app listing categories by <see href="http://docs.dataforseo.com/v3/app_data/apple/app_listings/categories">this link</see>
        /// <br/>you can specify up to 10 categories
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// keyword in the app's description
        /// <br/>optional field
        /// <br/>keywords that occur in the description of the app;
        /// <br/>can contain up to 200 characters
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// keyword in the app's title
        /// <br/>optional field
        /// <br/>keywords that occur in the title of the app;
        /// <br/>can contain up to 200 characters
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator <c>and</c>, <c>or</c> between the conditions
        /// <br/>the following operators are supported:
        /// <br/><c>regex</c>, <c>not_regex</c>, <c>&lt;</c>, <c>&lt;=</c>, <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>in</c>, <c>not_in</c>, <c>like</c>, <c>not_like</c>
        /// <br/>you can use the <c>%</c> operator with <c>like</c> and <c>not_like</c> to match any string of zero or more characters
        /// <br/>example:
        /// <br/><c>['rating.value','&gt;',3]</c>
        /// <br/>you can receive the list of available filters_by making a separate request to <c>https://api.dataforseo.com/v3/app_data/apple/app_listings/available_filters</c>n
        /// </summary>
        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the <c>filters</c> array to sort the results
        /// <br/>possible sorting types:
        /// <br/><c>asc</c> - results will be sorted in the ascending order
        /// <br/><c>desc</c> - results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting parameter
        /// <br/>example:
        /// <br/><c>['item.rating.value,desc']</c>
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/><c>['item.rating.value,desc','item.rating.value,desc']</c>
        /// </summary>
        [JsonProperty("order_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OrderBy { get; set; }

        /// <summary>
        /// the maximum number of returned apps
        /// <br/>optional field
        /// <br/>default value: <c>100</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned apps
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten entities in the results array will be omitted and the data will be provided for the successive entities
        /// <br/>Note: we recommend using this parameter only when retrieving up to 10,000 results
        /// <br/>for retrieving over 10,000 results, use the <c>offset_token</c> instead.
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// token for subsequent requests
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>use this parameter to avoid timeouts while trying to obtain over 100,000 results in a single request;
        /// <br/>by specifying the unique <c>offset_token</c> value from the response array, you will get the subsequent results of the initial task;
        /// <br/><c>offset_token</c> values are unique for each subsequent task 
        /// <br/>Note: if the <c>offset_token</c> is specified in the request, all other parameters should be identical to the previous request
        /// <br/>learn more about this parameter on our <see href="https://dataforseo.com/help-center/what-is-the-difference-between-the-offset-and-offset_token-parameters#offset_token">Help Center</see>
        /// </summary>
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

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