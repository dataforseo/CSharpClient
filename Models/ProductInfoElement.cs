using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ProductInfoElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical <c>type</c> values
        /// <br/>positions of elements with different <c>type</c> values are omitted from <c>rank_group</c>
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank on the product specification page
        /// <br/>absolute position among all the elements found on the product specification page
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// alignment of the element on the product specification page
        /// <br/>can take the following values:
        /// <br/><c>right</c>, <c>left</c>
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// product_id received in a POST array
        /// <br/>ilearn more about the parameter in <see href="https://dataforseo.com/help-center/product-id-google-shopping">this help center guide</see>
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// title of the product
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the product
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// product url
        /// <br/>url of the product on Google Shopping
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// product images
        /// <br/>contains urls to product images
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Images { get; set; }

        /// <summary>
        /// product features
        /// <br/>contains snippets with the description of product features
        /// </summary>
        [JsonProperty("features", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Features { get; set; }

        /// <summary>
        /// product rating 
        /// <br/>the popularity rate based on reviews
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// number of seller reviews
        /// <br/>number of reviews on the product seller's account
        /// </summary>
        [JsonProperty("seller_reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SellerReviewsCount { get; set; }

        /// <summary>
        /// unique identifier of the SERP data element
        /// <br/>note that there is no full list of possible values as the <c>data_docid</c> is a dynamic value assigned by Google
        /// <br/>example:
        /// <br/><c>17363035694596624076</c>
        /// </summary>
        [JsonProperty("data_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// global product identifier on Google Shopping
        /// <br/>note that there is no full list of possible values as the gid is a dynamic value assigned by Google
        /// <br/>if there are no values, you will get <c>null</c>
        /// <br/>example:
        /// <br/><c>4702526954592161872</c>
        /// <br/>learn more about <c>gid</c> in <see href="https://dataforseo.com/help-center/whats-a-gid-in-google-shopping-api">this help center guide</see>
        /// </summary>
        [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }

        /// <summary>
        /// product specifications
        /// <br/>contains all product attributes and related data listed on the product specification page
        /// </summary>
        [JsonProperty("specifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ShoppingSpecification> Specifications { get; set; }

        /// <summary>
        /// sellers of the product
        /// <br/>number of reviews on the product seller's account
        /// </summary>
        [JsonProperty("sellers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ProductSeller> Sellers { get; set; }

        /// <summary>
        /// variations of the product
        /// <br/>contains brief information about different product variations
        /// </summary>
        [JsonProperty("variations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ProductVariation> Variations { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}