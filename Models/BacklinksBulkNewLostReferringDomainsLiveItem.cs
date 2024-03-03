namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksBulkNewLostReferringDomainsLiveItem
    {
        /// <summary>
        /// domain, subdomain or webpage from a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// number of new referring domains
        /// <br/>number of new referring domains pointing to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? NewReferringDomains { get; set; }

        /// <summary>
        /// number of lost referring domains
        /// <br/>number of lost referring domains of the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lost_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LostReferringDomains { get; set; }

        /// <summary>
        /// number of new referring main domains pointing to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_referring_main_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? NewReferringMainDomains { get; set; }

        /// <summary>
        /// number of lost referring main domains pointing to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lost_referring_main_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LostReferringMainDomains { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}