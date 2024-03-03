namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HotelReviewInfo
    {
        /// <summary>
        /// overall hotel rating based on customer votes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Value { get; set; }

        /// <summary>
        /// number of customer votes
        /// <br/>the number of customer votes included in the calculation of the hotel rating
        /// </summary>
        [Newtonsoft.Json.JsonProperty("votes_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? VotesCount { get; set; }

        /// <summary>
        /// hotel mentions
        /// <br/>information about hotel reviews by criteria
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mentions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReviewMentionInfo> Mentions { get; set; }

        /// <summary>
        /// rating distribution by votes
        /// <br/>the distribution of votes across the rating in the range from 1 to 5
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating_distribution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, int?> RatingDistribution { get; set; }

        /// <summary>
        /// reviews on third-party sites
        /// <br/>reviews from third-paty sites
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other_sites_reviews", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<OtherSitesReviewsInfo> OtherSitesReviews { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}