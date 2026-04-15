using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiPeopleAlsoAskAiOverviewExpandedElementItem  : BaseSerpApiPeopleAlsoAskExpandedElementItem 
    {

        /// <summary>
        /// contains arrays of elements available in the list
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseSerpApiAiOverviewElementItem> Items { get; set; }

        /// <summary>
        /// additional references relevant to the item
        /// <br/>includes references to webpages that may have been used to generate the ai_overview
        /// </summary>
        [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeAiOverviewReferenceInfo> References { get; set; }

        /// <summary>
        /// indicates whether the element is loaded asynchronously
        /// <br/>if true, the people_also_ask_ai_overview_expanded_element element is loaded asynchronously;
        /// <br/>if false, the people_also_ask_ai_overview_expanded_element element is loaded from cache
        /// </summary>
        [JsonProperty("asynchronous_ai_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsynchronousAiOverview { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}