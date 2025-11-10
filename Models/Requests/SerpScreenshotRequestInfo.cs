using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpScreenshotRequestInfo 
    {

        /// <summary>
        /// task identifier
        /// <br/>required field
        /// <br/>unique identifier of the associated task in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time
        /// </summary>
        [JsonProperty("task_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// browser resolution preset
        /// <br/>optional field
        /// <br/>browser preset associated with a certain device type
        /// <br/>can take the following values: desktop, tablet, mobile
        /// <br/>note: by default, browser preset corresponds to the device type specified in the POST request
        /// </summary>
        [JsonProperty("browser_preset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// width of the browser resolution
        /// <br/>optional field
        /// <br/>can be specified in the following range: 240-9999
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// height of the browser resolution
        /// <br/>optional field
        /// <br/>can be specified in the following range: 240-9999
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser scale factor
        /// <br/>optional field
        /// <br/>can be specified in the following range: 0.5-3
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// number of SERP pages
        /// <br/>optional field
        /// <br/>if depth in the corresponding Task POST request exceeds 10 results (or 1 SERP page), specify the number of SERP pages to screenshot;
        /// <br/>default value: 1
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}