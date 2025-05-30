using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataRatingInfo 
    {

        /// <summary>
        /// the type of rating
        /// <br/>here you can find the following elements: Max5, Percents, CustomMax
        /// </summary>
        [JsonProperty("rating_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingType { get; set; }

        /// <summary>
        /// the value of the rating
        /// </summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Value { get; set; }

        /// <summary>
        /// the amount of feedback
        /// </summary>
        [JsonProperty("votes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? VotesCount { get; set; }

        /// <summary>
        /// the maximum value for a rating_type
        /// </summary>
        [JsonProperty("rating_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RatingMax { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}