namespace DataForSeo.Client.Models
{

    /// <summary>
    /// content rating
    /// <br/>rating related to content_info
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentAnalysisRatingInfo
    {
        /// <summary>
        /// rating name
        /// <br/>here you can find the following elements: Max5, Percents, CustomMax
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// the value of the rating
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RatingValue { get; set; }

        /// <summary>
        /// number of votes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RatingCount { get; set; }

        /// <summary>
        /// 	maximum value for the rating name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_rating_value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaxRatingValue { get; set; }

        /// <summary>
        /// relative rating
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relative_rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RelativeRating { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}