using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsIdListResultInfo 
    {

        /// <summary>
        /// id of the task
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// URL of the task
        /// <br/>URL you used for making an API call
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// date and time when the task was made
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2023-01-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatetimePosted { get; set; }

        /// <summary>
        /// date and time when the task was completed
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2023-01-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime_done", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatetimeDone { get; set; }

        /// <summary>
        /// informational message of the task
        /// <br/>you can find the full list of general informational messages here
        /// </summary>
        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// cost of the task, USD
        /// </summary>
        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        /// <summary>
        /// contains parameters you specified in the POST request
        /// </summary>
        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object> Metadata { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}