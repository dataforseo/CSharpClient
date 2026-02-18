using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpYoutubeLocationsCountryResultInfo 
    {

        /// <summary>
        /// location code
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the location
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// the code of the superordinate location
        /// <br/>example:
        /// <br/>'location_code': 9041134,
        /// <br/>'location_name': 'Vienna International Airport,Lower Austria,Austria',
        /// <br/>'location_code_parent': 20044
        /// <br/>where location_code_parent corresponds to:
        /// <br/>'location_code': 20044,
        /// <br/>'location_name': 'Lower Austria,Austria'
        /// </summary>
        [JsonProperty("location_code_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCodeParent { get; set; }

        /// <summary>
        /// ISO country code of the location
        /// </summary>
        [JsonProperty("country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// location type
        /// <br/>indicates the geographic classification of the location
        /// <br/>example:
        /// <br/>'location_type': 'Country', or 'location_type': 'State'
        /// </summary>
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