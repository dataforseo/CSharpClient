using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TopStoriesDataforseoLabsSerpElementItem  : BaseDataforseoLabsSerpElementItem 
    {

        /// <summary>
        /// additional items present in the element
        /// <br/>if there are none, equals null
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