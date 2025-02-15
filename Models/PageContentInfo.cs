namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PageContentInfo
    {
        /// <summary>
        /// parsed content of the header
        /// </summary>
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PageSectionContentInfo Header { get; set; }

        /// <summary>
        /// content of the footer of the table
        /// </summary>
        [Newtonsoft.Json.JsonProperty("footer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PageSectionContentInfo Footer { get; set; }

        /// <summary>
        /// main topic on the page
        /// <br/>you can find more information about topic priority calculation in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TopicInfo> MainTopic { get; set; }

        /// <summary>
        /// secondary topic on the page
        /// <br/>you can find more information about topic priority calculation in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secondary_topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TopicInfo> SecondaryTopic { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}