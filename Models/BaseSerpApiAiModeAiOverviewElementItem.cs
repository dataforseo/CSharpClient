using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("ai_overview_element", typeof(SerpApiAiModeAiOverviewElementItem))]
    [JsonInheritance("ai_overview_expanded_element", typeof(SerpApiAiModeAiOverviewExpandedElementItem))]
    [JsonInheritance("ai_overview_video_element", typeof(SerpApiAiModeAiOverviewVideoElementItem))]
    [JsonInheritance("ai_overview_table_element", typeof(SerpApiAiModeAiOverviewTableElementItem))]

    public class BaseSerpApiAiModeAiOverviewElementItem 
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