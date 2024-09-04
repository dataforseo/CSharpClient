namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SslInfo
    {
        /// <summary>
        /// ssl certificate validity
        /// <br/>indicates whether the ssl certificate detected on a website is not expired, suspended, revoked or invalid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_certificate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ValidCertificate { get; set; }

        /// <summary>
        /// ssl certificate authority
        /// <br/>the entity that issued the detected ssl certificate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_issuer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CertificateIssuer { get; set; }

        /// <summary>
        /// ssl certificate subject
        /// <br/>the entity associated with the public key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_subject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CertificateSubject { get; set; }

        /// <summary>
        /// ssl certificate version
        /// <br/>indicates the version of X.509 used by an ssl certificate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CertificateVersion { get; set; }

        /// <summary>
        /// ssl certificate hash
        /// <br/>the version of the ssl certificate’s hash function
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_hash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CertificateHash { get; set; }

        /// <summary>
        /// ssl certificate expiration date
        /// <br/>the date and time when the ssl certificate expires
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_expiration_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CertificateExpirationDate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}