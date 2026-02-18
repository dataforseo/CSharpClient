using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiKnowledgeGraphAiOverviewItemElementItem  : BaseSerpApiKnowledgeGraphElementItem 
    {

        /// <summary>
        /// indicates whether the element is loaded asynchronously
        /// <br/>if true, the ai_overview element is loaded asynchronously;
        /// <br/>if false, the ai_overview element is loaded from cache;
        /// <br/>to obtain the content of ai_overview elements, use the load_async_ai_overview parameter in the POST request
        /// </summary>
        [JsonProperty("asynchronous_ai_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsynchronousAiOverview { get; set; }

        /// <summary>
        /// contains results featured in the ‘hotels_pack’ element of SERP
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseSerpApiAiOverviewElementItem> Items { get; set; }

        /// <summary>
        /// additional references relevant to the item
        /// <br/>includes references to webpages that may have been used to generate the ai_overview
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