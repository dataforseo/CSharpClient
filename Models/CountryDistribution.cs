using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class CountryDistribution 
    {

        /// <summary>
        /// country ISO code
        /// </summary>
        [JsonProperty("country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// search volume in a given country
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// percentage of global search volume
        /// </summary>
        [JsonProperty("percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}