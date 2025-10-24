using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Graph 
    {

        /// <summary>
        /// link of the element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GraphElement> Items { get; set; }

        /// <summary>
        /// previous close data
        /// <br/>contains stock price data based on the preceding time period
        /// </summary>
        [JsonProperty("previous_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GraphElement> PreviousItems { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}