using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleHotelInfoTaskGetAdvancedResultInfo
    {
        /// <summary>
        /// unique hotel identifier
        /// <br/>this field will contain the hotel_identifier parameter;
        /// <br/>example:
        /// <br/>CgoI-KWyzenM_MV3EAE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hotel_identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the result was received
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// hotel title
        /// <br/>the title of the hotel entity for which the results are collected
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class rating that ranges between 1-5 stars and displayed after review ratings in hotel summary
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stars", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Stars { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class rating that ranges between 1-5 stars and displayed after review ratings in the hotel summary
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stars_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StarsDescription { get; set; }

        /// <summary>
        /// hotel address
        /// <br/>physical address of the hotel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// hotel phone number
        /// <br/>contact phone number of the hotel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// information about the hotel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("about", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HotelAboutInfo About { get; set; }

        /// <summary>
        /// information about the hotel location
        /// <br/>information about the location where the hotel is located
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HotelLocationInfo Location { get; set; }

        /// <summary>
        /// hotel reviews by criteria
        /// <br/>information about reviews of the hotel entity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviews", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HotelReviewInfo Reviews { get; set; }

        /// <summary>
        /// images displayed in the hotel overview
        /// <br/>array containing URLs to images displayed in the hotel overview
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overview_images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> OverviewImages { get; set; }

        /// <summary>
        /// pricing details of the hotel entity
        /// <br/>contains information about the hotel’s prices
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HotelPriceInfo Prices { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}