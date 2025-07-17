using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SpecialOfferInfo 
    {

        /// <summary>
        /// product title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// subtitle of the special offer
        /// </summary>
        [JsonProperty("sub_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SubTitle { get; set; }

        /// <summary>
        /// amount of the fixed discount
        /// </summary>
        [JsonProperty("fixed_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FixedDiscount { get; set; }

        /// <summary>
        /// currency of the fixed discount
        /// </summary>
        [JsonProperty("fixed_discount_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FixedDiscountCurrency { get; set; }

        /// <summary>
        /// percentage of the discount
        /// </summary>
        [JsonProperty("percentage_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentageDiscount { get; set; }

        /// <summary>
        /// code of coupon discount
        /// </summary>
        [JsonProperty("coupon_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CouponCode { get; set; }

        /// <summary>
        /// information on coupon discount
        /// </summary>
        [JsonProperty("coupon_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CouponInfo { get; set; }

        /// <summary>
        /// URL to the product page on the seller’s website
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}