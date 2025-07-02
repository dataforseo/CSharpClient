using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessListingAggregationInfo 
    {

        /// <summary>
        /// the most mentioned related categories
        /// <br/>top categories displayed with the number of businesses in each category
        /// </summary>
        [JsonProperty("top_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> TopCategories { get; set; }

        /// <summary>
        /// the most mentioned counties
        /// <br/>country codes with the biggest number of businesses in the category
        /// </summary>
        [JsonProperty("top_countries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> TopCountries { get; set; }

        /// <summary>
        /// number of unique websites
        /// </summary>
        [JsonProperty("websites_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? WebsitesCount { get; set; }

        /// <summary>
        /// number of unique entities
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// the most mentioned service details
        /// <br/>service details of a business entity displayed in a form of checks and the number of entities mentioning each attribute
        /// </summary>
        [JsonProperty("top_attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> TopAttributes { get; set; }

        /// <summary>
        /// top keywords mentioned in customer reviews
        /// <br/>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword
        /// </summary>
        [JsonProperty("top_place_topics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> TopPlaceTopics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}