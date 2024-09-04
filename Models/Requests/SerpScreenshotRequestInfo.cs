using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpScreenshotRequestInfo
    {
        /// <summary>
        /// task identifier
        /// <br/>required field
        /// <br/>unique identifier of the associated task in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// browser resolution preset
        /// <br/>optional field
        /// <br/>browser preset associated with a certain device type
        /// <br/>can take the following values: desktop, tablet, mobile
        /// <br/>note: by default, browser preset corresponds to the device type specified in the POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_preset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// width of the browser resolution
        /// <br/>optional field
        /// <br/>can be specified in the following range: 240-9999
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// height of the browser resolution
        /// <br/>optional field
        /// <br/>can be specified in the following range: 240-9999
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_height", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser scale factor
        /// <br/>optional field
        /// <br/>can be specified in the following range: 0.5-3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_scale_factor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BrowserScreenScaleFactor { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}