using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class MerchantGoogleSellersTasksReadyResultInfo 
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
        /// <br/>can take the following values: shopping
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// date when the task was posted (in the UTC format)
        /// </summary>
        [JsonProperty("date_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatePosted { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// URL for collecting the results of Google Shopping Sellers Advanced task
        /// </summary>
        [JsonProperty("endpoint_advanced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointAdvanced { get; set; }

        /// <summary>
        /// URL for collecting the results of Google Shopping Sellers HTML task
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