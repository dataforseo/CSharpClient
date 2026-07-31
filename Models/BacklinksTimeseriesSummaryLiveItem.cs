using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksTimeseriesSummaryLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date and time when the data for the target was stored
        /// <br/>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// <c>target</c> rank for the given <c>date</c>
        /// <br/>learn more about the metric and how it is calculated in <see href="https://dataforseo.com/help-center/what_is_rank_in_backlinks_api">this help center article</see>
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// number of backlinks for the given <c>date</c>
        /// </summary>
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }

        /// <summary>
        /// number of nofollow backlinks for the given <c>date</c>
        /// </summary>
        [JsonProperty("backlinks_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BacklinksNofollow { get; set; }

        /// <summary>
        /// number of pages pointing to <c>target</c> for the given <c>date</c>
        /// </summary>
        [JsonProperty("referring_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPages { get; set; }

        /// <summary>
        /// number of referring pages pointing at least one nofollow link to the <c>target</c> for the given <c>date</c>
        /// </summary>
        [JsonProperty("referring_pages_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringPagesNofollow { get; set; }

        /// <summary>
        /// number of referring domains for the given <c>date</c>
        /// <br/>referring domains include subdomains that are counted as separate domains for this metric
        /// </summary>
        [JsonProperty("referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomains { get; set; }

        /// <summary>
        /// number of domains pointing at least one nofollow link to the <c>target</c> for the given <c>date</c>
        /// </summary>
        [JsonProperty("referring_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring main domains for the given <c>date</c>
        /// </summary>
        [JsonProperty("referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomains { get; set; }

        /// <summary>
        /// number of main domains pointing at least one nofollow link to the <c>target</c> for the given <c>date</c>
        /// </summary>
        [JsonProperty("referring_main_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring IP addresses for the given <c>date</c>
        /// <br/>number of IP addresses pointing to this page
        /// </summary>
        [JsonProperty("referring_ips", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringIps { get; set; }

        /// <summary>
        /// number of referring subnetworks for the given <c>date</c>
        /// </summary>
        [JsonProperty("referring_subnets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringSubnets { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}