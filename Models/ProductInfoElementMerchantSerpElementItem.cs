namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ProductInfoElementMerchantSerpElementItem : BaseMerchantSerpElementItem
    {
        /// <summary>
        /// product_id received in a POST array
        /// <br/>ilearn more about the parameter in this help center guide
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// title of the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// product url
        /// <br/>url of the product on Google Shopping
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// product images
        /// <br/>contains urls to product images
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Images { get; set; }

        /// <summary>
        /// product features
        /// <br/>contains snippets with the description of product features
        /// </summary>
        [Newtonsoft.Json.JsonProperty("features", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Features { get; set; }

        /// <summary>
        /// product rating 
        /// <br/>the popularity rate based on reviews
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// number of seller reviews
        /// <br/>number of reviews on the product seller’s account
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_reviews_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SellerReviewsCount { get; set; }

        /// <summary>
        /// sellers of the product
        /// <br/>number of reviews on the product seller’s account
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sellers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ProductSeller> Sellers { get; set; }

        /// <summary>
        /// variations of the product
        /// <br/>contains brief information about different product variations
        /// </summary>
        [Newtonsoft.Json.JsonProperty("variations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ProductVariation> Variations { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}