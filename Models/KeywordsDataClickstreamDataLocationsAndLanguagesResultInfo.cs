using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataClickstreamDataLocationsAndLanguagesResultInfo 
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
        /// <br/>the value will be null as Country is the only supported location_type for this API
        /// </summary>
        [JsonProperty("location_code_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCodeParent { get; set; }

        /// <summary>
        /// ISO country code of the location
        /// </summary>
        [JsonProperty("country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// location type
        /// <br/>possible values:
        /// <br/>Country
        /// </summary>
        [JsonProperty("location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationType { get; set; }

        /// <summary>
        /// supported languages
        /// <br/>contains the languages which are supported for a specific location
        /// </summary>
        [JsonProperty("available_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AvailableLanguages> AvailableLanguages { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}