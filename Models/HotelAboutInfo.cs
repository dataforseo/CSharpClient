using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HotelAboutInfo 
    {

        /// <summary>
        /// description of the hotel
        /// <br/>the description of the hotel entity for which the results are collected
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// additional description of the hotel
        /// <br/>details about the hotel provided in addition to the description
        /// </summary>
        [JsonProperty("sub_descriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SubDescriptions { get; set; }

        /// <summary>
        /// hotel check-in time
        /// <br/>check-in time indicated in the hotel listing
        /// </summary>
        [JsonProperty("check_in_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TimeInfo CheckInTime { get; set; }

        /// <summary>
        /// hotel check-out time
        /// <br/>check-out time indicated in the hotel listing
        /// </summary>
        [JsonProperty("check_out_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TimeInfo CheckOutTime { get; set; }

        /// <summary>
        /// full address of the hotel
        /// <br/>address of the hotel indicated in the standardised format
        /// </summary>
        [JsonProperty("full_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FullAddress { get; set; }

        /// <summary>
        /// hotel domain
        /// <br/>domain of the hotel’s website
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// hotel url
        /// <br/>URL to the hotel’s website indicated in the listing
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// hotel amenities
        /// <br/>information about hotel amenities
        /// </summary>
        [JsonProperty("amenities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HotelAmenityInfo> Amenities { get; set; }

        /// <summary>
        /// hotel amenities
        /// <br/>information about hotel amenities labelled as “popular”
        /// </summary>
        [JsonProperty("popular_amenities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HotelAmenityItemInfo> PopularAmenities { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}