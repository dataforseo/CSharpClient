using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TargetInfo 
    {

        /// <summary>
        /// server
        /// </summary>
        [JsonProperty("server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// content management system
        /// </summary>
        [JsonProperty("cms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cms { get; set; }

        /// <summary>
        /// platform type
        /// </summary>
        [JsonProperty("platform_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PlatformType { get; set; }

        /// <summary>
        /// IP address of the <c>target</c>
        /// </summary>
        [JsonProperty("ip_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// country code that the <c>target</c> domain is determined to belong to
        /// </summary>
        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// indicates if the <c>target</c> is IP
        /// <br/>if <c>true</c>, the domain, subdomain or webpage functions as an IP address and does not have a domain name
        /// </summary>
        [JsonProperty("is_ip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIp { get; set; }

        /// <summary>
        /// spam score of the <c>target</c>
        /// <br/>if the <c>target</c> is a domain/subdomain, this fields indicates the average spam score of all pages of that domain/subdomain;
        /// <br/>learn more about how the metric is calculated on <see href="https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated">this help center page</see>
        /// </summary>
        [JsonProperty("target_spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetSpamScore { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}