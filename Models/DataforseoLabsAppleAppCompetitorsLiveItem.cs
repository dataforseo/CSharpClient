namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsAppleAppCompetitorsLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// id of the competitor app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// average position of the app in App Store SERP
        /// <br/>Note: average position is calculated for intersected keywords only;
        /// <br/>the value for a given application may differ when combined with different target applications
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avg_position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AvgPosition { get; set; }

        /// <summary>
        /// sum of all app positions in App Store SERP
        /// <br/>Note: sum position is calculated for intersected keywords only;
        /// <br/>the value for a given application may differ when combined with different target applications
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
        /// <br/>ranking data relevant to the keywords that the provided competitor application shares with the app in a POST request;
        /// <br/>note: in this array ranking data is provided for the returned competitor’s app_id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("competitor_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppStoreMetricsBundleInfo CompetitorMetrics { get; set; }

        /// <summary>
        /// metrics for all keywords of the application
        /// <br/>full overview of ranking data relevant to all keywords that the provided app_id is ranking for
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppStoreMetricsBundleInfo FullMetrics { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}