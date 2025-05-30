using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixSocialMediaBusinessDataLimitsRatesDataInfo 
    {
        [JsonProperty("facebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Facebook { get; set; }
        [JsonProperty("pinterest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Pinterest { get; set; }
        [JsonProperty("reddit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Reddit { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}