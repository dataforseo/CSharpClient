using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ChannelSubscribersCount 
    {

        /// <summary>
        /// displayed subscriber count
        /// <br/>subscriber count as displayed on YouTube
        /// </summary>
        [JsonProperty("displayed_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedCount { get; set; }

        /// <summary>
        /// subscriber count
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}