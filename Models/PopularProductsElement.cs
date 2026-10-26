using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PopularProductsElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// title of a given link element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// source URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain where a link points
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// link description
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// indicates whether the product is sold by multiple sellers
        /// </summary>
        [JsonProperty("more_sellers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MoreSellers { get; set; }

        /// <summary>
        /// seller of the product
        /// </summary>
        [JsonProperty("seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Seller { get; set; }

        /// <summary>
        /// title of the hotel listing's group
        /// </summary>
        [JsonProperty("group_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GroupTitle { get; set; }

        /// <summary>
        /// domain or brand name of the hotel listing's group
        /// </summary>
        [JsonProperty("group_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GroupSource { get; set; }

        /// <summary>
        /// URL of the image
        /// <br/>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available)
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// price indicated in the element
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// the item's rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP;
        /// <br/>if there is none, equals <c>null</c>
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// identifiers of the product
        /// <br/>can include the following identifiers: <c>product_id</c>, <c>data_docid</c>, <c>gid</c>
        /// </summary>
        [JsonProperty("product_identifiers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProductIdentifiers ProductIdentifiers { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}