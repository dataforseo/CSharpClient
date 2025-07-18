using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksHistoryLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date and time when the data for the target was stored
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// domain rank on the given date
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// number of backlinks
        /// </summary>
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// number of new backlinks for the target
        /// <br/>data is provided based in a comparison with the previous period
        /// <br/>Note: this data is available from May 2021;
        /// <br/>if the date range specified in the POST request precedes May 2021, the field will equal 0
        /// </summary>
        [JsonProperty("new_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? NewBacklinks { get; set; }

        /// <summary>
        /// number of lost backlinks for the target
        /// <br/>data is provided based in a comparison with the previous period
        /// <br/>Note: this data is available from May 2021;
        /// <br/>if the date range specified in the POST request precedes May 2021, the field will equal 0
        /// </summary>
        [JsonProperty("lost_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? LostBacklinks { get; set; }

        /// <summary>
        /// number of new referring domains for the target
        /// <br/>data is provided based in a comparison with the previous period
        /// <br/>Note: this data is available from May 2021;
        /// <br/>if the date range specified in the POST request precedes May 2021, the field will equal 0
        /// </summary>
        [JsonProperty("new_referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? NewReferringDomains { get; set; }

        /// <summary>
        /// number of lost referring domains for the target
        /// <br/>data is provided based in a comparison with the previous period
        /// <br/>Note: this data is available from May 2021;
        /// <br/>if the date range specified in the POST request precedes May 2021, the field will equal 0
        /// </summary>
        [JsonProperty("lost_referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? LostReferringDomains { get; set; }

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
        /// <br/>number of pages that receive backlinks but respond with 4xx or 5xx status codes
        /// </summary>
        [JsonProperty("broken_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokenPages { get; set; }

        /// <summary>
        /// number of referring domains
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
        /// number of referring main domains
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
        /// number of pages pointing to the target
        /// </summary>
        [JsonProperty("referring_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPages { get; set; }

        /// <summary>
        /// number of referring pages pointing at least one nofollow link to the target
        /// </summary>
        [JsonProperty("referring_pages_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPagesNofollow { get; set; }

        /// <summary>
        /// top-level domains of the referring links
        /// <br/>contains top-level domains and referring link count per each
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
        /// <br/>examples:
        /// <br/>article, section, summary
        /// </summary>
        [JsonProperty("referring_links_semantic_locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksSemanticLocations { get; set; }

        /// <summary>
        /// ISO country codes of the referring links
        /// <br/>indicates ISO country codes of the domains where the referring links are located and the link count per each country
        /// </summary>
        [JsonProperty("referring_links_countries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ReferringLinksCountries { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}