using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ImageLinkElementItem  : BaseOnPageLinkItemInfo 
    {

        /// <summary>
        /// link attribute added to external link
        /// <br/>indicates link attributes added to the link_to on the page_from
        /// <br/>example:
        /// <br/>['ugc','noopener']
        /// </summary>
        [JsonProperty("link_attribute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> LinkAttribute { get; set; }

        /// <summary>
        /// anchor text
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// alternative text for the image
        /// </summary>
        [JsonProperty("image_alt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageAlt { get; set; }

        /// <summary>
        /// url of the image
        /// </summary>
        [JsonProperty("image_src", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSrc { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}