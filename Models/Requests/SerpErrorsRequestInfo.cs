using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpErrorsRequestInfo 
    {

        /// <summary>
        /// the maximum number of returned tasks that responded with an error
        /// <br/>optional field
        /// <br/>default value: 1000
        /// <br/>maximum value: 1000
        /// <br/>minimum value: 1
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned tasks
        /// <br/>optional field
        /// <br/>if you specify the 10 value, the first ten tasks in the results array will be omitted and the data will be provided for the successive tasks
        /// <br/>default and minimum value: 0
        /// <br/>maximum value: 100M (100 million)
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// return tasks with a certain function
        /// <br/>use this field to obtain a list of tasks that returned an error filtered by the certain endpoint’s URL, as well as pingback_url or postback_url specified in the API request;
        /// <br/>you can filter the results by the values you receive in the function fields of the API response;
        /// <br/>i.e., once you receive unfiltered results, you can call this API again to filter them by function;
        /// <br/>example: serp/task_get/advanced
        /// </summary>
        [JsonProperty("filtered_function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FilteredFunction { get; set; }

        /// <summary>
        /// start time for filtering results
        /// <br/>optional field
        /// <br/>allows filtering results by the datetime parameter within the range of the last 7 days;
        /// <br/>must be specified in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00';
        /// <br/>minimum value: 7 days from the current datetime
        /// <br/>maximum value: current datetime
        /// <br/>example:
        /// <br/>2021-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatetimeFrom { get; set; }

        /// <summary>
        /// finish time for filtering results
        /// <br/>optional field
        /// <br/>allows filtering results by the datetime parameter within the range of the last 7 days;
        /// <br/>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>minimum value: 7 days from the current datetime
        /// <br/>maximum value: current datetime
        /// <br/>Note datetime_to must be greater than datetime_from if both parameters are used;
        /// <br/>example:
        /// <br/>2021-11-15 13:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatetimeTo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}