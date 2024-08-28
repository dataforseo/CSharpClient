namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ReviewMentionInfo
    {
        /// <summary>
        /// title of the evaluated criterion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// positive score by criterion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positive_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? PositiveScore { get; set; }

        /// <summary>
        /// count of positive reviews by criterion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positive_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PositiveCount { get; set; }

        /// <summary>
        /// count of negative reviews by criterion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("negative_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? NegativeCount { get; set; }

        /// <summary>
        /// count of all reviews by criterion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// element is visible by default
        /// <br/>indicates whether the review element is visible by default
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visible_by_default", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? VisibleByDefault { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}