using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PageTiming 
    {

        /// <summary>
        /// Time To Interactive (TTI) metric
        /// <br/>the time it takes until the user can interact with a page (in milliseconds)
        /// </summary>
        [JsonProperty("time_to_interactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeToInteractive { get; set; }

        /// <summary>
        /// time to load resources
        /// <br/>the time it takes until the page and all of its subresources are downloaded (in milliseconds)
        /// </summary>
        [JsonProperty("dom_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DomComplete { get; set; }

        /// <summary>
        /// Core Web Vitals metric measuring how fast the largest above-the-fold content element is displayed
        /// <br/>The amount of time (in milliseconds) to render the largest content element visible in the viewport, from when the user requests the URL. Learn more.
        /// </summary>
        [JsonProperty("largest_contentful_paint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? LargestContentfulPaint { get; set; }

        /// <summary>
        /// Core Web Vitals metric indicating the responsiveness of a page
        /// <br/>The time (in milliseconds) from when a user first interacts with your page to the time when the browser responds to that interaction. Learn more.
        /// </summary>
        [JsonProperty("first_input_delay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? FirstInputDelay { get; set; }

        /// <summary>
        /// time to connect to a server
        /// <br/>the time it takes until the connection with a server is established (in milliseconds)
        /// </summary>
        [JsonProperty("connection_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ConnectionTime { get; set; }

        /// <summary>
        /// time to establish a secure connection
        /// <br/>the time it takes until the secure connection with a server is established (in milliseconds)
        /// </summary>
        [JsonProperty("time_to_secure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeToSecureConnection { get; set; }

        /// <summary>
        /// time to send a request to a server
        /// <br/>the time it takes until the request to a server is sent (in milliseconds)
        /// </summary>
        [JsonProperty("request_sent_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RequestSentTime { get; set; }

        /// <summary>
        /// time to first byte (TTFB) in milliseconds
        /// </summary>
        [JsonProperty("waiting_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WaitingTime { get; set; }

        /// <summary>
        /// time it takes for a browser to receive a response (in milliseconds)
        /// </summary>
        [JsonProperty("download_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DownloadTime { get; set; }

        /// <summary>
        /// total time it takes until a browser receives a complete response from a server (in milliseconds)
        /// </summary>
        [JsonProperty("duration_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DurationTime { get; set; }

        /// <summary>
        /// time to start downloading the HTML resource
        /// <br/>the amount of time the browser needs to start downloading a page
        /// </summary>
        [JsonProperty("fetch_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FetchStart { get; set; }

        /// <summary>
        /// time to complete downloading the HTML resource
        /// <br/>the amount of time the browser needs to complete downloading a page
        /// </summary>
        [JsonProperty("fetch_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FetchEnd { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}