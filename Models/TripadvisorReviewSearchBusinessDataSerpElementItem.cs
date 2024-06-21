namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TripadvisorReviewSearchBusinessDataSerpElementItem : BaseBusinessDataSerpElementItem
    {
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
        /// URL of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// date of the reviewer’s visit to the local establishment
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_of_visit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateOfVisit { get; set; }

        /// <summary>
        /// date and time when the review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// title of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// content of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// contains URLs of the images used in the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ImageUrlInfo> ReviewImages { get; set; }

        /// <summary>
        /// information from the reviewer’s profile
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_profile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BusinessDataUserProfileInfo UserProfile { get; set; }

        /// <summary>
        /// contains information about the owner’s response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("responses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReviewResponseItemInfo> Responses { get; set; }

        /// <summary>
        /// review highlights
        /// <br/>contains highlighted review criteria and assessments
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_highlights", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReviewHighlights> ReviewHighlights { get; set; }

    }
}