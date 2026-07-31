using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksBulkReferringDomainsLiveItem 
    {

        /// <summary>
        /// domain, subdomain or webpage from a POST array
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// number of referring domains pointing to the <c>target</c>
        /// <br/>note that we calculate main domains (root domains, like <c>example.com</c>) and their subdomains (e.g. <c>blog.example.com</c>) separately for this metric
        /// </summary>
        [JsonProperty("referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomains { get; set; }

        /// <summary>
        /// number of domains pointing at least one nofollow link to the <c>target</c>
        /// </summary>
        [JsonProperty("referring_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringDomainsNofollow { get; set; }

        /// <summary>
        /// number of referring main domains pointing to the <c>target</c>
        /// <br/>the number of primary (root) domains referring to your target
        /// </summary>
        [JsonProperty("referring_main_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomains { get; set; }

        /// <summary>
        /// number of main domains pointing at least one nofollow link to the <c>target</c>
        /// </summary>
        [JsonProperty("referring_main_domains_nofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReferringMainDomainsNofollow { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}