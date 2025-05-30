using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class IntersectionSummaryInfo 
    {

        /// <summary>
        /// total number of intersections
        /// </summary>
        [JsonProperty("intersections_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IntersectionsCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}