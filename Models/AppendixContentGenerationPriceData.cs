namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixContentGenerationPriceData
    {
        [Newtonsoft.Json.JsonProperty("check_grammar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixContentGenerationPriceDataInfo CheckGrammar { get; set; }

        [Newtonsoft.Json.JsonProperty("generate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo Generate { get; set; }

        [Newtonsoft.Json.JsonProperty("generate_meta_tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo GenerateMetaTags { get; set; }

        [Newtonsoft.Json.JsonProperty("generate_sub_topics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo GenerateSubTopics { get; set; }

        [Newtonsoft.Json.JsonProperty("generate_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo GenerateText { get; set; }

        [Newtonsoft.Json.JsonProperty("paraphrase", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo Paraphrase { get; set; }

        [Newtonsoft.Json.JsonProperty("text_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixContentGenerationPriceDataInfo TextSummary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}