using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleDomainWhoisOverviewLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// date and time of registration
        /// <br/>date and time (in the ISO 8601 format) when the domain was first registered
        /// <br/>example:
        /// <br/>'1997-03-29 03:00:00 +00:00'
        /// </summary>
        [JsonProperty("created_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain entry was changed
        /// <br/>date and time (in the ISO 8601 format) when the domain entry was last modified
        /// <br/>example:
        /// <br/>'2021-01-14 08:36:28 +00:00'
        /// </summary>
        [JsonProperty("changed_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChangedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain will expire
        /// <br/>date and time (in the ISO 8601 format) when the domain is due to expire
        /// <br/>example:
        /// <br/>'2022-11-26 17:21:23 +00:00'
        /// </summary>
        [JsonProperty("expiration_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationDatetime { get; set; }

        /// <summary>
        /// date and time when the domain was updated
        /// <br/>date and time (in the ISO 8601 format) when the domain was last updated
        /// <br/>example:
        /// <br/>'2021-01-29 13:59:38 +00:00'
        /// </summary>
        [JsonProperty("updated_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedDatetime { get; set; }

        /// <summary>
        /// date and time when our crawler found the domain for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>'2019-11-15 12:57:46 +00:00'
        /// </summary>
        [JsonProperty("first_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// extensive provisioning protocol status codes
        /// <br/>the status of a domain name registration as defined by ICANN
        /// </summary>
        [JsonProperty("epp_status_codes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> EppStatusCodes { get; set; }

        /// <summary>
        /// top-level domain
        /// <br/>top-level domain in the DNS root zone
        /// </summary>
        [JsonProperty("tld", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tld { get; set; }

        /// <summary>
        /// domain registration status
        /// <br/>if false, the domain name registration has expired
        /// <br/>Note: expired domains will remain in the database for only a short period of time
        /// </summary>
        [JsonProperty("registered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Registered { get; set; }

        /// <summary>
        /// domain registrar
        /// <br/>if null, the domain registrar is unknown
        /// <br/>example:
        /// <br/>NameCheap, Inc.
        /// </summary>
        [JsonProperty("registrar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Registrar { get; set; }

        /// <summary>
        /// ranking data relevant to the specified domain
        /// </summary>
        [JsonProperty("metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, DataforseoLabsMetricsInfo> Metrics { get; set; }

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