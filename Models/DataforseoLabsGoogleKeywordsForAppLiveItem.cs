using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleKeywordsForAppLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// keyword data for the returned keyword
        /// </summary>
        [JsonProperty("keyword_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeywordDataInfo KeywordData { get; set; }

        /// <summary>
        /// contains data on the domain’s SERP element found for the returned keyword
        /// </summary>
        [JsonProperty("ranked_serp_element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GooglePlayRankedSerpElementInfo RankedSerpElement { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}