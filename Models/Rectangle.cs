namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rectangle
    {
        /// <summary>
        /// x-axis coordinate
        /// <br/>x-axis coordinate of the top-left corner of the result’s snippet, where top-left corner of the screen is the origin
        /// </summary>
        [Newtonsoft.Json.JsonProperty("x", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? X { get; set; }

        /// <summary>
        /// y-axis coordinate
        /// <br/>y-axis coordinate of the top-left corner of the result’s snippet, where top-left corner of the screen is the origin
        /// </summary>
        [Newtonsoft.Json.JsonProperty("y", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Y { get; set; }

        /// <summary>
        /// width of the element in pixels
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// height of the element in pixels
        /// </summary>
        [Newtonsoft.Json.JsonProperty("height", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Height { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}