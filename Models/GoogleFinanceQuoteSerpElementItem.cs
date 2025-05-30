using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleFinanceQuoteSerpElementItem  : BaseGoogleFinanceSerpElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankAbsolute { get; set; }

        /// <summary>
        /// quoted market indexes
        /// </summary>
        [JsonProperty("quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BaseGoogleFinanceSerpElementItem Quote { get; set; }

        /// <summary>
        /// values on graph
        /// </summary>
        [JsonProperty("graph_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GraphItems> GraphItems { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}