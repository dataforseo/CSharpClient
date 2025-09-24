using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleShoppingSellersShopsListElementItem  : BaseMerchantGoogleShoppingSellersElementItem 
    {

        /// <summary>
        /// monthly price multiplier
        /// <br/>indicates the number of months covered by the monthly payment for the product
        /// </summary>
        [JsonProperty("price_multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMultiplier { get; set; }

        /// <summary>
        /// installment details as displayed in the results
        /// <br/>shows how the product price can be broken down into monthly payments, if applicable
        /// </summary>
        [JsonProperty("displayed_payment_breakdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedPaymentBreakdown { get; set; }

        /// <summary>
        /// indicated condition of the product
        /// <br/>possible values: Used, Refurbished, New, null
        /// </summary>
        [JsonProperty("product_condition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCondition { get; set; }

        /// <summary>
        /// data from annotations and badges with special offers
        /// <br/>if there is no annotation for this product, the value will be null
        /// <br/>examples: LOW PRICE, SPECIAL OFFER, SALE, PRICE DROP
        /// </summary>
        [JsonProperty("product_annotation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductAnnotation { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}