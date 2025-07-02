using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AbsoluteItems 
    {

        /// <summary>
        /// location identifier
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>see the full list of available locations with their geo_id here or by making a separate request to https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations
        /// <br/>example:
        /// <br/>US-NY
        /// </summary>
        [JsonProperty("geo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeoId { get; set; }

        /// <summary>
        /// location name
        /// <br/>you can use this field for matching obtained results with location parameters specified in the request
        /// <br/>see the full list of available locations with their geo_name here or by making a separate request to https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations
        /// <br/>example:
        /// <br/>Andorra
        /// </summary>
        [JsonProperty("geo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GeoName { get; set; }

        /// <summary>
        /// keyword popularity rates within a given location
        /// <br/>represents location-specific keyword popularity rate over the specified time range;
        /// <br/>using these values, you can understand which of the specified keywords is more popular in the related location;
        /// <br/>the first value in the array is provided for the first term from the keywords array, the second value is provided for the second keyword, and so on;
        /// <br/>calculation: we determine the highest popularity value across all specified keywords within a given location, and then express the popularity values of each keyword as a percentage of the highest value (100);
        /// <br/>a value of 100 is the peak popularity for the term
        /// <br/>a value of 50 means that the term is half as popular
        /// <br/>a value of 0 means there was not enough data for this term
        /// </summary>
        [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<int?> Values { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}