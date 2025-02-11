namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SearchVolumeTrend
    {
        /// <summary>
        /// search volume change in percent compared to the previous month
        /// </summary>
        [Newtonsoft.Json.JsonProperty("monthly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Monthly { get; set; }

        /// <summary>
        /// search volume change in percent compared to the previous quarter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quarterly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Quarterly { get; set; }

        /// <summary>
        /// search volume change in percent compared to the previous year
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yearly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Yearly { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}