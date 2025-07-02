using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixRatesData 
    {

        /// <summary>
        /// rate limits for API calls per a certain period of time
        /// </summary>
        [JsonProperty("limits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixLimitsRatesData Limits { get; set; }

        /// <summary>
        /// statisctics for API calls
        /// </summary>
        [JsonProperty("statistics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixStatisticsRatesData Statistics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}