namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TargetInfo
    {
        /// <summary>
        /// server
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// content management system
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cms { get; set; }

        /// <summary>
        /// platform type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PlatformType { get; set; }

        /// <summary>
        /// IP address of the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// country code that the target domain is determined to belong to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// indicates if the target is IP
        /// <br/>if true, the domain, subdomain or webpage functions as an IP address and does not have a domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_ip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsIp { get; set; }

        /// <summary>
        /// spam score of the target
        /// <br/>if the target is a domain/subdomain, this fields indicates the average spam score of all pages of that domain/subdomain;
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_spam_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TargetSpamScore { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}