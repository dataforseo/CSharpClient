namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AvgBacklinksInfo
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// average number of backlinks
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Backlinks { get; set; }

        /// <summary>
        /// average number of dofollow links
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Dofollow { get; set; }

        /// <summary>
        /// average number of referring pages
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ReferringPages { get; set; }

        /// <summary>
        /// average number of referring domains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ReferringDomains { get; set; }

        /// <summary>
        /// average number of referring main domains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_main_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ReferringMainDomains { get; set; }

        /// <summary>
        /// average rank
        /// <br/>learn more about the metric and its calculation formula in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Rank { get; set; }

        /// <summary>
        /// average main domain rank
        /// <br/>learn more about the metric and its calculation formula in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? MainDomainRank { get; set; }

        /// <summary>
        /// date and time when backlink data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_updated_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}