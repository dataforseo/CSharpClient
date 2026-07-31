using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppDataAppleAppInfoTasksReadyResultInfo 
    {

        /// <summary>
        /// task identifier of the completed task
        /// <br/>unique task identifier in our system in the <see href="https://en.wikipedia.org/wiki/Universally_unique_identifier">UUID</see> format
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// search engine specified when setting the task
        /// </summary>
        [JsonProperty("se", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Se { get; set; }

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// date when the task was posted (in the UTC format)
        /// </summary>
        [JsonProperty("date_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatePosted { get; set; }
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// URL for collecting the results of the {{up_se_name}} {{normal_se_type}} task
        /// </summary>
        [JsonProperty("endpoint_advanced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointAdvanced { get; set; }

        /// <summary>
        /// URL for collecting the results of the {{up_se_name}} {{normal_se_type}} HTML task
        /// <br/>if HTML tasks are not supported in the specified endpoint, the value will be <c>null</c>
        /// </summary>
        [JsonProperty("endpoint_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointHtml { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}