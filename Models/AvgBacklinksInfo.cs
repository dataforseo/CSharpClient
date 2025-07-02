using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AvgBacklinksInfo 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// average number of backlinks
        /// </summary>
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Backlinks { get; set; }

        /// <summary>
        /// average number of dofollow links
        /// </summary>
        [JsonProperty("dofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Dofollow { get; set; }

        /// <summary>
        /// average number of referring pages
        /// </summary>
        [JsonProperty("referring_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ReferringPages { get; set; }

        /// <summary>
        /// average number of referring domains
        /// </summary>
        [JsonProperty("referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ReferringDomains { get; set; }

        /// <summary>
        /// average number of referring main domains
        /// </summary>
        [JsonProperty("referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ReferringMainDomains { get; set; }

        /// <summary>
        /// average rank
        /// <br/>learn more about the metric and its calculation formula in this help center article
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Rank { get; set; }

        /// <summary>
        /// average main domain rank
        /// <br/>learn more about the metric and its calculation formula in this help center article
        /// </summary>
        [JsonProperty("main_domain_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? MainDomainRank { get; set; }

        /// <summary>
        /// date and time when SERP data was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}