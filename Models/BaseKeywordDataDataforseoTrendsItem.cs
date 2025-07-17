using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("dataforseo_trends_graph", typeof(DataforseoTrendsDataforseoTrendsGraphElementItem))]
    [JsonInheritance("subregion_interests", typeof(DataforseoTrendsSubregionInterestsElementItem))]
    [JsonInheritance("demography", typeof(DataforseoTrendsDemographyElementItem))]

    public class BaseKeywordDataDataforseoTrendsItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// the alignment of the element
        /// <br/>can take the following values: 1, 2, 3, 4, etc.
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// relevant keywords
        /// <br/>the data included in the dataforseo_trends_graph element is based on the keywords listed in this array
        /// </summary>
        [JsonProperty("keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}