using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksPageIntersectionLiveItem 
    {

        /// <summary>
        /// contains data on pages that link to the corresponding targets specified in the POST array
        /// <br/>data is provided in separate objects corresponding to pages specified in the targets object
        /// </summary>
        [JsonProperty("page_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<BacklinksPageIntersection>> PageIntersection { get; set; }

        /// <summary>
        /// contains the page intersections summary
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