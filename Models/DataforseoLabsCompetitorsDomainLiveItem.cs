namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsCompetitorsDomainLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// average position of the domain in SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given domain may differ when combined with different target websites
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avg_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AvgPosition { get; set; }

        /// <summary>
        /// sum of all domain positions in SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given domain may differ when combined with different target websites
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SumPosition { get; set; }

        /// <summary>
        /// number of intersecting keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intersections", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Intersections { get; set; }

        /// <summary>
        /// metrics for all keywords of the domain
        /// <br/>full overview of ranking and traffic data relevant to all keywords that the provided domain is ranking for
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full_domain_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, MetricsInfo> FullDomainMetrics { get; set; }

        /// <summary>
        /// metrics for intersecting keywords
        /// <br/>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain
        /// <br/>note: in this array ranking and traffic data is provided for the target considering the keywords target shares in search with the competitor’s domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, MetricsInfo> Metrics { get; set; }

        /// <summary>
        /// metrics for intersecting keywords
        /// <br/>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain
        /// <br/>note: in this array ranking and traffic data is provided for the returned competitor’s domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("competitor_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, MetricsInfo> CompetitorMetrics { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}