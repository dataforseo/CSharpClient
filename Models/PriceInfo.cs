namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PriceInfo
    {
        /// <summary>
        /// current price
        /// <br/>indicates the current price of the product or service featured in the result
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Current { get; set; }

        /// <summary>
        /// regular price
        /// <br/>indicates the regular price of the product or service with no discounts applied
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regular", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Regular { get; set; }

        /// <summary>
        /// the maximum price
        /// <br/>the maximum price of the product or service as indicated in the result
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxValue { get; set; }

        /// <summary>
        /// currency of the listed price
        /// <br/>ISO code of the currency applied to the price
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// price is provided as a range
        /// <br/>indicates whether a price is provided in a range
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_price_range", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPriceRange { get; set; }

        /// <summary>
        /// price string in the result
        /// <br/>raw price string as provided in the result
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayed_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayedPrice { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}