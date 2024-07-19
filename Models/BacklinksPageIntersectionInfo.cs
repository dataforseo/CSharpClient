namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksPageIntersectionInfo
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// domain referring to the target domain or webpage
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainFrom { get; set; }

        /// <summary>
        /// URL of the page where the backlink is found
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UrlFrom { get; set; }

        /// <summary>
        /// indicates whether the referring URL is secured with HTTPS
        /// <br/>if true, the referring URL is secured with HTTPS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_from_https", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UrlFromHttps { get; set; }

        /// <summary>
        /// domain the backlink is pointing to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainTo { get; set; }

        /// <summary>
        /// URL the backlink is pointing to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UrlTo { get; set; }

        /// <summary>
        /// indicates if the URL the backlink is pointing to is secured with HTTPS
        /// <br/>if true, the URL is secured with HTTPS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_to_https", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UrlToHttps { get; set; }

        /// <summary>
        /// top-level domain of the referring URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tld_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TldFrom { get; set; }

        /// <summary>
        /// indicates whether the backlink is new
        /// <br/>if true, the backlink was found on the page last time our crawler visited it
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_new", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// indicates whether the backlink was removed
        /// <br/>if true, the backlink or the entire page was removed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_lost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsLost { get; set; }

        /// <summary>
        /// spam score of the backlink
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlink_spam_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BacklinkSpamScore { get; set; }

        /// <summary>
        /// backlink rank
        /// <br/>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// page rank of the referring page
        /// <br/>page_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageFromRank { get; set; }

        /// <summary>
        /// domain rank of the referring domain
        /// <br/>indicates the rank of the domain at the time our crawler last saw the backlink;
        /// <br/>domain_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_from_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DomainFromRank { get; set; }

        /// <summary>
        /// platform types of the referring domain
        /// <br/>example:
        /// <br/>"cms",
        /// <br/>"blogs"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_from_platform_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DomainFromPlatformType { get; set; }

        /// <summary>
        /// indicates if the domain is IP
        /// <br/>if true, the domain functions as an IP address and does not have a domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_from_is_ip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DomainFromIsIp { get; set; }

        /// <summary>
        /// IP address of the referring domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_from_ip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainFromIp { get; set; }

        /// <summary>
        /// ISO country code of the referring domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_from_country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainFromCountry { get; set; }

        /// <summary>
        /// number of external links found on the referring page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_external_links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageFromExternalLinks { get; set; }

        /// <summary>
        /// number of internal links found on the referring page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_internal_links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageFromInternalLinks { get; set; }

        /// <summary>
        /// size of the referring page, in bytes
        /// <br/>example:
        /// <br/>63357
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageFromSize { get; set; }

        /// <summary>
        /// character encoding of the referring page
        /// <br/>example:
        /// <br/>utf-8
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_encoding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageFromEncoding { get; set; }

        /// <summary>
        /// language of the referring page
        /// <br/>in ISO 639-1 format
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageFromLanguage { get; set; }

        /// <summary>
        /// title of the referring page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageFromTitle { get; set; }

        /// <summary>
        /// HTTP status code returned by the referring page
        /// <br/>example:
        /// <br/>200
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageFromStatusCode { get; set; }

        /// <summary>
        /// date and time when our crawler found the backlink for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_seen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// previous to the most recent date when our crawler visited the backlink
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prev_seen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrevSeen { get; set; }

        /// <summary>
        /// most recent date when our crawler visited the backlink
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_seen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastSeen { get; set; }

        /// <summary>
        /// link type
        /// <br/>possible values:
        /// <br/>anchor, image, link, meta, canonical, alternate, redirect
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        /// <summary>
        /// link attributes of the referring links
        /// <br/>example:
        /// <br/>nofollow
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Attributes { get; set; }

        /// <summary>
        /// indicates whether the backlink is dofollow
        /// <br/>if false, the backlink is nofollow
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Dofollow { get; set; }

        /// <summary>
        /// indicates whether the backlink was present on the referring page when our crawler first visited it
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Original { get; set; }

        /// <summary>
        /// alternative text of the image
        /// <br/>this field will be null if backlink type is not image
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alt { get; set; }

        /// <summary>
        /// anchor text of the backlink
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Anchor { get; set; }

        /// <summary>
        /// text snippet before the anchor text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text_pre", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TextPre { get; set; }

        /// <summary>
        /// snippet after the anchor text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text_post", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TextPost { get; set; }

        /// <summary>
        /// indicates semantic element in HTML where the backlink is found
        /// <br/>you can get the full list of semantic elements here
        /// <br/>examples:
        /// <br/>article, section, summary
        /// </summary>
        [Newtonsoft.Json.JsonProperty("semantic_location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SemanticLocation { get; set; }

        /// <summary>
        /// number of identical backlinks found on the referring page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("links_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LinksCount { get; set; }

        /// <summary>
        /// indicates total number of backlinks from this domain
        /// <br/>for example, if mode is set to one_per_domain, this field will indicate the total number of backlinks coming from this domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// indicates whether the backlink is broken
        /// <br/>if true, the backlink is pointing to a page responding with a 4xx or 5xx status code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_broken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsBroken { get; set; }

        /// <summary>
        /// status code of the referenced page
        /// <br/>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to
        /// <br/>example:
        /// <br/>200
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_to_status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? UrlToStatusCode { get; set; }

        /// <summary>
        /// spam score of the referenced page
        /// <br/>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_to_spam_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? UrlToSpamScore { get; set; }

        /// <summary>
        /// target url of the redirect
        /// <br/>target page the redirect is pointing to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_to_redirect_target", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UrlToRedirectTarget { get; set; }

        /// <summary>
        /// indicates whether the backlink is an indirect link
        /// <br/>if true, the backlink is an indirect link pointing to a page that either redirects to url_to, or points to a canonical page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_indirect_link", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsIndirectLink { get; set; }

        /// <summary>
        /// indirect link path
        /// <br/>indicates a URL or a sequence of URLs that lead to url_to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("indirect_link_path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Redirect> IndirectLinkPath { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}