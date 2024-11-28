namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixBusinessListingsBusinessDataPriceData
    {
        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Categories { get; set; }

        [Newtonsoft.Json.JsonProperty("categories_aggregation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo CategoriesAggregation { get; set; }

        [Newtonsoft.Json.JsonProperty("locations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Locations { get; set; }

        [Newtonsoft.Json.JsonProperty("search", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Search { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}