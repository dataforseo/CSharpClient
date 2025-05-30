using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixDataforseoTrendsKeywordsDataLimitsRatesDataInfo 
    {
        [JsonProperty("explore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Explore { get; set; }
        [JsonProperty("subregion_interests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SubregionInterests { get; set; }
        [JsonProperty("demography", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Demography { get; set; }
        [JsonProperty("merged_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo MergedData { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}