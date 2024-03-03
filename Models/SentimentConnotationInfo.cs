namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SentimentConnotationInfo
    {
        /// <summary>
        /// anger
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Anger { get; set; }

        /// <summary>
        /// happiness
        /// </summary>
        [Newtonsoft.Json.JsonProperty("happiness", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Happiness { get; set; }

        /// <summary>
        /// love
        /// </summary>
        [Newtonsoft.Json.JsonProperty("love", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Love { get; set; }

        /// <summary>
        /// sadness
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sadness", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Sadness { get; set; }

        /// <summary>
        /// share
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Share { get; set; }

        /// <summary>
        /// fun
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fun", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fun { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}