namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HistoricalMetricsInfo
    {
        /// <summary>
        /// year for which the data is provided
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Year { get; set; }

        /// <summary>
        /// month for which the data is provided
        /// </summary>
        [Newtonsoft.Json.JsonProperty("month", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Month { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// total count of organic SERPs that contain the domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Count { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}