namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AmazonDeliveryInfo
    {
        /// <summary>
        /// message accompanying the delivery information as posted by the seller
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryMessage { get; set; }

        /// <summary>
        /// the earliest date when the product can be shipped
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryDateFrom { get; set; }

        /// <summary>
        /// the latest date when the product can be delivered
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryDateTo { get; set; }

        /// <summary>
        /// the earliest date when the product can be delivered with a fast delivery option
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fastest_delivery_date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FastestDeliveryDateFrom { get; set; }

        /// <summary>
        /// the latest date when the product can be delivered with a fast delivery option
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fastest_delivery_date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FastestDeliveryDateTo { get; set; }

        /// <summary>
        /// price for the delivery
        /// <br/>price of the delivery based on the location you specified in the POST request;
        /// <br/>if free delivery is available, the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PriceInfo DeliveryPrice { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}