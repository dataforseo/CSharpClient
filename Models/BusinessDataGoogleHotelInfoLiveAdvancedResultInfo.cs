using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataGoogleHotelInfoLiveAdvancedResultInfo 
    {

        /// <summary>
        /// identifier received in a POST array
        /// <br/>this field will contain the hotel_identifier parameter specified when setting a task;
        /// <br/>example:
        /// <br/>CgoI-KWyzenM_MV3EAE
        /// </summary>
        [JsonProperty("hotel_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the result was received
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// hotel title
        /// <br/>the title of the hotel entity for which the results are collected
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class rating that ranges between 1-5 stars and displayed after review ratings in hotel summary
        /// </summary>
        [JsonProperty("stars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stars { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class rating that ranges between 1-5 stars and displayed after review ratings in the hotel summary
        /// </summary>
        [JsonProperty("stars_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string StarsDescription { get; set; }

        /// <summary>
        /// hotel address
        /// <br/>physical address of the hotel
        /// </summary>
        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// hotel phone number
        /// <br/>contact phone number of the hotel
        /// </summary>
        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// information about the hotel
        /// </summary>
        [JsonProperty("about", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HotelAboutInfo About { get; set; }

        /// <summary>
        /// information about the hotel location
        /// <br/>information about the location where the hotel is located
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        /// <summary>
        /// hotel reviews by criteria
        /// <br/>information about reviews of the hotel entity
        /// </summary>
        [JsonProperty("reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HotelReviewInfo Reviews { get; set; }

        /// <summary>
        /// images displayed in the hotel overview
        /// <br/>array containing URLs to images displayed in the hotel overview
        /// </summary>
        [JsonProperty("overview_images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> OverviewImages { get; set; }

        /// <summary>
        /// pricing details of the hotel entity
        /// <br/>contains information about the hotel’s prices
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