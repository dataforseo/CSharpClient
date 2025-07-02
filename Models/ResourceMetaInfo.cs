using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ResourceMetaInfo 
    {

        /// <summary>
        /// content of the image alt attribute
        /// <br/>the value depends on the resource_type
        /// </summary>
        [JsonProperty("alternative_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AlternativeText { get; set; }

        /// <summary>
        /// title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// original image width in px
        /// </summary>
        [JsonProperty("original_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? OriginalWidth { get; set; }

        /// <summary>
        /// original image height in px
        /// </summary>
        [JsonProperty("original_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OriginalHeight { get; set; }

        /// <summary>
        /// image width in px
        /// </summary>
        [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        /// <summary>
        /// image height in px
        /// </summary>
        [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}