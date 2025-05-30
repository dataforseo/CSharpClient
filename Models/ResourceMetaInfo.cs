using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ResourceMetaInfo 
    {

        /// <summary>
        /// content of the image alt attribute
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
        public double? OriginalWidth { get; set; }

        /// <summary>
        /// original image height in px
        /// </summary>
        [JsonProperty("original_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OriginalHeight { get; set; }

        /// <summary>
        /// image width in px
        /// </summary>
        [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// image height in px
        /// </summary>
        [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}