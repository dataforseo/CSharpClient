using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppDataGoogleAppListingsCategoriesResultInfo 
    {

        /// <summary>
        /// task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("se", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Se { get; set; }
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }
        [JsonProperty("date_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatePosted { get; set; }
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }
        [JsonProperty("endpoint_advanced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointAdvanced { get; set; }
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