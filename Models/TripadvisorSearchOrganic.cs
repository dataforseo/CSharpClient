using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TripadvisorSearchOrganic 
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
        /// absolute rank among all the listed results
        /// <br/>absolute position among all reviews on the list
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// name of the business entity
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL path of the business entity
        /// <br/>URL path to the Tripadvisor page of the business entity
        /// <br/>you can use this identifier to collect reviews for the business entity using Tripadvisor Reviews
        /// </summary>
        [JsonProperty("url_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        /// <summary>
        /// indicates a sponsored placement
        /// <br/>if true, related tripadvisor_search_organic item is a paid advertising on Tripadvisor
        /// </summary>
        [JsonProperty("is_sponsored", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSponsored { get; set; }

        /// <summary>
        /// the total number of reviews
        /// </summary>
        [JsonProperty("reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// place category
        /// </summary>
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// average price rate
        /// </summary>
        [JsonProperty("price_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PriceRate { get; set; }

        /// <summary>
        /// the rating score of the establishment submitted by the reviewers
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}