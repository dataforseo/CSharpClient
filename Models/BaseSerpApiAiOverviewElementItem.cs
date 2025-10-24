using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("ai_overview_element", typeof(SerpApiAiOverviewElementItem))]
    [JsonInheritance("ai_overview_expanded_element", typeof(SerpApiAiOverviewExpandedElementItem))]
    [JsonInheritance("ai_overview_video_element", typeof(SerpApiAiOverviewVideoElementItem))]
    [JsonInheritance("ai_overview_table_element", typeof(SerpApiAiOverviewTableElementItem))]
    [JsonInheritance("ai_overview_shopping", typeof(SerpApiAiOverviewShoppingItem))]

    public class BaseSerpApiAiOverviewElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}