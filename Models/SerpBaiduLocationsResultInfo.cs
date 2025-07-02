using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpBaiduLocationsResultInfo 
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
        /// <br/>only City location_type is supported for all countries except China (where Country is also supported);
        /// <br/>don’t match locations by location_code_parent because the results for Region and Country-level results for most countries are not supported by Baidu SERP API
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
        /// <br/>only City is supported for all countries except China (where Country is also supported)
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