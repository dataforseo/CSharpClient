using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsDomainIntersectionLiveItem 
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
        /// contains data on the first domain’s SERP element found for the returned keyword
        /// <br/>the list of supported SERP elements can be found below
        /// </summary>
        [JsonProperty("first_domain_serp_element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BaseDataforseoLabsApiElementItem FirstDomainSerpElement { get; set; }

        /// <summary>
        /// contains data on the second domain’s SERP element found for the returned keyword
        /// <br/>the list of supported SERP elements can be found below
        /// </summary>
        [JsonProperty("second_domain_serp_element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BaseDataforseoLabsApiElementItem SecondDomainSerpElement { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}