namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("product_information_details_item", typeof(ProductInformationDetailsItem))]
    [JsonInheritanceAttribute("product_information_text_item", typeof(ProductInformationTextItem))]
    [JsonInheritanceAttribute("product_information_extended_item", typeof(ProductInformationExtendedItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseProductInformationItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// name of the section related to product information specified in the contents
        /// </summary>
        [Newtonsoft.Json.JsonProperty("section_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SectionName { get; set; }

    }
}