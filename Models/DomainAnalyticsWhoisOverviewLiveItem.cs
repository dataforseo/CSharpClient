using Newtonsoft.Json;
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
        /// date and time of registrationdate and time (in the ISO 8601 format) when the domain was first registered example: '1997-03-29 03:00:00 +00:00'
        /// </summary>
        [JsonProperty("created_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain entry was changeddate and time (in the ISO 8601 format) when the domain entry was last modifiedexample: '2021-01-14 08:36:28 +00:00'
        /// </summary>
        [JsonProperty("changed_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ChangedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain will expiredate and time (in the ISO 8601 format) when the domain is due to expire example: '2022-11-26 17:21:23 +00:00'
        /// </summary>
        [JsonProperty("expiration_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationDatetime { get; set; }

        /// <summary>
        /// date and time when the domain was updateddate and time (in the ISO 8601 format) when the domain was last updated example: '2021-01-29 13:59:38 +00:00'
        /// </summary>
        [JsonProperty("updated_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedDatetime { get; set; }

        /// <summary>
        /// date and time when our crawler found the domain for the first timein the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example: '2019-11-15 12:57:46 +00:00'
        /// </summary>
        [JsonProperty("first_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// extensive provisioning protocol status codesthe status of a domain name registration as defined by ICANN
        /// </summary>
        [JsonProperty("epp_status_codes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> EppStatusCodes { get; set; }

        /// <summary>
        /// top-level domaintop-level domain in the DNS root zone
        /// </summary>
        [JsonProperty("tld", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tld { get; set; }

        /// <summary>
        /// domain registration statusif false, the domain name registration has expiredNote: expired domains will remain in the database for only a short period of time
        /// </summary>
        [JsonProperty("registered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Registered { get; set; }

        /// <summary>
        /// domain registrarif null, the domain registrar is unknownexample:NameCheap, Inc.
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