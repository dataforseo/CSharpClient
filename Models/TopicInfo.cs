namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TopicInfo
    {
        /// <summary>
        /// meta title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HTitle { get; set; }

        /// <summary>
        /// main title of the block
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainTitle { get; set; }

        /// <summary>
        /// content author name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("author", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// content language
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// HTML level
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Level { get; set; }

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