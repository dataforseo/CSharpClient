using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksDomainIntersectionLiveItem 
    {

        /// <summary>
        /// contains data on domains that link to the corresponding targets specified in the POST array
        /// <br/>data is provided in separate objects corresponding to domains, subdomains or pages specified in the targets object
        /// </summary>
        [JsonProperty("domain_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, BacklinksDomainIntersectionInfo> DomainIntersection { get; set; }

        /// <summary>
        /// contains the domain intersections summary
        /// </summary>
        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IntersectionSummaryInfo Summary { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}