using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentAnalysisLanguagesResultInfo 
    {
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }
        [JsonProperty("location_code_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCodeParent { get; set; }
        [JsonProperty("country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }
        [JsonProperty("location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationType { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}