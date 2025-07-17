using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsPageIntersectionLiveItem 
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
        /// contains data on the SERP elements found for the returned keyword
        /// <br/>data will be provided in separate arrays for each URL you specified in the pages object when setting a task;
        /// <br/>depending on the number of specified URLs, it can contain from 1 to 20 arrays named respectively
        /// </summary>
        [JsonProperty("intersection_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, BaseDataforseoLabsApiElementItem> IntersectionResult { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}