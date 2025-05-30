using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class HotelAmenityItemInfo 
    {

        /// <summary>
        /// standardised amenity name
        /// </summary>
        [JsonProperty("amenity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Amenity { get; set; }

        /// <summary>
        /// displayed amenity name
        /// </summary>
        [JsonProperty("amenity_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AmenityLabel { get; set; }

        /// <summary>
        /// standardised details about the amenity
        /// </summary>
        [JsonProperty("hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Hint { get; set; }

        /// <summary>
        /// displayed details about the amenity
        /// </summary>
        [JsonProperty("hint_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HintLabel { get; set; }

        /// <summary>
        /// indicates whether the amenity is available in the hotel
        /// </summary>
        [JsonProperty("is_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}