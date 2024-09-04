namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppMetricsInfo
    {
        /// <summary>
        /// number of organic SERPs where the product ranks #1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos1 { get; set; }

        /// <summary>
        /// number of organic SERPs where the product ranks #2-3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_2_3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos23 { get; set; }

        /// <summary>
        /// number of organic SERPs where the product ranks #4-10
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_4_10", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos410 { get; set; }

        /// <summary>
        /// number of organic SERPs where the product ranks #11-100
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pos_11_100", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Pos11100 { get; set; }

        /// <summary>
        /// total count of Amazon organic SERPs that contain the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// total search volume of the product’s ranking keywords in organic SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}