using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataAttributesInfo 
    {

        /// <summary>
        /// available attributes
        /// <br/>indicates attributes a business entity can offer
        /// </summary>
        [JsonProperty("available_attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> AvailableAttributes { get; set; }

        /// <summary>
        /// unavailable attributes
        /// <br/>indicates attributes a business entity cannot offer
        /// </summary>
        [JsonProperty("unavailable_attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> UnavailableAttributes { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}