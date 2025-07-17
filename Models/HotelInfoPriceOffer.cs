using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HotelInfoPriceOffer 
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
        /// url of the price offer
        /// <br/>URL to the page of the website where price offer appears
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// the maximal number of visitors
        /// <br/>the maximum number of visitors for which the price offer is valid
        /// </summary>
        [JsonProperty("max_visitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxVisitors { get; set; }

        /// <summary>
        /// price offer images
        /// <br/>URLs of the images featured in the price offer
        /// </summary>
        [JsonProperty("offer_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OfferImages { get; set; }

        /// <summary>
        /// date until free cancellation is available
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>equals null if free cancellation is not available for the selected dates
        /// </summary>
        [JsonProperty("free_cancellation_until", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FreeCancellationUntil { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}