using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class AppDataErrorsRequestInfo 
    {

        /// <summary>
        /// the maximum number of returned tasks that responded with an error
        /// <br/>optional field
        /// <br/>default value: <c>1000</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned tasks
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten tasks in the results array will be omitted and the data will be provided for the successive tasks
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// return tasks with a certain function
        /// <br/>use this field to obtain a list of tasks that returned an error filtered by a certain function
        /// <br/>you can filter the results by the values you receive in the <c>function</c> fields of the API response
        /// <br/>i.e., once you receive unfiltered results, you can call this API again to filter them by <c>function</c> 
        /// <br/>example: <c>app_data/task_get/advanced</c>, <c>postback_url</c>, <c>pingback_url</c>
        /// </summary>
        [JsonProperty("filtered_function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FilteredFunction { get; set; }

        /// <summary>
        /// start time for filtering results
        /// <br/>optional field
        /// <br/>allows filtering results by the <c>datetime</c> parameter within the range of the last 7 days;
        /// <br/>must be specified in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'
        /// <br/>example:
        /// <br/><c>2021-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("datetime_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatetimeFrom { get; set; }

        /// <summary>
        /// finish time for filtering results
        /// <br/>optional field
        /// <br/>allows filtering results by the <c>datetime</c> parameter within the range of the last 7 days;
        /// <br/>must be specified in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'
        /// <br/>example:
        /// <br/><c>2021-11-15 13:57:46 +00:00</c>
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