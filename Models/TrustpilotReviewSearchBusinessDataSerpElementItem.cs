using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TrustpilotReviewSearchBusinessDataSerpElementItem  : BaseBusinessDataSerpElementItem 
    {

        /// <summary>
        /// the alignment of the review in SERP
        /// <br/>can take the following values: right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the URL of the review
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessDataRatingInfo Rating { get; set; }

        /// <summary>
        /// indicates whether the review has the “Verified” mark
        /// </summary>
        [JsonProperty("verified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// the language of the review
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// date and time when a review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// the title of the review
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// the content of the review
        /// </summary>
        [JsonProperty("review_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// images submitted by the reviewer
        /// <br/>displays URLs to the images provided by the author of the review;
        /// <br/>please note that Trustpilot doesn’t allow adding images to reviews, so the review_images parameter will always equal null
        /// </summary>
        [JsonProperty("review_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ReviewImages { get; set; }

        /// <summary>
        /// user profile of the reviewer
        /// </summary>
        [JsonProperty("user_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessDataUserProfileInfo UserProfile { get; set; }

        /// <summary>
        /// owner’s response to the submitted review
        /// </summary>
        [JsonProperty("responses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ReviewResponseItemInfo> Responses { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}