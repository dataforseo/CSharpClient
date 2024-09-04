namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleShoppingSerpMerchantSerpElementItem : BaseMerchantSerpElementItem
    {
        /// <summary>
        /// XPath of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// domain in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the product in Google Shopping SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// URL to the product page on the seller’s website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL to the product page on Google Shopping
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopping_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShoppingUrl { get; set; }

        /// <summary>
        /// tags assigned to the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Tags { get; set; }

        /// <summary>
        /// product price
        /// <br/>example:
        /// <br/>384.99
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Price { get; set; }

        /// <summary>
        /// product old price
        /// <br/>displayed if the product price has been changed
        /// <br/>example:
        /// <br/>499
        /// </summary>
        [Newtonsoft.Json.JsonProperty("old_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? OldPrice { get; set; }

        /// <summary>
        /// currency in the ISO format
        /// <br/>example:
        /// <br/>USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// unique product identifier on Google Shopping
        /// <br/>note that there is no full list of possible values as the product_id is a dynamic value assigned by Google
        /// <br/>if there are no values, you will get null
        /// <br/>example:
        /// <br/>4485466949985702538
        /// <br/>learn more about the parameter in this help center guide
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// unique identifier of the SERP data element
        /// <br/>note that there is no full list of possible values as the data_docid is a dynamic value assigned by Google
        /// <br/>example:
        /// <br/>17363035694596624076
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_docid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// name of the seller
        /// <br/>the name of the company that placed a corresponding product on Google Shopping
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Seller { get; set; }

        /// <summary>
        /// object containing additional url parameters
        /// <br/>you can get more details about the product by using this object in the POST request to the Google Shopping Product Specification and Google Shopping Sellers endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_specifications", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> AdditionalSpecifications { get; set; }

        /// <summary>
        /// number of product reviews
        /// <br/>indicates the number of reviews left by users on Google Shopping
        /// <br/>if there are no values, you will get null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviews_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// “best match” label
        /// <br/>if the value is true, the product is marked with the “best match” label
        /// <br/>if there are no values, you will get null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_best_match", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsBestMatch { get; set; }

        /// <summary>
        /// product rating
        /// <br/>the product popularity rate based on product reviews
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingElement ProductRating { get; set; }

        /// <summary>
        /// shop rating
        /// <br/>the popularity rate of the seller based on user reviews
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingElement ShopRating { get; set; }

        /// <summary>
        /// URLs to the images of the product
        /// <br/>the first URL in the array is the featured image of the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ProductImages { get; set; }

        /// <summary>
        /// unique ad click referral parameter
        /// <br/>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_ad_aclk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShopAdAclk { get; set; }

        /// <summary>
        /// delivery information
        /// <br/>delivery information including free and fast delivery date ranges
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// stores count information
        /// <br/>contains information about the number of stores that offer the same product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stores_count_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StoresCountInfo StoresCountInfo { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}