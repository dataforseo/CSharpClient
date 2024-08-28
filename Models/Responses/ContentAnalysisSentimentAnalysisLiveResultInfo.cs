using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentAnalysisSentimentAnalysisLiveResultInfo
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// citation distribution by sentiment connotation types
        /// <br/>contains objects with citation counts and relevant data distributed by types of sentiments (sentiment polarity);
        /// <br/>possible sentiment connotation types: positive, negative, neutral
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positive_connotation_distribution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PositiveConnotationDistribution PositiveConnotationDistribution { get; set; }

        /// <summary>
        /// citation distribution by sentiment connotations
        /// <br/>contains objects with citation counts and relevant data distributed by sentiments (emotional reactions);
        /// <br/>possible sentiment connotation types: anger, happiness, love, sadness, share, fun
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sentiment_connotation_distribution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SentimentConnotationDistribution SentimentConnotationDistribution { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}