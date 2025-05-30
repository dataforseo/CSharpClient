using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixFunctionTypeInfo 
    {
        [JsonProperty("regular", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Regular { get; set; }
        [JsonProperty("advanced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Advanced { get; set; }
        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Html { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}