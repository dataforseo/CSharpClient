namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixMerchantAmazonInfo
    {
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo Asin { get; set; }

        [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo Products { get; set; }

        [Newtonsoft.Json.JsonProperty("sellers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixSerpsRatesDataInfo Sellers { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}