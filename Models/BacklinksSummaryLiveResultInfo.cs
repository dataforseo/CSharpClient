using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksSummaryLiveResultInfo 
    {

        /// <summary>
        /// target in a POST array
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// date and time when our crawler found the backlink for the target for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("first_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// date and time when the backlink was lost
        /// <br/>indicates the date and time when our crawler visited the target and it responded with a 4xx or 5xx status code or when its last backlink was removed
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("lost_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LostDate { get; set; }

        /// <summary>
        /// target rank
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// indicates the number of backlinks
        /// </summary>
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// spam score of the backlinks
        /// <br/>displays the total spam score of all backlinks pointing to the target domain, subdomain, or webpage;
        /// <br/>to learn more about how the metric is calculated, refer to this Help Center page
        /// </summary>
        [JsonProperty("backlinks_spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BacklinksSpamScore { get; set; }

        /// <summary>
        /// number of crawled pages for the target
        /// </summary>
        [JsonProperty("crawled_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CrawledPages { get; set; }

        /// <summary>
        /// information about the target
        /// </summary>
        [JsonProperty("info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TargetInfo Info { get; set; }

        /// <summary>
        /// number of internal links
        /// <br/>calculated as the sum of internal links on the pages of the specified target
        /// </summary>
        [JsonProperty("internal_links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? InternalLinksCount { get; set; }

        /// <summary>
        /// number of external links on the page
        /// <br/>calculated as the sum of external links on the pages of the specified target
        /// </summary>
        [JsonProperty("external_links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ExternalLinksCount { get; set; }

        /// <summary>
        /// number of broken backlinks
        /// <br/>number of broken backlinks pointing to the target
        /// </summary>
        [JsonProperty("broken_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrokenBacklinks { get; set; }

        /// <summary>
        /// number of broken pages
        /// <br/>number of pages on the target that respond with 4xx or 5xx status codes
        /// <br/>note that the number of broken pages includes pages on the target discovered by following external links, but it may also include pages discovered by following the target’s sitemap
        /// </summary>
        [JsonProperty("broken_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokenPages { get; set; }

        /// <summary>
        /// indicates the number of referring domains
        /// <br/>referring domains include subdomains that are counted as separate domains for this metric
        /// </summary>
        [JsonProperty("referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomains { get; set; }

        /// <summary>
        /// number of domains pointing at least one nofollow link to the target
        /// </summary>
        [JsonProperty("referring_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomainsNofollow { get; set; }

        /// <summary>
        /// indicates the number of referring main domains
        /// </summary>
        [JsonProperty("referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomains { get; set; }

        /// <summary>
        /// number of main domains pointing at least one nofollow link to the target
        /// </summary>
        [JsonProperty("referring_main_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring IP addresses
        /// <br/>number of IP addresses pointing to this page
        /// </summary>
        [JsonProperty("referring_ips", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringIps { get; set; }

        /// <summary>
        /// number of referring subnetworks
        /// </summary>
        [JsonProperty("referring_subnets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringSubnets { get; set; }

        /// <summary>
        /// indicates the number of pages pointing to the target
        /// </summary>
        [JsonProperty("referring_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPages { get; set; }

        /// <summary>
        /// top-level domains of the referring links
        /// <br/>contains top level domains and referring link count per each
        /// </summary>
        [JsonProperty("referring_links_tld", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksTld { get; set; }

        /// <summary>
        /// types of referring links
        /// <br/>indicates the types of the referring links and link count per each type
        /// <br/>possible values:
        /// <br/>anchor, image, link, meta, canonical, alternate, redirect
        /// </summary>
        [JsonProperty("referring_links_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksTypes { get; set; }

        /// <summary>
        /// link attributes of the referring links
        /// <br/>indicates link attributes of the referring links and link count per each attribute
        /// <br/>example values:
        /// <br/>nofollow, noopener, noreferrer, external, ugc, sponsored
        /// </summary>
        [JsonProperty("referring_links_attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksAttributes { get; set; }

        /// <summary>
        /// types of referring platforms
        /// <br/>indicates referring platform types and and link count per each platform
        /// <br/>possible values: cms, blogs, ecommerce, message-boards, wikis, news, organization
        /// </summary>
        [JsonProperty("referring_links_platform_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksPlatformTypes { get; set; }

        /// <summary>
        /// semantic locations of the referring links
        /// <br/>indicates semantic elements in HTML where the referring links are located and link count per each semantic location
        /// <br/>you can get the full list of semantic elements here
        /// <br/>example values:
        /// <br/>article, section, summary, ''
        /// </summary>
        [JsonProperty("referring_links_semantic_locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksSemanticLocations { get; set; }

        /// <summary>
        /// ISO country codes of the referring links
        /// <br/>indicates ISO country codes of the domains where the referring links are located and the link count per each country
        /// </summary>
        [JsonProperty("referring_links_countries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksCountries { get; set; }

        /// <summary>
        /// number of referring pages pointing at least one nofollow link to the target
        /// </summary>
        [JsonProperty("referring_pages_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPagesNofollow { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}