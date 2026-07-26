using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsWhoisOverviewLiveItem 
    {

        /// <summary>
        /// domain name
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// date and time of registration
        /// <br/>date and time (in the <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601 format</see>) when the domain was first registered 
        /// <br/>example: 
        /// <br/><c>'1997-03-29 03:00:00 +00:00'</c>
        /// </summary>
        [JsonProperty("created_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain entry was changed
        /// <br/>date and time (in the <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601 format</see>) when the domain entry was last modified
        /// <br/>example: 
        /// <br/><c>'2021-01-14 08:36:28 +00:00'</c>
        /// </summary>
        [JsonProperty("changed_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChangedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain will expire
        /// <br/>date and time (in the <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601 format</see>) when the domain is due to expire 
        /// <br/>example: 
        /// <br/><c>'2022-11-26 17:21:23 +00:00'</c>
        /// </summary>
        [JsonProperty("expiration_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationDatetime { get; set; }

        /// <summary>
        /// date and time when the domain was updated
        /// <br/>date and time (in the <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601 format</see>) when the domain was last updated 
        /// <br/>example: 
        /// <br/><c>'2021-01-29 13:59:38 +00:00'</c>
        /// </summary>
        [JsonProperty("updated_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedDatetime { get; set; }

        /// <summary>
        /// date and time when our crawler found the domain for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example: 
        /// <br/><c>'2019-11-15 12:57:46 +00:00'</c>
        /// </summary>
        [JsonProperty("first_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// extensive provisioning protocol status codes
        /// <br/>the status of a domain name registration <see href="https://www.icann.org/resources/pages/epp-status-codes-2014-06-16-en">as defined by ICANN</see>
        /// </summary>
        [JsonProperty("epp_status_codes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> EppStatusCodes { get; set; }

        /// <summary>
        /// top-level domain
        /// <br/>top-level domain in the <see href="https://www.iana.org/domains/root/db">DNS root zone</see>
        /// </summary>
        [JsonProperty("tld", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tld { get; set; }

        /// <summary>
        /// domain registration status
        /// <br/>if <c>false</c>, the domain name registration has expired
        /// <br/>Note: expired domains will remain in the database for only a short period of time
        /// </summary>
        [JsonProperty("registered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Registered { get; set; }

        /// <summary>
        /// domain registrar
        /// <br/>if <c>null</c>, the domain registrar is unknown
        /// <br/>example:
        /// <br/><c>NameCheap, Inc.</c>
        /// </summary>
        [JsonProperty("registrar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Registrar { get; set; }

        /// <summary>
        /// ranking data relevant to the specified domain
        /// </summary>
        [JsonProperty("metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MetricsBundleInfo Metrics { get; set; }

        /// <summary>
        /// backlink data for the returned domain
        /// </summary>
        [JsonProperty("backlinks_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BacklinksInfo BacklinksInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}