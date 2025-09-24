using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("people_also_ask_expanded_element", typeof(SerpApiBingPeopleAlsoAskExpandedElementItem))]
    [JsonInheritance("people_also_ask_ai_overview_expanded_element", typeof(SerpApiBingPeopleAlsoAskAiOverviewExpandedElementItem))]

    public class BaseSerpApiBingPeopleAlsoAskExpandedElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}