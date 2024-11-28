namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleExtendedReviewsTaskGetItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank among all the listed reviews
        /// <br/>absolute position among all reviews on the list
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the review in SERP
        /// <br/>can take the following values: right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// the content of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// original content of the review
        /// <br/>the original content of the review, no auto-translate applied
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_review_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginalReviewText { get; set; }

        /// <summary>
        /// the time of publication
        /// <br/>indicates the time (in the ‘time ago’ format) when the review was listed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_ago", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// date and time when a review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// total number of reviews submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviews_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// total number of photos submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("photos_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PhotosCount { get; set; }

        /// <summary>
        /// indicates whether the reviewer has a ‘local guide’ status
        /// </summary>
        [Newtonsoft.Json.JsonProperty("local_guide", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? LocalGuide { get; set; }

        /// <summary>
        /// profile name of the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profile_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileName { get; set; }

        /// <summary>
        /// URL of the reviewer’s profile
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profile_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// the URL of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReviewUrl { get; set; }

        /// <summary>
        /// URL of the reviewer’s profile image
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profile_image_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// text of the owner’s response
        /// <br/>the owner’s response to the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_answer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OwnerAnswer { get; set; }

        /// <summary>
        /// original text of the owner’s response
        /// <br/>the original response to the review, no auto-translate applied
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_owner_answer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginalOwnerAnswer { get; set; }

        /// <summary>
        /// publication time
        /// <br/>indicates the time (in the ‘time ago’ format) when the owner submitted the response to the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_time_ago", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OwnerTimeAgo { get; set; }

        /// <summary>
        /// date and time of the owner’s reply to the review
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OwnerTimestamp { get; set; }

        /// <summary>
        /// the unique identifier of a review on Google
        /// <br/>example:
        /// <br/>ChZDSUhNMG9nS0VJQ0FnSUMxbHFyMFlnEAE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReviewId { get; set; }

        /// <summary>
        /// images submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ImagesElement> Images { get; set; }

        /// <summary>
        /// review highlights
        /// <br/>contains highlighted review criteria and assessments
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_highlights", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReviewHighlights> ReviewHighlights { get; set; }

        /// <summary>
        /// source of the review
        /// <br/>contains information about the source where the review was posted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Source Source { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}