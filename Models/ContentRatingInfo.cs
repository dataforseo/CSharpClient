using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentRatingInfo 
    {

        /// <summary>
        /// rating name
        /// <br/>here you can find the following elements: Max5, Percents, CustomMax
        /// </summary>
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// the value of the rating
        /// </summary>
        [JsonProperty("rating_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingValue { get; set; }

        /// <summary>
        /// number of votes
        /// </summary>
        [JsonProperty("rating_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingCount { get; set; }

        /// <summary>
        /// maximum value for the rating name
        /// </summary>
        [JsonProperty("max_rating_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MaxRatingValue { get; set; }

        /// <summary>
        /// relative rating
        /// </summary>
        [JsonProperty("relative_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeRating { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}