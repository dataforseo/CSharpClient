using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksDomainIntersection 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// domain that links to the corresponding target from the POST array
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// rank referred to the <c>target</c> from the POST array
        /// <br/>indicates the rank that the referring domain (<c>target</c> above) refers to your target from the POST array;
        /// <br/><c>rank</c> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in <see href="https://dataforseo.com/help-center/what_is_rank_in_backlinks_api">this help center article</see>
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// indicates the number of backlinks
        /// </summary>
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// date and time when our crawler found the backlink from this <c>target</c> for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("first_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// date and time when the last backlink from this <c>target</c> was lost
        /// <br/>indicates the date and time when our crawler visited the page and it responded with 4xx or 5xx status code or the last backlink was removed
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("lost_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LostDate { get; set; }

        /// <summary>
        /// average spam score of the backlinks pointing to the <c>target</c>
        /// <br/>learn more about how the metric is calculated on <see href="https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated">this help center page</see>
        /// </summary>
        [JsonProperty("backlinks_spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BacklinksSpamScore { get; set; }

        /// <summary>
        /// number of broken backlinks
        /// </summary>
        [JsonProperty("broken_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrokenBacklinks { get; set; }

        /// <summary>
        /// number of broken pages
        /// </summary>
        [JsonProperty("broken_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokenPages { get; set; }

        /// <summary>
        /// number of referring domains
        /// </summary>
        [JsonProperty("referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomains { get; set; }

        /// <summary>
        /// number of domains pointing at least one nofollow link to the corresponding target
        /// </summary>
        [JsonProperty("referring_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring main domains
        /// </summary>
        [JsonProperty("referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomains { get; set; }

        /// <summary>
        /// number of main domains pointing at least one nofollow link to the <c>target</c>
        /// </summary>
        [JsonProperty("referring_main_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring IP addresses
        /// </summary>
        [JsonProperty("referring_ips", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringIps { get; set; }

        /// <summary>
        /// number of referring subnetworks
        /// </summary>
        [JsonProperty("referring_subnets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringSubnets { get; set; }

        /// <summary>
        /// indicates the number of pages pointing to the <c>target</c>
        /// </summary>
        [JsonProperty("referring_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPages { get; set; }

        /// <summary>
        /// number of referring pages pointing at least one nofollow link to the <c>target</c>
        /// </summary>
        [JsonProperty("referring_pages_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPagesNofollow { get; set; }

        /// <summary>
        /// top level domains of the referring links
        /// <br/>contains top-level domains and referring link count per each
        /// </summary>
        [JsonProperty("referring_links_tld", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, int?> ReferringLinksTld { get; set; }

        /// <summary>
        /// types of the referring links
        /// <br/>indicates the types of referring links and link count per each type
        /// <br/>possible values:
        /// <br/><c>anchor</c>, <c>image</c>, <c>link</c>, <c>meta</c>, <c>canonical</c>, <c>alternate</c>, <c>redirect</c>
        /// </summary>
        [JsonProperty("referring_links_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, int?> ReferringLinksTypes { get; set; }

        /// <summary>
        /// link attributes of the referring links
        /// <br/>indicates link attributes of the referring links and the link count per each attribute
        /// </summary>
        [JsonProperty("referring_links_attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, int?> ReferringLinksAttributes { get; set; }

        /// <summary>
        /// types of referring platforms
        /// <br/>indicates referring platform types and link count per each platform
        /// <br/>possible values: <c>cms</c>, <c>blogs</c>, <c>ecommerce</c>, <c>message-boards</c>, <c>wikis</c>, <c>news</c>, <c>organization</c>
        /// </summary>
        [JsonProperty("referring_links_platform_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, int?> ReferringLinksPlatformTypes { get; set; }

        /// <summary>
        /// semantic locations of the referring links
        /// <br/>indicates semantic elements in HTML where the referring links are located and the link count per each semantic location
        /// <br/>you can get the full list of semantic elements <see href="https://www.w3schools.com/html/html5_semantic_elements.asp">here</see>
        /// </summary>
        [JsonProperty("referring_links_semantic_locations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, int?> ReferringLinksSemanticLocations { get; set; }

        /// <summary>
        /// ISO country codes of the referring links
        /// <br/>indicates ISO country codes of the domains where the referring links are located and the link count per each country
        /// </summary>
        [JsonProperty("referring_links_countries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object ReferringLinksCountries { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}