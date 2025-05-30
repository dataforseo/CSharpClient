using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HotelReviewInfo 
    {

        /// <summary>
        /// overall hotel rating based on customer votes
        /// </summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Value { get; set; }

        /// <summary>
        /// number of customer votes
        /// <br/>the number of customer votes included in the calculation of the hotel rating
        /// </summary>
        [JsonProperty("votes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? VotesCount { get; set; }

        /// <summary>
        /// hotel mentions
        /// <br/>information about hotel reviews by criteria
        /// </summary>
        [JsonProperty("mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ReviewMentionInfo> Mentions { get; set; }

        /// <summary>
        /// rating distribution by votes
        /// <br/>the distribution of votes across the rating in the range from 1 to 5
        /// </summary>
        [JsonProperty("rating_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, int?> RatingDistribution { get; set; }

        /// <summary>
        /// reviews on third-party sites
        /// <br/>reviews from third-paty sites
        /// </summary>
        [JsonProperty("other_sites_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<OtherSitesReviewsInfo> OtherSitesReviews { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}