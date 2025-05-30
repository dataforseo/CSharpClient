using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordIntentInfo 
    {

        /// <summary>
        /// search intent name
        /// <br/>possible values: informational, navigational, commercial, transactional
        /// </summary>
        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// search intent probability
        /// <br/>1 indicates the highest probability
        /// </summary>
        [JsonProperty("probability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Probability { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}