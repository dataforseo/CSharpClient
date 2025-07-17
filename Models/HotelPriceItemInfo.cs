using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HotelPriceItemInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// title of the hotel
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// price per night
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// price currency
        /// <br/>USD is applied by default, unless specified in the POST array
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// third-party page url
        /// <br/>URL to the third-party website page with pricing information
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// third-party domain
        /// <br/>domain of the third-party website page with pricing information
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// indicates a paid hotel listing
        /// <br/>if true, related hotel_search_item is a paid ad
        /// <br/>if false, related hotel_search_item is an organic hotel listing
        /// </summary>
        [JsonProperty("is_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// date until which free cancellation is available
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>equals null if free cancellation is not available for the selected dates
        /// </summary>
        [JsonProperty("free_cancellation_until", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FreeCancellationUntil { get; set; }

        /// <summary>
        /// featured price offers
        /// </summary>
        [JsonProperty("offers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HotelInfoPriceOffer> Offers { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}