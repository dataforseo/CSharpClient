using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpErrorsRequestInfo
    {
        /// <summary>
        /// the maximum number of returned tasks that responded with an error
        /// <br/>optional field
        /// <br/>default value: 1000
        /// <br/>maximum value: 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned tasks
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten tasks in the results array will be omitted and the data will be provided for the successive tasks
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// return tasks with a certain function
        /// <br/>use this field to obtain a list of tasks that returned an error filtered by a certain function
        /// <br/>you can filter the results by the values you receive in the function fields of the API response
        /// <br/>i.e., once you receive unfiltered results, you can call this API again to filter them by function
        /// <br/>example: serp/task_get/advanced, postback_url, pingback_url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filtered_function", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FilteredFunction { get; set; }

        /// <summary>
        /// start time for filtering results
        /// <br/>optional field
        /// <br/>allows filtering results by the datetime parameter within the range of the last 24 hours;
        /// <br/>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2021-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatetimeFrom { get; set; }

        /// <summary>
        /// finish time for filtering results
        /// <br/>optional field
        /// <br/>allows filtering results by the datetime parameter within the range of the last 24 hours;
        /// <br/>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2021-11-15 13:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatetimeTo { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}