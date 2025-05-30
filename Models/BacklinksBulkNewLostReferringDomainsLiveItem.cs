using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksBulkNewLostReferringDomainsLiveItem 
    {

        /// <summary>
        /// domain, subdomain or webpage from a POST array
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// number of new referring domains
        /// <br/>number of new referring domains pointing to the target
        /// </summary>
        [JsonProperty("new_referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewReferringDomains { get; set; }

        /// <summary>
        /// number of lost referring domains
        /// <br/>number of lost referring domains of the target
        /// </summary>
        [JsonProperty("lost_referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LostReferringDomains { get; set; }

        /// <summary>
        /// number of new referring main domains pointing to the target
        /// </summary>
        [JsonProperty("new_referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewReferringMainDomains { get; set; }

        /// <summary>
        /// number of lost referring main domains pointing to the target
        /// </summary>
        [JsonProperty("lost_referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LostReferringMainDomains { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}