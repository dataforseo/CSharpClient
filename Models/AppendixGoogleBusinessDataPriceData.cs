namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixGoogleBusinessDataPriceData
    {
        [Newtonsoft.Json.JsonProperty("hotel_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixHotelInfoGoogleBusinessDataPriceData HotelInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("hotel_searches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixHotelSearchesGoogleBusinessDataPriceData HotelSearches { get; set; }

        [Newtonsoft.Json.JsonProperty("my_business_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixHotelSearchesGoogleBusinessDataPriceData MyBusinessInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("my_business_updates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixHotelSearchesGoogleBusinessDataPriceData MyBusinessUpdates { get; set; }

        [Newtonsoft.Json.JsonProperty("reviews", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixHotelSearchesGoogleBusinessDataPriceData Reviews { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}