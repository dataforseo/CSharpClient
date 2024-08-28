namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ProductInformationExtendedItem : BaseProductInformationItem
    {
        /// <summary>
        /// name of the section related to product information specified in the contents
        /// </summary>
        [Newtonsoft.Json.JsonProperty("section_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SectionName { get; set; }

        /// <summary>
        /// contains information specified about the product within the section_name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ProductInformationRows> Contents { get; set; }

    }
}