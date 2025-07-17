using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsAmazonProductKeywordIntersectionsLiveItem 
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
        public AmazonKeywordData KeywordData { get; set; }

        /// <summary>
        /// data on the intersection
        /// </summary>
        [JsonProperty("intersection_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, AmazonInfo> IntersectionResult { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}