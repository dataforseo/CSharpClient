using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksBulkNewLostBacklinksLiveItem 
    {

        /// <summary>
        /// domain, subdomain or webpage from a POST array
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// number of new backlinks
        /// <br/>number of new backlinks pointing to the target
        /// </summary>
        [JsonProperty("new_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewBacklinks { get; set; }

        /// <summary>
        /// number of lost backlinks
        /// <br/>number of lost backlinks of the target
        /// </summary>
        [JsonProperty("lost_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LostBacklinks { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}