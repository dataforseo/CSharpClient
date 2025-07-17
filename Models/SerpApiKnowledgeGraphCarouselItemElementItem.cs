using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiKnowledgeGraphCarouselItemElementItem  : BaseSerpApiKnowledgeGraphElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

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
        /// link of the element
        /// </summary>
        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LinkElement Link { get; set; }

        /// <summary>
        /// elements of search results found in SERP
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KnowledgeGraphListElement> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}