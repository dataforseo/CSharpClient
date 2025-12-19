using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GroupElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// grouping identifier
        /// <br/>the specific identifier for the grouping dimension
        /// </summary>
        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// total LLM mentions count
        /// <br/>the number of times the target keyword or domain were mentioned in relation to this specific grouping key
        /// </summary>
        [JsonProperty("mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Mentions { get; set; }

        /// <summary>
        /// current AI search volume rate of a keyword
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AiSearchVolume { get; set; }

        /// <summary>
        /// current AI impressions rate of a keyword
        /// </summary>
        [JsonProperty("impressions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Impressions { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}