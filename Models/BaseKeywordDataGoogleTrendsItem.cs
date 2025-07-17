using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("google_trends_graph", typeof(GoogleTrendsGoogleTrendsGraphElementItem))]
    [JsonInheritance("google_trends_map", typeof(GoogleTrendsGoogleTrendsMapElementItem))]
    [JsonInheritance("google_trends_queries_list", typeof(GoogleTrendsGoogleTrendsQueriesListElementItem))]
    [JsonInheritance("google_trends_topics_list", typeof(GoogleTrendsGoogleTrendsTopicsListElementItem))]

    public class BaseKeywordDataGoogleTrendsItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// the alignment of the element in Google Trends
        /// <br/>can take the following values: 1, 2, 3, 4, etc.
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// title of the element in Google Trends
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// relevant keywords
        /// <br/>the data included in the google_trends_graph element is based on the keywords listed in this array
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