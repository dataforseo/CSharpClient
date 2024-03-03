namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleHotelSearchesItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// unique identifier of a hotel entity in Google search
        /// <br/>example:
        /// <br/>CgoI-KWyzenM_MV3EAE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hotel_identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// title of the hotel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class rating that ranges between 1-5 stars
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stars", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Stars { get; set; }

        /// <summary>
        /// indicates a paid hotel listing
        /// <br/>if true, related hotel_search_item is a paid ad
        /// <br/>if false, related hotel_search_item is an organic hotel listing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_paid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// GPS coordinates of the hotel’s location
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GpsCoordinatesLocationInfo Location { get; set; }

        /// <summary>
        /// hotel reviews and rating information
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviews", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HotelReviewInfo Reviews { get; set; }

        /// <summary>
        /// featured images for a hotel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overview_images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> OverviewImages { get; set; }

        /// <summary>
        /// hotel price
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HotelPriceInfo Prices { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}