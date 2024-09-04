namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AnchorLinkElementItem : BaseOnPageLinkItemInfo
    {
        /// <summary>
        /// link attribute added to external link
        /// <br/>indicates link attributes added to the link_to on the page_from
        /// <br/>example:
        /// <br/>["ugc","noopener"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_attribute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> LinkAttribute { get; set; }

        /// <summary>
        /// anchor text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// status code of the referenced page
        /// <br/>status code of the page to which the link is pointing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_to_status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageToStatusCode { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}