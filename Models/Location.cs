using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Location 
    {

        /// <summary>
        /// name of the neighborhood where the hotel is located
        /// </summary>
        [JsonProperty("neighborhood", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Neighborhood { get; set; }

        /// <summary>
        /// description of the neighborhood where the hotel is located
        /// </summary>
        [JsonProperty("neighborhood_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NeighborhoodDescription { get; set; }

        /// <summary>
        /// url to the location of the hotel in google maps
        /// </summary>
        [JsonProperty("maps_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MapsUrl { get; set; }

        /// <summary>
        /// overall score of the hotel location
        /// <br/>indicates the overall score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby things to do and restaurants, transportation, and airports;
        /// <br/>note that the criteria are not weighted equally in the overall score
        /// </summary>
        [JsonProperty("overall_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? OverallScore { get; set; }

        /// <summary>
        /// category scores of the hotel location
        /// <br/>the scores of the hotel’s location tied to the categories that indicate the proximity to nearby things to do, restaurants, transportation, and airports;
        /// </summary>
        [JsonProperty("score_by_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ScoreByCategories ScoreByCategories { get; set; }

        /// <summary>
        /// hotel latitude
        /// <br/>latitude coordinates of the hotel’s location
        /// <br/>example:
        /// <br/>39.4806397
        /// </summary>
        [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Latitude { get; set; }

        /// <summary>
        /// hotel longitude
        /// <br/>latitude coordinates of the hotel’s location
        /// <br/>example:
        /// <br/>-106.0512973
        /// </summary>
        [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Longitude { get; set; }

        /// <summary>
        /// elements of the location chain
        /// <br/>additional parameters of each element of the location chain
        /// </summary>
        [JsonProperty("location_chain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LocationChain> LocationChain { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}