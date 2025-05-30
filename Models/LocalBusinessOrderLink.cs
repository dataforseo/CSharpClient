using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class LocalBusinessOrderLink  : BaseLocalBusinessLink 
    {

        /// <summary>
        /// lists available delivery services
        /// </summary>
        [JsonProperty("delivery_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LocalBusinessDeliveryServiceInfo> DeliveryServices { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}