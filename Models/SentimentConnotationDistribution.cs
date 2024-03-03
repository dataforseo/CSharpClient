namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SentimentConnotationDistribution
    {
        [Newtonsoft.Json.JsonProperty("anger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Anger { get; set; }

        [Newtonsoft.Json.JsonProperty("happiness", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Happiness { get; set; }

        [Newtonsoft.Json.JsonProperty("love", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Love { get; set; }

        [Newtonsoft.Json.JsonProperty("sadness", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Sadness { get; set; }

        [Newtonsoft.Json.JsonProperty("share", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Share { get; set; }

        [Newtonsoft.Json.JsonProperty("fun", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentAnalysisSummaryInfo Fun { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}