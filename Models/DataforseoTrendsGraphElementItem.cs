using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoTrendsGraphElementItem  : BaseDataforseoTrendsItem 
    {

        /// <summary>
        /// DataForSEO Trends data for the specified parameters
        /// </summary>
        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TrendsGraphDataInfo> Data { get; set; }

        /// <summary>
        /// keyword popularity values averaged over the whole time range
        /// </summary>
        [JsonProperty("averages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<double?> Averages { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}