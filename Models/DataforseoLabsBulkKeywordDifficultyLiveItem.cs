namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsBulkKeywordDifficultyLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// keyword in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// difficulty of ranking in the first top-10 organic results for a keyword
        /// <br/>indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100;
        /// <br/>calculated by analysing, among other parameters, link profiles of the first 10 pages in SERP;
        /// <br/>learn more about the metric in this help center guide
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_difficulty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? KeywordDifficulty { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}