using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageWaterfallItem 
    {

        /// <summary>
        /// URL of the page
        /// </summary>
        [JsonProperty("page_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageUrl { get; set; }

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

        /// <summary>
        /// resource-specific timing
        /// <br/>contains separate arrays with timing for each resource found on the page
        /// </summary>
        [JsonProperty("resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<WaterfallResourceInfo> Resources { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}