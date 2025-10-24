using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class JobsElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// title of the row
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the results element in SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// location for which the job vacancy is posted
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// author
        /// </summary>
        [JsonProperty("author", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// the time when the job was posted
        /// </summary>
        [JsonProperty("job_posted_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string JobPostedTime { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// contract type
        /// </summary>
        [JsonProperty("contract_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContractType { get; set; }

        /// <summary>
        /// salary
        /// </summary>
        [JsonProperty("salary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Salary { get; set; }

        /// <summary>
        /// URL of element
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}