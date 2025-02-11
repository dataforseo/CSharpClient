namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HotelAmenityItemInfo
    {
        /// <summary>
        /// standardised amenity name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amenity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Amenity { get; set; }

        /// <summary>
        /// displayed amenity name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amenity_label", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmenityLabel { get; set; }

        /// <summary>
        /// standardised details about the amenity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hint { get; set; }

        /// <summary>
        /// displayed details about the amenity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hint_label", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HintLabel { get; set; }

        /// <summary>
        /// indicates whether the amenity is available in the hotel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_available", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}