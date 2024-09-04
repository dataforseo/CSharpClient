namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksAnchorsLiveItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// anchor of the backlink
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Anchor { get; set; }

        /// <summary>
        /// rank of the anchor links
        /// <br/>rank volume that referring websites pass to the target through links with a particular anchor
        /// <br/>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// indicates the number of backlinks
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// date and time when our crawler found the backlink with this anchor for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_seen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// date and time when the last backlink with this anchor was lost
        /// <br/>indicates the date and time when our crawler visited the page and it responded with 4xx or 5xx status code or the last backlink was removed
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lost_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LostDate { get; set; }

        /// <summary>
        /// average spam score of all backlinks with this anchor
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks_spam_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BacklinksSpamScore { get; set; }

        /// <summary>
        /// number of broken backlinks
        /// <br/>number of broken backlinks pointing to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("broken_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BrokenBacklinks { get; set; }

        /// <summary>
        /// number of broken pages
        /// <br/>number of pages that respond with 4xx or 5xx status codes where backlinks are pointing to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("broken_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BrokenPages { get; set; }

        /// <summary>
        /// indicates the number of referring domains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringDomains { get; set; }

        /// <summary>
        /// number of domains pointing at least one nofollow link to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_domains_nofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringDomainsNofollow { get; set; }

        /// <summary>
        /// indicates the number of referring main domains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_main_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringMainDomains { get; set; }

        /// <summary>
        /// number of main domains pointing at least one nofollow link to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_main_domains_nofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringMainDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring IP addresses
        /// <br/>number of IP addresses pointing to this page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_ips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringIps { get; set; }

        /// <summary>
        /// number of referring subnetworks
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_subnets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringSubnets { get; set; }

        /// <summary>
        /// indicates the number of pages pointing to target with this anchor
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringPages { get; set; }

        /// <summary>
        /// number of referring pages pointing at least one nofollow link to the target with this anchor
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_pages_nofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReferringPagesNofollow { get; set; }

        /// <summary>
        /// top-level domains of the referring links
        /// <br/>contains top level domains and referring link count per each
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_links_tld", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ReferringLinksTld { get; set; }

        /// <summary>
        /// types of referring links
        /// <br/>indicates the types of the referring links and link count per each type
        /// <br/>possible values:
        /// <br/>anchor, image, link, meta, canonical, alternate, redirect
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_links_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ReferringLinksTypes { get; set; }

        /// <summary>
        /// link attributes of the referring links
        /// <br/>indicates link attributes of the referring links and link count per each attribute
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_links_attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ReferringLinksAttributes { get; set; }

        /// <summary>
        /// types of referring platforms
        /// <br/>indicates referring platform types and and link count per each platform
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_links_platform_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ReferringLinksPlatformTypes { get; set; }

        /// <summary>
        /// semantic locations of the referring links
        /// <br/>indicates semantic elements in HTML where the referring links are located and link count per each semantic location
        /// <br/>you can get the full list of semantic elements here
        /// <br/>examples:
        /// <br/>article, section, summary
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_links_semantic_locations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ReferringLinksSemanticLocations { get; set; }

        /// <summary>
        /// ISO country codes of the referring links
        /// <br/>indicates ISO country codes of the domains where the referring links are located and the link count per each country
        /// </summary>
        [Newtonsoft.Json.JsonProperty("referring_links_countries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ReferringLinksCountries { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}