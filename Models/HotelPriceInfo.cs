using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HotelPriceInfo 
    {

        /// <summary>
        /// price per night
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// full price per night without a discount applied
        /// </summary>
        [JsonProperty("price_without_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceWithoutDiscount { get; set; }

        /// <summary>
        /// price currency
        /// <br/>USD is applied by default, unless specified in the POST array
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// text about a discount applied
        /// </summary>
        [JsonProperty("discount_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountText { get; set; }

        /// <summary>
        /// check-in date and time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("check_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckIn { get; set; }

        /// <summary>
        /// check-out date and time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("check_out", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckOut { get; set; }

        /// <summary>
        /// number of hotel visitors for this price
        /// </summary>
        [JsonProperty("visitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Visitors { get; set; }

        /// <summary>
        /// encountered item types
        /// <br/>types of search engine results encountered in the items array;
        /// <br/>possible item types: hotel_search_item
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HotelPriceItemInfo> Items { get; set; }
        [JsonProperty("prices_by_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<PricesByDates> PricesByDates { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}