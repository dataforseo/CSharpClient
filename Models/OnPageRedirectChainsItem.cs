namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageRedirectChainsItem
    {
        /// <summary>
        /// indicates if redirects in chain start and end at the same URL
        /// <br/>if true, the last URL from the chain redirects back to the original URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_redirect_loop", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsRedirectLoop { get; set; }

        /// <summary>
        /// contains links that form a chain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BaseOnPageLinkItemInfo> Chain { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}