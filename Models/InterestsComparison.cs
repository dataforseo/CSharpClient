using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class InterestsComparison 
    {

        /// <summary>
        /// contains keyword popularity and related data
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AbsoluteItems> Items { get; set; }

        /// <summary>
        /// keyword popularity rates across all locations
        /// <br/>values in this array represent percentages relative to the maximum value across all locations
        /// </summary>
        [JsonProperty("absolute_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AbsoluteItems> AbsoluteItems { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}