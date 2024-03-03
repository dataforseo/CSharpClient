namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PageTiming
    {
        /// <summary>
        /// Time To Interactive (TTI) metric
        /// <br/>the time it takes until the user can interact with a page (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_to_interactive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TimeToInteractive { get; set; }

        /// <summary>
        /// time to load resources
        /// <br/>the time it takes until the page and all of its subresources are downloaded (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dom_complete", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DomComplete { get; set; }

        /// <summary>
        /// Core Web Vitals metric measuring how fast the largest above-the-fold content element is displayed
        /// <br/>The amount of time (in milliseconds) to render the largest content element visible in the viewport, from when the user requests the URL. Learn more.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("largest_contentful_paint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? LargestContentfulPaint { get; set; }

        /// <summary>
        /// Core Web Vitals metric indicating the responsiveness of a page
        /// <br/>The time (in milliseconds) from when a user first interacts with your page to the time when the browser responds to that interaction. Learn more.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_input_delay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? FirstInputDelay { get; set; }

        /// <summary>
        /// time to connect to a server
        /// <br/>the time it takes until the connection with a server is established (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connection_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ConnectionTime { get; set; }

        /// <summary>
        /// time to establish a secure connection
        /// <br/>the time it takes until the secure connection with a server is established (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_to_secure_connection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TimeToSecureConnection { get; set; }

        /// <summary>
        /// time to send a request to a server
        /// <br/>the time it takes until the request to a server is sent (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_sent_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RequestSentTime { get; set; }

        /// <summary>
        /// time to first byte (TTFB) in milliseconds
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waiting_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? WaitingTime { get; set; }

        /// <summary>
        /// time it takes for a browser to receive a response (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DownloadTime { get; set; }

        /// <summary>
        /// total time it takes until a browser receives a complete response from a server (in milliseconds)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DurationTime { get; set; }

        /// <summary>
        /// time to start downloading the HTML resource
        /// <br/>the amount of time the browser needs to start downloading a page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FetchStart { get; set; }

        /// <summary>
        /// time to complete downloading the HTML resource
        /// <br/>the amount of time the browser needs to complete downloading a page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_end", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FetchEnd { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}