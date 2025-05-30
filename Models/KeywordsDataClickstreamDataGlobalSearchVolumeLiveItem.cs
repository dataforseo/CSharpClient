using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataClickstreamDataGlobalSearchVolumeLiveItem 
    {

        /// <summary>
        /// keyword
        /// <br/>keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character)
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// clickstream-based average monthly search volume rate
        /// <br/>represents the (approximate) number of searches for the given keyword idea based on clickstream
        /// <br/>you can learn more about clickstream search volume in this Help Center article
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SearchVolume { get; set; }

        /// <summary>
        /// distribution of clickstream by countries
        /// <br/>represents clickstream-based search volume in available countries, as well as its respective percentage of global search volume
        /// </summary>
        [JsonProperty("country_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<CountryDistribution> CountryDistribution { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}