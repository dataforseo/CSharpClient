namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StylesheetResourceElementItem : BaseOnPageResourceItemInfo
    {
        /// <summary>
        /// resource properties
        /// <br/>the value depends on the resource_type
        /// <br/>note that if you do not indicate a url when setting a task, resource’s meta is returned based on the data from the page where our crawler first saw the resource;
        /// <br/>to obtain resource’s meta from a particular url, specify that URL when setting a task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ResourceMetaInfo Meta { get; set; }

        /// <summary>
        /// resource fething time range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_timing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FetchTiming FetchTiming { get; set; }

        /// <summary>
        /// indicates the expected type of resource
        /// <br/>for example, if "resource_type": "broken", accept_type will indicate the type of the broken resource
        /// <br/>possible values:
        /// <br/>any, none, image, sitemap, robots, script, stylesheet, redirect, html, text, other, font
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcceptType { get; set; }

        /// <summary>
        /// resource initiator
        /// </summary>
        [Newtonsoft.Json.JsonProperty("initiator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Initiator { get; set; }

        /// <summary>
        /// total time it takes until a browser receives a complete response from a server (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DurationTime { get; set; }

        /// <summary>
        /// time to start downloading the resource
        /// <br/>the amount of time the browser needs to start downloading a resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FetchStart { get; set; }

        /// <summary>
        /// time to complete downloading the resource
        /// <br/>the amount of time the browser needs to complete downloading a resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_end", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FetchEnd { get; set; }

        /// <summary>
        /// indicates whether the resource blocks rendering
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_render_blocking", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsRenderBlocking { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}