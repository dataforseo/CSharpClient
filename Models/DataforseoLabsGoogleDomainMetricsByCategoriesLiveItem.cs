namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// categories for which domains are collected
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int?> TopCategories { get; set; }

        /// <summary>
        /// current organic ETV of the domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organic_etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? OrganicEtv { get; set; }

        /// <summary>
        /// current total count of organic SERPs that contain the domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organic_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OrganicCount { get; set; }

        /// <summary>
        /// current number of lost ranked elements
        /// <br/>indicates how many ranked elements of the domain were previously presented in SERPs, but weren’t found during the last check
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organic_is_lost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OrganicIsLost { get; set; }

        /// <summary>
        /// current number of new ranked elements
        /// <br/>indicates how many new ranked elements were found for the domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organic_is_new", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OrganicIsNew { get; set; }

        /// <summary>
        /// domain found for the specified category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// primary domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// historical ranking and traffic data of the domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metrics_history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, MetricsInfo>> MetricsHistory { get; set; }

        /// <summary>
        /// metrics difference between first_date and second_date
        /// <br/>calculated by subtracting domain metrics as of the greater date from domain metrics as of the smaller date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metrics_difference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, MetricsInfo> MetricsDifference { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}