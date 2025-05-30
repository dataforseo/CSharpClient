using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class StreamingQualityElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// label of the quality element
        /// </summary>
        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// video width in pixels
        /// </summary>
        [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// video height in pixels
        /// </summary>
        [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        /// bit rate of the video
        /// </summary>
        [JsonProperty("bitrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Bitrate { get; set; }

        /// <summary>
        /// media type of the video
        /// </summary>
        [JsonProperty("mime_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MimeType { get; set; }

        /// <summary>
        /// frame rate of the video
        /// </summary>
        [JsonProperty("fps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Fps { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}