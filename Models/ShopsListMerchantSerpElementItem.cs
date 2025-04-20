namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ShopsListMerchantSerpElementItem : BaseMerchantSerpElementItem
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
        /// product title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Google Shopping URL forwarding to the product page on the seller’s website
        /// <br/>if you want to obtain a URL of the advertisement forwarding to the product page on the seller’s website, please refer to the Google Shopping Sellers Ad URL endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// details and special offers
        /// <br/>if there are no details, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// product price without tax and shipping
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BasePrice { get; set; }

        /// <summary>
        /// the amount of tax
        /// <br/>tax is specified as the actual amount of money, not as the percentage
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Tax { get; set; }

        /// <summary>
        /// product shipping price
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ShippingPrice { get; set; }

        /// <summary>
        /// product price including tax and shipping
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// currency in the ISO format
        /// <br/>example:
        /// <br/>USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// monthly price multiplier
        /// <br/>indicates the number of months covered by the monthly payment for the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_multiplier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PriceMultiplier { get; set; }

        /// <summary>
        /// name of the seller
        /// <br/>the name of the company that placed a corresponding product on Google Shopping
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// shop rating
        /// <br/>the shop popularity rate based on product reviews
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// unique ad click referral parameter
        /// <br/>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_ad_aclk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShopAdAclk { get; set; }

        /// <summary>
        /// indicated condition of the product
        /// <br/>possible values: Used, Refurbished, New, null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_condition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductCondition { get; set; }

        /// <summary>
        /// data from annotations and badges with special offers
        /// <br/>if there is no annotation for this product, the value will be null
        /// <br/>examples: LOW PRICE, SPECIAL OFFER, SALE, PRICE DROP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_annotation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductAnnotation { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}