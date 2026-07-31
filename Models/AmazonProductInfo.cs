using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonProductInfo 
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
        /// absolute rank
        /// <br/>absolute position among all the elements in the response array
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in Amazon SERP
        /// <br/>possible values:
        /// <br/><c>left</c>, <c>right</c>
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the <see href="https://en.wikipedia.org/wiki/XPath">XPath</see> of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// product title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// product specs and other details
        /// </summary>
        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// the URL of the product image
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// product brand name
        /// </summary>
        [JsonProperty("author", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// ASIN of the product received in a POST array
        /// </summary>
        [JsonProperty("data_asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataAsin { get; set; }

        /// <summary>
        /// <see href="https://sellercentral.amazon.com/gp/help/external/help.html?itemID=8831&amp;language=en-US&amp;ref=mpbc_200779220_cont_8831&amp;">parent ASIN</see> of the product
        /// </summary>
        [JsonProperty("parent_asin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ParentAsin { get; set; }

        /// <summary>
        /// ASINs of all found product modifications
        /// </summary>
        [JsonProperty("product_asins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ProductAsins { get; set; }

        /// <summary>
        /// the lower limit of the product price range
        /// <br/>example:
        /// <br/><c>49.98</c>
        /// </summary>
        [JsonProperty("price_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceFrom { get; set; }

        /// <summary>
        /// the upper limit of the product price range
        /// <br/>example:
        /// <br/><c>384.99</c>
        /// </summary>
        [JsonProperty("price_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceTo { get; set; }

        /// <summary>
        /// value of the percentage discount
        /// </summary>
        [JsonProperty("percentage_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PercentageDiscount { get; set; }

        /// <summary>
        /// currency in the <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO</see> format
        /// <br/>example:
        /// <br/><c>USD</c>
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 'Amazon's choice' label
        /// <br/>if the value is <c>true</c>, the product is marked with the 'Amazon's choice' label
        /// </summary>
        [JsonProperty("is_amazon_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAmazonChoice { get; set; }

        /// <summary>
        /// product rating info
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// indicates whether the newer model of the product is available
        /// </summary>
        [JsonProperty("is_newer_model_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNewerModelAvailable { get; set; }

        /// <summary>
        /// indicates whether a product has an Amazon Prime Video label
        /// <br/>if <c>true</c>, specified product is a part of Amazon Prime Video service
        /// </summary>
        [JsonProperty("is_prime_video", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrimeVideo { get; set; }

        /// <summary>
        /// array of objects containing information about applicable vouchers
        /// </summary>
        [JsonProperty("applicable_vouchers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AmazonApplicableVouchersItem> ApplicableVouchers { get; set; }

        /// <summary>
        /// information about the newer model of the product
        /// </summary>
        [JsonProperty("newer_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NewerModel NewerModel { get; set; }

        /// <summary>
        /// contains related product categories
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Categories> Categories { get; set; }

        /// <summary>
        /// contains related product information
        /// </summary>
        [JsonProperty("product_information", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseMerchantAmazonProductInformationElementItem> ProductInformation { get; set; }

        /// <summary>
        /// contains URLs for all images of the product displayed on the left side of the main image
        /// </summary>
        [JsonProperty("product_images_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ProductImagesList { get; set; }

        /// <summary>
        /// contains URLs for all videos of the product displayed on the right side of the main video
        /// </summary>
        [JsonProperty("product_videos_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ProductVideosList { get; set; }

        /// <summary>
        /// contains description of the product
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// indicates whether the product is <see href="https://www.amazon.com/gp/help/customer/display.html?nodeId=201910280">available for ordering</see>
        /// <br/>if the value is <c>true</c>, the product can be ordered
        /// </summary>
        [JsonProperty("is_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// array of objects with top reviews from target location
        /// </summary>
        [JsonProperty("top_local_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AmazonReviewItem> TopLocalReviews { get; set; }

        /// <summary>
        /// array of objects with top reviews from around the world
        /// </summary>
        [JsonProperty("top_global_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AmazonReviewItem> TopGlobalReviews { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}