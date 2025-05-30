using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{

    public class BaseResponseInfo 
    {

        /// <summary>
        /// the current version of the API
        /// </summary>
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// general status code
        /// <br/>you can find the full list of the response codes here
        /// </summary>
        [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// general informational message
        /// <br/>you can find the full list of general informational messages here
        /// </summary>
        [JsonProperty("status_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// total execution time, seconds
        /// </summary>
        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// total tasks cost, USD
        /// </summary>
        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        /// <summary>
        /// the number of tasks in the tasks array
        /// </summary>
        [JsonProperty("tasks_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TasksCount { get; set; }

        /// <summary>
        /// the number of tasks in the tasks array returned with an error
        /// </summary>
        [JsonProperty("tasks_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TasksError { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}