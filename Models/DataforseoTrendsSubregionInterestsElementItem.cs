using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoTrendsSubregionInterestsElementItem  : BaseDataforseoTrendsItem 
    {

        /// <summary>
        /// subregional keyword popuarity data for each specified term
        /// </summary>
        [JsonProperty("interests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Interests> Interests { get; set; }

        /// <summary>
        /// comparison of data on subregional keyword popularity for the specified parameters
        /// <br/>if you specified a single keyword, the value will be null
        /// </summary>
        [JsonProperty("interests_comparison", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public InterestsComparison InterestsComparison { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}