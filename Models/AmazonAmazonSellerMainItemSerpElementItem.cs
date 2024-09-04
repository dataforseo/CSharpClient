namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AmazonAmazonSellerMainItemSerpElementItem : BaseAmazonSerpElementItem
    {
        /// <summary>
        /// alignment of the element in SERP
        /// <br/>possible values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// business name of the seller
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// url forwarding to the seller’s page on Amazon
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SellerUrl { get; set; }

        /// <summary>
        /// sender company name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ships_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShipsFrom { get; set; }

        /// <summary>
        /// product pricing details
        /// <br/>if there are no details, the value will be null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Price Price { get; set; }

        /// <summary>
        /// seller rating details
        /// <br/>seller popularity rate based on customer reviews
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// product condition
        /// <br/>condition of the product offered by the seller
        /// </summary>
        [Newtonsoft.Json.JsonProperty("condition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// product condition details
        /// <br/>expanded details on the condition of the product offered by the seller
        /// </summary>
        [Newtonsoft.Json.JsonProperty("condition_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConditionDescription { get; set; }

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