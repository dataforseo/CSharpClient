using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TripadvisorReviewSearch 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank among all the listed reviews
        /// <br/>absolute position among all reviews on the list
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the review in SERP
        /// <br/>can take the following values: right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// URL of the review
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// date of the reviewer’s visit to the local establishment
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("date_of_visit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfVisit { get; set; }

        /// <summary>
        /// date and time when the review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// ID of the review
        /// </summary>
        [JsonProperty("review_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewId { get; set; }

        /// <summary>
        /// title of the review
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// content of the review
        /// </summary>
        [JsonProperty("review_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// language of the review text
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// language of the untranslated review text
        /// </summary>
        [JsonProperty("original_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalLanguage { get; set; }

        /// <summary>
        /// contains URLs of the images used in the review
        /// </summary>
        [JsonProperty("review_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ImageUrlInfo> ReviewImages { get; set; }

        /// <summary>
        /// information from the reviewer’s profile
        /// </summary>
        [JsonProperty("user_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessDataUserProfileInfo UserProfile { get; set; }

        /// <summary>
        /// contains information about the owner’s response
        /// </summary>
        [JsonProperty("responses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ReviewResponseItemInfo> Responses { get; set; }

        /// <summary>
        /// review highlights
        /// <br/>contains highlighted review criteria and assessments
        /// </summary>
        [JsonProperty("review_highlights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object ReviewHighlights { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}