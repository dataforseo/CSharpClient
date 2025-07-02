using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleReviewsSearchBusinessDataSerpElementItem  : BaseBusinessDataSerpElementItem 
    {

        /// <summary>
        /// the alignment of the review in SERP
        /// <br/>can take the following values: right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the review
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// the content of the review
        /// </summary>
        [JsonProperty("review_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// original content of the review
        /// <br/>the original content of the review, no auto-translate applied
        /// </summary>
        [JsonProperty("original_review_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalReviewText { get; set; }

        /// <summary>
        /// the time of publication
        /// <br/>indicates the time (in the ‘time ago’ format) when the review was listed
        /// </summary>
        [JsonProperty("time_ago", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// date and time when a review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// total number of reviews submitted by the reviewer
        /// </summary>
        [JsonProperty("reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// total number of photos submitted by the reviewer
        /// </summary>
        [JsonProperty("photos_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PhotosCount { get; set; }

        /// <summary>
        /// indicates whether the reviewer has a ‘local guide’ status
        /// </summary>
        [JsonProperty("local_guide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LocalGuide { get; set; }

        /// <summary>
        /// profile name of the reviewer
        /// </summary>
        [JsonProperty("profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileName { get; set; }

        /// <summary>
        /// URL of the reviewer’s profile
        /// </summary>
        [JsonProperty("profile_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// the URL of the review
        /// </summary>
        [JsonProperty("review_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewUrl { get; set; }

        /// <summary>
        /// URL of the reviewer’s profile image
        /// </summary>
        [JsonProperty("profile_image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// text of the owner’s response
        /// <br/>the owner’s response to the review
        /// </summary>
        [JsonProperty("owner_answer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerAnswer { get; set; }

        /// <summary>
        /// original text of the owner’s response
        /// <br/>the original response to the review, no auto-translate applied
        /// </summary>
        [JsonProperty("original_owner_answer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalOwnerAnswer { get; set; }

        /// <summary>
        /// publication time
        /// <br/>indicates the time (in the ‘time ago’ format) when the owner submitted the response to the review
        /// </summary>
        [JsonProperty("owner_time_ago", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerTimeAgo { get; set; }

        /// <summary>
        /// date and time of the owner’s reply to the review
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("owner_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerTimestamp { get; set; }

        /// <summary>
        /// the unique identifier of a review on Google
        /// <br/>example:
        /// <br/>ChZDSUhNMG9nS0VJQ0FnSUMxbHFyMFlnEAE
        /// </summary>
        [JsonProperty("review_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewId { get; set; }

        /// <summary>
        /// images submitted by the reviewer
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ImagesElement> Images { get; set; }

        /// <summary>
        /// review highlights
        /// <br/>contains highlighted review criteria and assessments
        /// </summary>
        [JsonProperty("review_highlights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ReviewHighlights> ReviewHighlights { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}