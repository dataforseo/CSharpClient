using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsKnowledgeGraphPartItemElementItem  : BaseDataforseoLabsKnowledgeGraphElementItem 
    {

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// google defined data attribute ID
        /// <br/>example:
        /// <br/>kc:/common/topic:social media presence
        /// </summary>
        [JsonProperty("data_attrid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataAttrid { get; set; }

        /// <summary>
        /// row content
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// sitelinks
        /// <br/>the links shown below some of Google’s search results
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LinkElement> Links { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}