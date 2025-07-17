using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ShoppingSpecification 
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
        /// absolute rank on the product specification page
        /// <br/>absolute position among all the elements found on the product specification page
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// alignment of the element on the product specification page
        /// <br/>can take the following values:
        /// <br/>right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// name of the block of product attributes
        /// <br/>indicates the name of the product specification section in which the related element is listed
        /// </summary>
        [JsonProperty("block_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BlockName { get; set; }

        /// <summary>
        /// product attribute
        /// <br/>attribute name of the product data specification
        /// </summary>
        [JsonProperty("specification_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// content of the specification
        /// </summary>
        [JsonProperty("specification_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificationValue { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}