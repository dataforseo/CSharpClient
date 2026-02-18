using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleSubdomainsLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// returned subdomain
        /// </summary>
        [JsonProperty("subdomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Subdomain { get; set; }

        /// <summary>
        /// ranking data relevant to subdomain
        /// </summary>
        [JsonProperty("metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, DataforseoLabsMetricsInfo> Metrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}