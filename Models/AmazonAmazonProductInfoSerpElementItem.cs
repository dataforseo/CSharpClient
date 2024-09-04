namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AmazonAmazonProductInfoSerpElementItem : BaseAmazonSerpElementItem
    {
        /// <summary>
        /// the alignment of the element in Amazon SERP
        /// <br/>possible values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// product title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// product specs and other details
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// the URL of the product image
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// product brand name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("author", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// ASIN of the product received in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_asin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DataAsin { get; set; }

        /// <summary>
        /// parent ASIN of the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_asin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ParentAsin { get; set; }

        /// <summary>
        /// ASINs of all found product modifications
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_asins", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ProductAsins { get; set; }

        /// <summary>
        /// the lower limit of the product price range
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
        /// “Amazon’s choice” label
        /// <br/>if the value is true, the product is marked with the “Amazon’s choice” label
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_amazon_choice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAmazonChoice { get; set; }

        /// <summary>
        /// product rating info
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// indicates whether the newer model of the product is available
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_newer_model_available", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNewerModelAvailable { get; set; }

        /// <summary>
        /// information about the newer model of the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("newer_model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AmazonProductNewerModelInfo NewerModel { get; set; }

        /// <summary>
        /// contains related product categories
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ProductCategoryInfo> Categories { get; set; }

        /// <summary>
        /// contains related product information
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_information", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BaseProductInformationItem> ProductInformation { get; set; }

        /// <summary>
        /// contains URLs for all images of the product displayed on the left side of the main image
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_images_list", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ProductImagesList { get; set; }

        /// <summary>
        /// contains URLs for all videos of the product displayed on the right side of the main video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_videos_list", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ProductVideosList { get; set; }

        /// <summary>
        /// contains description of the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// indicates whether the product is available for ordering
        /// <br/>if the value is true, the product can be ordered
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_available", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}