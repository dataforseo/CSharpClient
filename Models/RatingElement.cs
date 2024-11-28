namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RatingElement
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
        public double? Value { get; set; }

        /// <summary>
        /// the amount of feedbac
        /// </summary>
        [Newtonsoft.Json.JsonProperty("votes_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? VotesCount { get; set; }

        /// <summary>
        /// the maximum value for a rating_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_max", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RatingMax { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// the alignment of the element in Google Shopping SERP
        /// <br/>possible values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}