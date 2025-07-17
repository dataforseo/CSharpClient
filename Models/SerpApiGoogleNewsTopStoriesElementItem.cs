using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleNewsTopStoriesElementItem  : BaseSerpApiGoogleNewsElementItem 
    {

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// items of the element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TopStoriesElement> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}