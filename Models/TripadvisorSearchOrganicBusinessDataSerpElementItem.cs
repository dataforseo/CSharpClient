using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TripadvisorSearchOrganicBusinessDataSerpElementItem  : BaseBusinessDataSerpElementItem 
    {

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
        public double? ReviewsCount { get; set; }

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
        public BusinessDataRatingInfo Rating { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}