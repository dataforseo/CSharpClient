using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class CacheControl 
    {

        /// <summary>
        /// indicates whether the page is cacheable
        /// </summary>
        [JsonProperty("cachable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cachable { get; set; }

        /// <summary>
        /// time to live
        /// <br/>the amount of time the browser caches a resource
        /// </summary>
        [JsonProperty("ttl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Ttl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}