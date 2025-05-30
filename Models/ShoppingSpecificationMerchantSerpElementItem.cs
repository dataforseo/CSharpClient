using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ShoppingSpecificationMerchantSerpElementItem  : BaseMerchantSerpElementItem 
    {

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