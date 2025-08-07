using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpGoogleDatasetInfoTasksFixedResultInfo 
    {

        /// <summary>
        /// task identifier of the completed task
        /// <br/>unique task identifier in our system in the UUID format
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// search engine specified when setting the task
        /// </summary>
        [JsonProperty("se", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Se { get; set; }

        /// <summary>
        /// type of search engine
        /// <br/>can take the following values: dataset_info
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }
        [JsonProperty("date_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatePosted { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// URL for collecting the results of the SERP Regular task
        /// <br/>if SERP Regular is not supported in the specified endpoint, the value will be null
        /// </summary>
        [JsonProperty("endpoint_regular", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointRegular { get; set; }

        /// <summary>
        /// URL for collecting the results of the SERP Advanced task
        /// <br/>if SERP Advanced is not supported in the specified endpoint, the value will be null
        /// </summary>
        [JsonProperty("endpoint_advanced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointAdvanced { get; set; }

        /// <summary>
        /// URL for collecting the results of the SERP HTML task
        /// <br/>if SERP HTML is not supported in the specified endpoint, the value will be null
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