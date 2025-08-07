using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("knowledge_graph_carousel_item", typeof(SerpApiKnowledgeGraphCarouselItemElementItem))]
    [JsonInheritance("knowledge_graph_description_item", typeof(SerpApiKnowledgeGraphDescriptionItemElementItem))]
    [JsonInheritance("knowledge_graph_images_item", typeof(SerpApiKnowledgeGraphImagesItemElementItem))]
    [JsonInheritance("knowledge_graph_list_item", typeof(SerpApiKnowledgeGraphListItemElementItem))]
    [JsonInheritance("knowledge_graph_row_item", typeof(SerpApiKnowledgeGraphRowItemElementItem))]
    [JsonInheritance("knowledge_graph_expanded_item", typeof(SerpApiKnowledgeGraphExpandedItemElementItem))]
    [JsonInheritance("knowledge_graph_part_item", typeof(SerpApiKnowledgeGraphPartItemElementItem))]
    [JsonInheritance("knowledge_graph_shopping_item", typeof(SerpApiKnowledgeGraphShoppingItemElementItem))]
    [JsonInheritance("knowledge_graph_hotels_booking_item", typeof(SerpApiKnowledgeGraphHotelsBookingItemElementItem))]
    [JsonInheritance("knowledge_graph_ai_overview_item", typeof(SerpApiKnowledgeGraphAiOverviewItemElementItem))]

    public class BaseSerpApiKnowledgeGraphElementItem 
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

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// rectangle parameters
        /// <br/>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
        /// <br/>equals null if calculate_rectangles in the POST request is not set to true
        /// </summary>
        [JsonProperty("rectangle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AiModeRectangleInfo Rectangle { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}