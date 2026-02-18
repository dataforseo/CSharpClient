using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiYoutubeChannelElementItem  : BaseSerpApiYoutubeOrganicElementItem 
    {

        /// <summary>
        /// name of the channel
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// the URL of the page where the logo image is hosted
        /// </summary>
        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }

        /// <summary>
        /// the number of videos counted on the channel
        /// </summary>
        [JsonProperty("video_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoCount { get; set; }

        /// <summary>
        /// indicates whether the channel has a “verified” label
        /// </summary>
        [JsonProperty("is_verified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// description of the channel
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// highlighted keywords in the description
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}