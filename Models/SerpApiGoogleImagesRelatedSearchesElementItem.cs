using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleImagesRelatedSearchesElementItem  : BaseSerpApiGoogleImagesElementItem 
    {

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// items of the element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Items { get; set; }

        /// <summary>
        /// rectangle parameters
        /// <br/>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP
        /// <br/>note: calculate_rectangles parameter is not yet available when setting tasks for this search engine type, that’s why rectangle always equals null
        /// </summary>
        [JsonProperty("rectangle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RectangleInfo Rectangle { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}