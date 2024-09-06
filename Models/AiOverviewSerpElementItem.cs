namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AiOverviewSerpElementItem : BaseSerpElementItem
    {
        /// <summary>
        /// indicates whether the element is loaded asynchronically
        /// <br/>if true, the ai_overview element is loaded asynchronically;
        /// <br/>if false, the ai_overview element is loaded from cache;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asynchronous_ai_overview", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AsynchronousAiOverview { get; set; }

        /// <summary>
        /// contains arrays of specific images
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AiOverviewElement> Items { get; set; }

        /// <summary>
        /// additional references relevant to the item
        /// <br/>includes references to webpages that may have been used to generate the ai_overview
        /// </summary>
        [Newtonsoft.Json.JsonProperty("references", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AiOverviewReference> References { get; set; }

        /// <summary>
        /// rectangle parameters
        /// <br/>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
        /// <br/>equals null if calculate_rectangles in the POST request is not set to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rectangle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Rectangle Rectangle { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}