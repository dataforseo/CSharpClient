namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsGoogleDomainWhoisOverviewLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// date and time of registration
        /// <br/>date and time (in the ISO 8601 format) when the domain was first registered
        /// <br/>example:
        /// <br/>"1997-03-29 03:00:00 +00:00"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain entry was changed
        /// <br/>date and time (in the ISO 8601 format) when the domain entry was last modified
        /// <br/>example:
        /// <br/>"2021-01-14 08:36:28 +00:00"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("changed_datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChangedDatetime { get; set; }

        /// <summary>
        /// date and time when the domain will expire
        /// <br/>date and time (in the ISO 8601 format) when the domain is due to expire
        /// <br/>example:
        /// <br/>"2022-11-26 17:21:23 +00:00"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiration_datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExpirationDatetime { get; set; }

        /// <summary>
        /// date and time when the domain was updated
        /// <br/>date and time (in the ISO 8601 format) when the domain was last updated
        /// <br/>example:
        /// <br/>"2021-01-29 13:59:38 +00:00"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updated_datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UpdatedDatetime { get; set; }

        /// <summary>
        /// date and time when our crawler found the domain for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>"2019-11-15 12:57:46 +00:00"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_seen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// extensive provisioning protocol status codes
        /// <br/>the status of a domain name registration as defined by ICANN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("epp_status_codes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> EppStatusCodes { get; set; }

        /// <summary>
        /// top-level domain
        /// <br/>top-level domain in the DNS root zone
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tld", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tld { get; set; }

        /// <summary>
        /// domain registration status
        /// <br/>if false, the domain name registration has expired
        /// <br/>Note: expired domains will remain in the database for only a short period of time
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Registered { get; set; }

        /// <summary>
        /// domain registrar
        /// <br/>if null, the domain registrar is unknown
        /// <br/>example:
        /// <br/>NameCheap, Inc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registrar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Registrar { get; set; }

        /// <summary>
        /// ranking data relevant to the specified domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, DataforseoLabsMetricsInfo> Metrics { get; set; }

        /// <summary>
        /// backlink data for the returned domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BacklinksInfo BacklinksInfo { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}