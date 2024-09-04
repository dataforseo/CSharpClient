namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HotelAboutInfo
    {
        /// <summary>
        /// description of the hotel
        /// <br/>the description of the hotel entity for which the results are collected
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// additional description of the hotel
        /// <br/>details about the hotel provided in addition to the description
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_descriptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SubDescriptions { get; set; }

        /// <summary>
        /// hotel check-in time
        /// <br/>check-in time indicated in the hotel listing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_in_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WorkTimeInfo CheckInTime { get; set; }

        /// <summary>
        /// hotel check-out time
        /// <br/>check-out time indicated in the hotel listing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_out_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WorkTimeInfo CheckOutTime { get; set; }

        /// <summary>
        /// full address of the hotel
        /// <br/>address of the hotel indicated in the standardised format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullAddress { get; set; }

        /// <summary>
        /// hotel domain
        /// <br/>domain of the hotel’s website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// hotel url
        /// <br/>URL to the hotel’s website indicated in the listing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// hotel amenities
        /// <br/>information about hotel amenities
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amenities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HotelAmenityInfo> Amenities { get; set; }

        /// <summary>
        /// hotel amenities
        /// <br/>information about hotel amenities labelled as “popular”
        /// </summary>
        [Newtonsoft.Json.JsonProperty("popular_amenities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HotelAmenityItemInfo> PopularAmenities { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}