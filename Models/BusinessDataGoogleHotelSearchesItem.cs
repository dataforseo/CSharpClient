using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataGoogleHotelSearchesItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// unique identifier of a hotel entity in Google search
        /// <br/>example:
        /// <br/>CgoI-KWyzenM_MV3EAE
        /// </summary>
        [JsonProperty("hotel_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// title of the hotel
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class rating that ranges between 1-5 stars
        /// </summary>
        [JsonProperty("stars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Stars { get; set; }

        /// <summary>
        /// indicates a paid hotel listing
        /// <br/>if true, related hotel_search_item is a paid ad
        /// <br/>if false, related hotel_search_item is an organic hotel listing
        /// </summary>
        [JsonProperty("is_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// GPS coordinates of the hotel’s location
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GpsCoordinatesLocationInfo Location { get; set; }

        /// <summary>
        /// hotel reviews and rating information
        /// </summary>
        [JsonProperty("reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HotelReviewInfo Reviews { get; set; }

        /// <summary>
        /// featured images for a hotel
        /// </summary>
        [JsonProperty("overview_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OverviewImages { get; set; }

        /// <summary>
        /// hotel price
        /// </summary>
        [JsonProperty("prices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HotelPriceInfo Prices { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}