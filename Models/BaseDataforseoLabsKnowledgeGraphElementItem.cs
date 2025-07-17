using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("knowledge_graph_images_item", typeof(DataforseoLabsKnowledgeGraphImagesItemElementItem))]
    [JsonInheritance("knowledge_graph_carousel_item", typeof(DataforseoLabsKnowledgeGraphCarouselItemElementItem))]
    [JsonInheritance("knowledge_graph_description_item", typeof(DataforseoLabsKnowledgeGraphDescriptionItemElementItem))]
    [JsonInheritance("knowledge_graph_list_item", typeof(DataforseoLabsKnowledgeGraphListItemElementItem))]
    [JsonInheritance("knowledge_graph_part_item", typeof(DataforseoLabsKnowledgeGraphPartItemElementItem))]
    [JsonInheritance("knowledge_graph_expanded_item", typeof(DataforseoLabsKnowledgeGraphExpandedItemElementItem))]
    [JsonInheritance("knowledge_graph_row_item", typeof(DataforseoLabsKnowledgeGraphRowItemElementItem))]
    [JsonInheritance("knowledge_graph_shopping_item", typeof(DataforseoLabsKnowledgeGraphShoppingItemElementItem))]

    public class BaseDataforseoLabsKnowledgeGraphElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

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

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}