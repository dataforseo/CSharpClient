using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsKnowledgeGraphExpandedItemElementItem  : BaseDataforseoLabsKnowledgeGraphElementItem 
    {

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// google defined data attribute ID
        /// <br/>example:
        /// <br/>kc:/local:place qa
        /// </summary>
        [JsonProperty("data_attrid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataAttrid { get; set; }

        /// <summary>
        /// expanded element
        /// </summary>
        [JsonProperty("expanded_element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExpandedElement { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}