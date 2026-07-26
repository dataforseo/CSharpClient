using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleShoppingSerpElementItem  : BaseMerchantGoogleShoppingProductsElementItem 
    {

        /// <summary>
        /// domain of the URL
        /// <br/>domain of the URL where a special offer is posted
        /// <br/>Note: this field is deprecated and will return <c>null</c>
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the product in Google Shopping SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// URL pointing at special offer page
        /// <br/>URL where a special offer is posted
        /// <br/>Note: this field is deprecated and will return <c>null</c>
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL to the product page on Google Shopping
        /// </summary>
        [JsonProperty("shopping_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShoppingUrl { get; set; }

        /// <summary>
        /// tags assigned to the product
        /// </summary>
        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// product price
        /// <br/>example:
        /// <br/><c>384.99</c>
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// price multiplier for instalment plan
        /// <br/>indicates the number of months covered by the monthly payment for the product
        /// </summary>
        [JsonProperty("price_multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMultiplier { get; set; }

        /// <summary>
        /// product old price
        /// <br/>displayed if the product price has been changed
        /// <br/>example:
        /// <br/><c>499</c>
        /// </summary>
        [JsonProperty("old_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OldPrice { get; set; }

        /// <summary>
        /// currency in the <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO</see> format
        /// <br/>example:
        /// <br/><c>USD</c>
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// unique product identifier on Google Shopping
        /// <br/>note that there is no full list of possible values as the <c>product_id</c> is a dynamic value assigned by Google
        /// <br/>if there are no values, you will get <c>null</c>
        /// <br/>example:
        /// <br/><c>4485466949985702538</c>
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/product-id-google-shopping">this help center guide</see>
        /// </summary>
        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// unique identifier of the SERP data element
        /// <br/>note that there is no full list of possible values as the <c>data_docid</c> is a dynamic value assigned by Google
        /// <br/>example:
        /// <br/><c>17363035694596624076</c>
        /// </summary>
        [JsonProperty("data_docid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// name of the seller
        /// <br/>the name of the company that placed a corresponding product on Google Shopping
        /// </summary>
        [JsonProperty("seller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Seller { get; set; }

        /// <summary>
        /// object containing additional url parameters
        /// <br/>you can get more details about the product by using this object in the POST request to the <see href="/v3/merchant/google/products/task_post/?php">Google Shopping Product Specification</see> and <see href="/v3/merchant/google/sellers/task_post/?php">Google Shopping Sellers</see> endpoint
        /// </summary>
        [JsonProperty("additional_specifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> AdditionalSpecifications { get; set; }

        /// <summary>
        /// number of product reviews
        /// <br/>indicates the number of reviews left by users on Google Shopping
        /// <br/>if there are no values, you will get <c>null</c>
        /// </summary>
        [JsonProperty("reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// 'best match' label
        /// <br/>if the value is <c>true</c>, the product is marked with the 'best match' label
        /// <br/>if there are no values, you will get <c>null</c>
        /// </summary>
        [JsonProperty("is_best_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBestMatch { get; set; }

        /// <summary>
        /// product rating
        /// <br/>the product popularity rate based on product reviews
        /// </summary>
        [JsonProperty("product_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement ProductRating { get; set; }

        /// <summary>
        /// shop rating
        /// <br/>the popularity rate of the seller based on user reviews
        /// </summary>
        [JsonProperty("shop_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement ShopRating { get; set; }

        /// <summary>
        /// URLs to the images of the product
        /// <br/>the first URL in the array is the featured image of the product
        /// </summary>
        [JsonProperty("product_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ProductImages { get; set; }

        /// <summary>
        /// unique ad click referral parameter
        /// <br/>using this parameter you can get a URL of the advertisement in <see href="/v3/merchant/google/sellers/ad_url/">Google Shopping Sellers Ad URL</see>
        /// </summary>
        [JsonProperty("shop_ad_aclk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShopAdAclk { get; set; }

        /// <summary>
        /// global product identifier on Google Shopping
        /// <br/>note that there is no full list of possible values as the <c>gid</c> is a dynamic value assigned by Google
        /// <br/>if there are no values, you will get <c>null</c>
        /// <br/>example:
        /// <br/><c>4702526954592161872</c>
        /// <br/>learn more about <c>gid</c> parameter in <see href="https://dataforseo.com/help-center/whats-a-gid-in-google-shopping-api">this help center guide</see>
        /// </summary>
        [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }

        /// <summary>
        /// delivery information
        /// <br/>delivery information including free and fast delivery date ranges
        /// </summary>
        [JsonProperty("delivery_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// stores count information
        /// <br/>contains information about the number of stores that offer the same product
        /// </summary>
        [JsonProperty("stores_count_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StoresCountInfo StoresCountInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}