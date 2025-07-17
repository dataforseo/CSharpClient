using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("product_information_details_item", typeof(ProductInformationProductInformationDetailsItem))]
    [JsonInheritance("product_information_text_item", typeof(ProductInformationProductInformationTextItem))]
    [JsonInheritance("product_information_extended_item", typeof(ProductInformationProductInformationExtendedItem))]

    public class BaseMerchantAmazonProductInformationElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// name of the section related to product information specified in the contents
        /// </summary>
        [JsonProperty("section_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SectionName { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}