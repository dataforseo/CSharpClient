namespace DataForSeo.Client.Models
{

    /// <summary>
    /// items array
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DomainAnalyticsTechnologiesAggregationTechnologiesLiveItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// technology group id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// technology category id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// technology name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("technology", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Technology { get; set; }

        /// <summary>
        /// technology groups count
        /// <br/>number of domains that match the parameters you specified and are using technologies from the indicated group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groups_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? GroupsCount { get; set; }

        /// <summary>
        /// technology categories count
        /// <br/>number of domains that match the parameters you specified and are using technologies from the indicated category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CategoriesCount { get; set; }

        /// <summary>
        /// technologies count
        /// <br/>number of domains that match the parameters you specified and are using the indicated technology
        /// </summary>
        [Newtonsoft.Json.JsonProperty("technologies_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TechnologiesCount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}