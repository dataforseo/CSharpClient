namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RankedKeywordsInfo
    {
        /// <summary>
        /// number of keywords for which the page is ranked in top 3 search results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_keywords_count_top_3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop3 { get; set; }

        /// <summary>
        /// number of keywords for which the page is ranked in top 10 search results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_keywords_count_top_10", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop10 { get; set; }

        /// <summary>
        /// number of keywords for which the page is ranked in top 100 search results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_keywords_count_top_100", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop100 { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}