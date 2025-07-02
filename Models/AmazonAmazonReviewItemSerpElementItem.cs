using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonAmazonReviewItemSerpElementItem  : BaseAmazonSerpElementItem 
    {

        /// <summary>
        /// the alignment of the review in SERP
        /// <br/>can take the following values: right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// indicates whether the review has the “Verified Purchase” mark
        /// </summary>
        [JsonProperty("verified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// subtitle of the review
        /// </summary>
        [JsonProperty("subtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        /// <summary>
        /// helpful votes count
        /// <br/>number of users who clicked on the ‘Helpful” button under the review text
        /// </summary>
        [JsonProperty("helpful_votes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HelpfulVotes { get; set; }

        /// <summary>
        /// images of the product submitted by the reviewer
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ImagesElement> Images { get; set; }

        /// <summary>
        /// videos of the product submitted by the reviewer
        /// </summary>
        [JsonProperty("videos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<VideoElement> Videos { get; set; }

        /// <summary>
        /// user profile of the reviewer
        /// </summary>
        [JsonProperty("user_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UserProfileInfo UserProfile { get; set; }

        /// <summary>
        /// title of the review
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL to the reviewer’s profile
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// content of the review
        /// </summary>
        [JsonProperty("review_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// date and time when the review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("publication_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}