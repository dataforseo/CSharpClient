namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResourceMetaInfo
    {
        /// <summary>
        /// content of the image alt attribute
        /// <br/>the value depends on the resource_type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alternative_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AlternativeText { get; set; }

        /// <summary>
        /// title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// original image width in px
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OriginalWidth { get; set; }

        /// <summary>
        /// original image height in px
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_height", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OriginalHeight { get; set; }

        /// <summary>
        /// image width in px
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Width { get; set; }

        /// <summary>
        /// image height in px
        /// </summary>
        [Newtonsoft.Json.JsonProperty("height", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Height { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}