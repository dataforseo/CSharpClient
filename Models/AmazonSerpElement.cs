namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AmazonSerpElement
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// Amazon domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// product title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// the URL of the product page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL of the product image featured in the results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// number of product purchases in the past month
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bought_past_month", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BoughtPastMonth { get; set; }

        /// <summary>
        /// the regular price of a product
        /// <br/>example:
        /// <br/>49.98
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? PriceFrom { get; set; }

        /// <summary>
        /// the upper limit of the product price range
        /// <br/>example:
        /// <br/>384.99
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? PriceTo { get; set; }

        /// <summary>
        /// currency in the ISO format
        /// <br/>example:
        /// <br/>USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// special offer details
        /// <br/>contains special offer details, including coupon and Subscribe &amp; Save discounts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("special_offers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SpecialOffers { get; set; }

        /// <summary>
        /// unique product identifier on Amazon
        /// <br/>note that there is no full list of possible values as the data_asin is a dynamic value assigned by Amazon
        /// <br/>example:
        /// <br/>B07G82D89J
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_asin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DataAsin { get; set; }

        /// <summary>
        /// product rating info
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// “Amazon’s choice” label
        /// <br/>if the value is true, the product is marked with the “Amazon’s choice” label
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_amazon_choice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAmazonChoice { get; set; }

        /// <summary>
        /// “Best Seller” label
        /// <br/>if the value is true, the product is marked with the “Best Seller” label
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_best_seller", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsBestSeller { get; set; }

        /// <summary>
        /// delivery information
        /// <br/>delivery information including free and fast delivery date ranges
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AmazonDeliveryInfo DeliveryInfo { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}