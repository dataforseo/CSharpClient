using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixTaskKeywordsDataPriceDataInfo 
    {
        [JsonProperty("priority_low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityLow { get; set; }
        [JsonProperty("priority_normal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityNormal { get; set; }
        [JsonProperty("priority_high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityHigh { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}