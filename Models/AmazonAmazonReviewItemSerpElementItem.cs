namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AmazonAmazonReviewItemSerpElementItem : BaseAmazonSerpElementItem
    {
        /// <summary>
        /// the alignment of the review in SERP
        /// <br/>can take the following values: right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// indicates whether the review has the “Verified Purchase” mark
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// subtitle of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subtitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        /// <summary>
        /// helpful votes count
        /// <br/>number of users who clicked on the ‘Helpful” button under the review text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("helpful_votes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? HelpfulVotes { get; set; }

        /// <summary>
        /// images of the product submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ImagesElement> Images { get; set; }

        /// <summary>
        /// videos of the product submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("videos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<VideoElement> Videos { get; set; }

        /// <summary>
        /// user profile of the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_profile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserProfileInfo UserProfile { get; set; }

        /// <summary>
        /// title of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// relevant url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// content of the review
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// date and time when the review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publication_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// the rating score submitted by the reviewer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}