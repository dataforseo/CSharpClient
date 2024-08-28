namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsAmazonProductCompetitorsLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// ASIN of the product
        /// <br/>unique product identifier on Amazon;
        /// <br/>for more information, refer to this help center guide
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Asin { get; set; }

        /// <summary>
        /// average position of the product in Amazon SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given product may differ when combined with different target products
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avg_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AvgPosition { get; set; }

        /// <summary>
        /// sum of all product positions in Amazon SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given product may differ when combined with different target products
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SumPosition { get; set; }

        /// <summary>
        /// number of intersecting keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intersections", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Intersections { get; set; }

        /// <summary>
        /// metrics for intersecting keywords
        /// <br/>ranking data relevant to the keywords that the provided asin shares with the target asin;
        /// <br/>Note: in this object ranking data is provided for the returned competitor’s asin
        /// </summary>
        [Newtonsoft.Json.JsonProperty("competitor_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AmazonMetricsBundleInfo CompetitorMetrics { get; set; }

        /// <summary>
        /// metrics for all keywords of the product
        /// <br/>full overview of ranking data relevant to all keywords that the provided asin is ranking for
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AmazonMetricsBundleInfo FullMetrics { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}