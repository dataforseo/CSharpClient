namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksTimeseriesSummaryLiveItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date and time when the data for the target was stored
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// target rank for the given date
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// number of backlinks for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// number of nofollow backlinks for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks_nofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BacklinksNofollow { get; set; }

        /// <summary>
        /// number of pages pointing to target for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringPages { get; set; }

        /// <summary>
        /// number of referring pages pointing at least one nofollow link to the target for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_pages_nofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringPagesNofollow { get; set; }

        /// <summary>
        /// number of referring domains for the given date
        /// <br/>referring domains include subdomains that are counted as separate domains for this metric
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringDomains { get; set; }

        /// <summary>
        /// number of domains pointing at least one nofollow link to the target for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_domains_nofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring main domains for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_main_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringMainDomains { get; set; }

        /// <summary>
        /// number of main domains pointing at least one nofollow link to the target for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_main_domains_nofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringMainDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring IP addresses for the given date
        /// <br/>number of IP addresses pointing to this page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_ips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringIps { get; set; }

        /// <summary>
        /// number of referring subnetworks for the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_subnets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringSubnets { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}