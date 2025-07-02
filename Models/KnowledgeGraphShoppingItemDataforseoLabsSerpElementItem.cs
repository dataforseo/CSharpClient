using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KnowledgeGraphShoppingItemDataforseoLabsSerpElementItem  : BaseDataforseoLabsSerpElementItem 
    {

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// google defined data attribute ID
        /// <br/>example:
        /// <br/>action:listen_artist
        /// </summary>
        [JsonProperty("data_attrid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataAttrid { get; set; }

        /// <summary>
        /// additional items present in the element
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KnowledgeGraphShoppingElement> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}