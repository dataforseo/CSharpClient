using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ScoreByCategories 
    {

        /// <summary>
        /// overall score of the hotel location
        /// <br/>indicates the overall score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby things to do and restaurants, transportation, and airports;
        /// <br/>note that the criteria are not weighted equally in the overall score
        /// </summary>
        [JsonProperty("overall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Overall { get; set; }

        /// <summary>
        /// score relative to nearby things to do
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby things to do
        /// </summary>
        [JsonProperty("things_to_do", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ThingsToDo { get; set; }

        /// <summary>
        /// score relative to nearby restaurants
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby restaurants
        /// </summary>
        [JsonProperty("restaurants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Restaurants { get; set; }

        /// <summary>
        /// score relative to nearby transit options
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby transit options
        /// </summary>
        [JsonProperty("transit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Transit { get; set; }

        /// <summary>
        /// score relative to nearby airports
        /// <br/>indicates the score of the hotel’s location in the range from 1 to 5;
        /// <br/>calculated based on data from the hotel’s proximity to nearby airports
        /// </summary>
        [JsonProperty("airport_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AirportAccess { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}