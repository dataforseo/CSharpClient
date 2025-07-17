using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixSerpPriceDataInfo 
    {
        [JsonProperty("advanced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Advanced { get; set; }
        [JsonProperty("regular", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Regular { get; set; }
        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Html { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}