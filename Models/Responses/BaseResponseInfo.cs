using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseResponseInfo
    {
        /// <summary>
        /// the current version of the API
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// general status code
        /// <br/>you can find the full list of the response codes here
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// general informational message
        /// <br/>you can find the full list of general informational messages here
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// total execution time, seconds
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// total tasks cost, USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        /// <summary>
        /// the number of tasks in the tasks array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tasks_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TasksCount { get; set; }

        /// <summary>
        /// the number of tasks in the tasks array returned with an error
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tasks_error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TasksError { get; set; }

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