using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiAiOverviewElementItem  : BaseSerpApiAiOverviewElementItem 
    {

        /// <summary>
        /// title of a given link element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// reference text
        /// <br/>text snippet from the page that was used to generate the ai_overview_element
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// text of the component in the markdwon format
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// sitelinks
        /// <br/>the links shown below some of Google’s search results
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LinkElement> Links { get; set; }

        /// <summary>
        /// images of the element
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeImagesElement> Images { get; set; }

        /// <summary>
        /// additional references relevant to the item
        /// <br/>includes references to webpages that may have been used to generate the product_considerations_ai_overview_expanded_element
        /// </summary>
        [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiAiOverviewReferenceInfo> References { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}