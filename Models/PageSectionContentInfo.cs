namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PageSectionContentInfo
    {
        /// <summary>
        /// primary content on the page
        /// <br/>you can find more information about content priority calculation in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primary_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentItemInfo> PrimaryContent { get; set; }

        /// <summary>
        /// secondary content on the page
        /// <br/>you can find more information about content priority calculation in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secondary_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentItemInfo> SecondaryContent { get; set; }

        /// <summary>
        /// content of the table on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("table_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TableContent> TableContent { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}