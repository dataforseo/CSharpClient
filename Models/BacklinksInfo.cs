namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksInfo
    {
        /// <summary>
        /// number of referring domains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringDomains { get; set; }

        /// <summary>
        /// number of referring main domains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_main_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringMainDomains { get; set; }

        /// <summary>
        /// number of referring pages
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringPages { get; set; }

        /// <summary>
        /// number of dofollow links
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Dofollow { get; set; }

        /// <summary>
        /// total number of backlinks
        /// <br/>the total number of backlinks, including dofollow and nofollow links
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// date and time when backlink data was updated
        /// <br/>in the UTC format: "yyyy-mm-dd hh-mm-ss +00:00"
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_update", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeUpdate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}