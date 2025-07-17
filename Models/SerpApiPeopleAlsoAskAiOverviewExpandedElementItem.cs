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
        public IEnumerable<AiOverviewElement> Items { get; set; }

        /// <summary>
        /// references relevant to the element
        /// <br/>includes references to webpages that were used to generate the ai_overview_element
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