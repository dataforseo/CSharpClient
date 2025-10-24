using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOverviewElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// title of the carousel item
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// content within the item
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// images of the element
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeImagesElementInfo> Images { get; set; }

        /// <summary>
        /// references relevant to the element
        /// <br/>includes references to webpages that were used to generate the ai_overview_element
        /// </summary>
        [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeAiOverviewReferenceInfo> References { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}