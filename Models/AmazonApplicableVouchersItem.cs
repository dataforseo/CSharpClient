using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonApplicableVouchersItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// text of the voucher
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// value of the fixed discount
        /// </summary>
        [JsonProperty("fixed_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? FixedDiscount { get; set; }

        /// <summary>
        /// currency code of the fixed discount
        /// </summary>
        [JsonProperty("fixed_discount_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FixedDiscountCurrency { get; set; }

        /// <summary>
        /// value of the percentage discount
        /// <br/>if the discount is fixed, the value will be null
        /// </summary>
        [JsonProperty("percentage_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PercentageDiscount { get; set; }

        /// <summary>
        /// important details about the terms of discount vouchers
        /// </summary>
        [JsonProperty("important_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImportantDetails { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}