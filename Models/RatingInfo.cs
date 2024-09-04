namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RatingInfo
    {
        /// <summary>
        /// the type of rating
        /// <br/>here you can find the following elements: Max5, Percents, CustomMax
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatingType { get; set; }

        /// <summary>
        /// the value of the rating
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Value { get; set; }

        /// <summary>
        /// the amount of feedback
        /// </summary>
        [Newtonsoft.Json.JsonProperty("votes_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? VotesCount { get; set; }

        /// <summary>
        /// the maximum value for a rating_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_max", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RatingMax { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}