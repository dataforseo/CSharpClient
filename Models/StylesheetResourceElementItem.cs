using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class StylesheetResourceElementItem  : BaseOnPageResourceItemInfo 
    {

        /// <summary>
        /// resource properties
        /// <br/>the value depends on the resource_type
        /// <br/>note that if you do not indicate a url when setting a task, resource’s meta is returned based on the data from the page where our crawler first saw the resource;
        /// <br/>to obtain resource’s meta from a particular url, specify that URL when setting a task
        /// </summary>
        [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ResourceMetaInfo Meta { get; set; }

        /// <summary>
        /// resource fething time range
        /// </summary>
        [JsonProperty("fetch_timing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FetchTiming FetchTiming { get; set; }

        /// <summary>
        /// indicates the expected type of resource
        /// <br/>for example, if 'resource_type': 'broken', accept_type will indicate the type of the broken resource
        /// <br/>possible values:
        /// <br/>any, none, image, sitemap, robots, script, stylesheet, redirect, html, text, other, font
        /// </summary>
        [JsonProperty("accept_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptType { get; set; }

        /// <summary>
        /// resource initiator
        /// </summary>
        [JsonProperty("initiator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Initiator { get; set; }

        /// <summary>
        /// total time it takes until a browser receives a complete response from a server (in milliseconds)
        /// </summary>
        [JsonProperty("duration_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationTime { get; set; }

        /// <summary>
        /// time to start downloading the resource
        /// <br/>the amount of time the browser needs to start downloading a resource
        /// </summary>
        [JsonProperty("fetch_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchStart { get; set; }

        /// <summary>
        /// time to complete downloading the resource
        /// <br/>the amount of time the browser needs to complete downloading a resource
        /// </summary>
        [JsonProperty("fetch_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FetchEnd { get; set; }

        /// <summary>
        /// indicates whether the resource blocks rendering
        /// </summary>
        [JsonProperty("is_render_blocking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRenderBlocking { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}