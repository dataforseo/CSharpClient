namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HistoricalMetricsBundleInfo
    {
        /// <summary>
        /// traffic data from organic search
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HistoricalMetricsInfo> Organic { get; set; }

        /// <summary>
        /// traffic data from paid search
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HistoricalMetricsInfo> Paid { get; set; }

        /// <summary>
        /// traffic data from the featured snippet results in Google SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("local_pack", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HistoricalMetricsInfo> LocalPack { get; set; }

        /// <summary>
        /// traffic data from the local pack results in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("featured_snippet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HistoricalMetricsInfo> FeaturedSnippet { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}