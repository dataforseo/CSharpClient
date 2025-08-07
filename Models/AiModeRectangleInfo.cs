using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiModeRectangleInfo 
    {

        /// <summary>
        /// x-axis coordinate
        /// <br/>x-axis coordinate of the top-left corner of the result’s snippet, where top-left corner of the screen is the origin
        /// </summary>
        [JsonProperty("x", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }

        /// <summary>
        /// y-axis coordinate
        /// <br/>y-axis coordinate of the top-left corner of the result’s snippet, where top-left corner of the screen is the origin
        /// </summary>
        [JsonProperty("y", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }

        /// <summary>
        /// width of the element in pixels
        /// </summary>
        [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        /// <summary>
        /// height of the element in pixels
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