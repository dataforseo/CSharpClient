namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RankInfo
    {
        /// <summary>
        /// page rank
        /// <br/>page_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm;
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageRank { get; set; }

        /// <summary>
        /// main domain rank
        /// <br/>main_domain_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MainDomainRank { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}