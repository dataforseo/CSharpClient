using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleSearchIntentLiveItem 
    {

        /// <summary>
        /// target keyword in a POST array
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search intent data relevant for the specified keyword
        /// </summary>
        [JsonProperty("keyword_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeywordIntentInfo KeywordIntent { get; set; }

        /// <summary>
        /// contains objects with other possible search intents for the specified keyword
        /// </summary>
        [JsonProperty("secondary_keyword_intents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeywordIntentInfo> SecondaryKeywordIntents { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}