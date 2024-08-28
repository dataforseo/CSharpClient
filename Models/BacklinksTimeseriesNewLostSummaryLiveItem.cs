namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksTimeseriesNewLostSummaryLiveItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date and time when the data for the target was stored
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// number of new backlinks
        /// <br/>number of new backlinks pointing to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? NewBacklinks { get; set; }

        /// <summary>
        /// number of lost backlinks
        /// <br/>number of lost backlinks of the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lost_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LostBacklinks { get; set; }

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
        /// number of new referring main domains
        /// <br/>number of new referring main domains pointing to the target
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_referring_main_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? NewReferringMainDomains { get; set; }

        /// <summary>
        /// number of lost referring main domains
        /// <br/>number of lost referring main domains of the target
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