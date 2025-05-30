using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ReviewHighlights 
    {

        /// <summary>
        /// reviewed feature
        /// </summary>
        [JsonProperty("feature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }

        /// <summary>
        /// feature assessment
        /// </summary>
        [JsonProperty("assessment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Assessment { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}