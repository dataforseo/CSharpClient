using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksBacklinksLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// domain referring to the target domain or webpage
        /// </summary>
        [JsonProperty("domain_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DomainFrom { get; set; }

        /// <summary>
        /// URL of the page where the backlink is found
        /// </summary>
        [JsonProperty("url_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UrlFrom { get; set; }

        /// <summary>
        /// indicates whether the referring URL is secured with HTTPS
        /// <br/>if true, the referring URL is secured with HTTPS
        /// </summary>
        [JsonProperty("url_from_https", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UrlFromHttps { get; set; }

        /// <summary>
        /// domain the backlink is pointing to
        /// </summary>
        [JsonProperty("domain_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DomainTo { get; set; }

        /// <summary>
        /// URL the backlink is pointing to
        /// </summary>
        [JsonProperty("url_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UrlTo { get; set; }

        /// <summary>
        /// indicates if the URL the backlink is pointing to is secured with HTTPS
        /// <br/>if true, the URL is secured with HTTPS
        /// </summary>
        [JsonProperty("url_to_https", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UrlToHttps { get; set; }

        /// <summary>
        /// top-level domain of the referring URL
        /// </summary>
        [JsonProperty("tld_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TldFrom { get; set; }

        /// <summary>
        /// indicates whether the backlink is new
        /// <br/>if true, the backlink was found on the page last time our crawler visited it
        /// </summary>
        [JsonProperty("is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// indicates whether the backlink was removed
        /// <br/>if true, the backlink or the entire page was removed
        /// </summary>
        [JsonProperty("is_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLost { get; set; }

        /// <summary>
        /// spam score of the backlink
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [JsonProperty("backlink_spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BacklinkSpamScore { get; set; }

        /// <summary>
        /// backlink rank
        /// <br/>rank that the given backlink passes to the target
        /// <br/>rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// page rank of the referring page
        /// <br/>page_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("page_from_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageFromRank { get; set; }

        /// <summary>
        /// domain rank of the referring domain
        /// <br/>domain_from_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("domain_from_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomainFromRank { get; set; }

        /// <summary>
        /// platform types of the referring domain
        /// <br/>possible values: cms, blogs, ecommerce, message-boards, wikis, news, organization
        /// </summary>
        [JsonProperty("domain_from_platform_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DomainFromPlatformType { get; set; }

        /// <summary>
        /// indicates if the domain is IP
        /// <br/>if true, the domain functions as an IP address and does not have a domain name
        /// </summary>
        [JsonProperty("domain_from_is_ip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DomainFromIsIp { get; set; }

        /// <summary>
        /// IP address of the referring domain
        /// </summary>
        [JsonProperty("domain_from_ip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DomainFromIp { get; set; }

        /// <summary>
        /// ISO country code of the referring domain
        /// </summary>
        [JsonProperty("domain_from_country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DomainFromCountry { get; set; }

        /// <summary>
        /// number of external links found on the referring page
        /// </summary>
        [JsonProperty("page_from_external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageFromExternalLinks { get; set; }

        /// <summary>
        /// number of internal links found on the referring page
        /// </summary>
        [JsonProperty("page_from_internal_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageFromInternalLinks { get; set; }

        /// <summary>
        /// size of the referring page, in bytes
        /// <br/>example:
        /// <br/>63357
        /// </summary>
        [JsonProperty("page_from_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageFromSize { get; set; }

        /// <summary>
        /// character encoding of the referring page
        /// <br/>example:
        /// <br/>utf-8
        /// </summary>
        [JsonProperty("page_from_encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageFromEncoding { get; set; }

        /// <summary>
        /// language of the referring page
        /// <br/>in ISO 639-1 format
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("page_from_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageFromLanguage { get; set; }

        /// <summary>
        /// title of the referring page
        /// </summary>
        [JsonProperty("page_from_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageFromTitle { get; set; }

        /// <summary>
        /// HTTP status code returned by the referring page
        /// <br/>example:
        /// <br/>200
        /// </summary>
        [JsonProperty("page_from_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageFromStatusCode { get; set; }

        /// <summary>
        /// date and time when our crawler found the backlink for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("first_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// previous to the most recent date when our crawler visited the backlink
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("prev_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PrevSeen { get; set; }

        /// <summary>
        /// most recent date when our crawler visited the backlink
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastSeen { get; set; }

        /// <summary>
        /// link type
        /// <br/>possible values:
        /// <br/>anchor, image, meta, canonical, alternate, redirect
        /// </summary>
        [JsonProperty("item_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        /// <summary>
        /// link attributes of the referring links
        /// <br/>example:
        /// <br/>nofollow
        /// </summary>
        [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Attributes { get; set; }

        /// <summary>
        /// indicates whether the backlink is dofollow
        /// <br/>if false, the backlink is nofollow
        /// </summary>
        [JsonProperty("dofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dofollow { get; set; }

        /// <summary>
        /// indicates whether the backlink was present on the referring page when our crawler first visited it
        /// </summary>
        [JsonProperty("original", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Original { get; set; }

        /// <summary>
        /// alternative text of the image
        /// <br/>this field will be null if backlink type is not image
        /// </summary>
        [JsonProperty("alt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        /// <summary>
        /// URL of the image
        /// <br/>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available)
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// anchor text of the backlink
        /// </summary>
        [JsonProperty("anchor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Anchor { get; set; }

        /// <summary>
        /// snippet before the anchor text
        /// </summary>
        [JsonProperty("text_pre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TextPre { get; set; }

        /// <summary>
        /// snippet after the anchor text
        /// </summary>
        [JsonProperty("text_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TextPost { get; set; }

        /// <summary>
        /// indicates semantic element in HTML where the backlink is found
        /// <br/>you can get the full list of semantic elements here
        /// <br/>examples:
        /// <br/>article, section, summary
        /// </summary>
        [JsonProperty("semantic_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SemanticLocation { get; set; }

        /// <summary>
        /// number of identical backlinks found on the referring page
        /// </summary>
        [JsonProperty("links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksCount { get; set; }

        /// <summary>
        /// indicates total number of backlinks from this domain
        /// <br/>for example, if mode is set to one_per_domain, this field will indicate the total number of backlinks coming from this domain
        /// </summary>
        [JsonProperty("group_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// indicates whether the backlink is broken
        /// <br/>if true, the backlink is pointing to a page responding with a 4xx or 5xx status code
        /// </summary>
        [JsonProperty("is_broken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBroken { get; set; }

        /// <summary>
        /// status code of the referenced page
        /// <br/>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to
        /// <br/>example:
        /// <br/>200
        /// </summary>
        [JsonProperty("url_to_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UrlToStatusCode { get; set; }

        /// <summary>
        /// spam score of the referenced page
        /// <br/>if the value is null, our crawler hasn’t yet visited the webpage the link is pointing to;
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [JsonProperty("url_to_spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UrlToSpamScore { get; set; }

        /// <summary>
        /// target url of the redirect
        /// <br/>target page the redirect is pointing to
        /// </summary>
        [JsonProperty("url_to_redirect_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UrlToRedirectTarget { get; set; }

        /// <summary>
        /// number of keywords for which the page is ranked in top search results
        /// </summary>
        [JsonProperty("ranked_keywords_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RankedKeywordsInfo RankedKeywordsInfo { get; set; }

        /// <summary>
        /// indicates whether the backlink is an indirect link
        /// <br/>if true, the backlink is an indirect link pointing to a page that either redirects to url_to, or points to a canonical page
        /// </summary>
        [JsonProperty("is_indirect_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIndirectLink { get; set; }

        /// <summary>
        /// indirect link path
        /// <br/>indicates a URL or a sequence of URLs that lead to url_to
        /// </summary>
        [JsonProperty("indirect_link_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BacklinksRedirectInfo> IndirectLinkPath { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}