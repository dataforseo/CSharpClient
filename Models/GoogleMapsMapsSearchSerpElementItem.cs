using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleMapsMapsSearchSerpElementItem  : BaseGoogleMapsSerpElementItem 
    {

        /// <summary>
        /// original title of the element
        /// <br/>original title not translated by Google
        /// </summary>
        [JsonProperty("original_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// URL of the preferred contact page
        /// </summary>
        [JsonProperty("contact_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContactUrl { get; set; }

        /// <summary>
        /// URL of the user’s or entity’s Local Guides profile, if available
        /// </summary>
        [JsonProperty("contributor_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContributorUrl { get; set; }

        /// <summary>
        /// URL in the ‘book online’ button of the element
        /// <br/>URL directing users to the online booking or order page of the business entity
        /// </summary>
        [JsonProperty("book_online_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BookOnlineUrl { get; set; }

        /// <summary>
        /// hotel class rating
        /// <br/>class ratings range between 1-5 stars, learn more
        /// <br/>if there is no hotel class rating information, the value will be null
        /// </summary>
        [JsonProperty("hotel_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HotelRating { get; set; }

        /// <summary>
        /// property price level
        /// <br/>can take values: inexpensive, moderate, expensive, very_expensive
        /// <br/>if there is no price level information, the value will be null
        /// </summary>
        [JsonProperty("price_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PriceLevel { get; set; }

        /// <summary>
        /// element snippet
        /// <br/>contains the address and other information about the local establishment featured in the element
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// address line
        /// <br/>address of the local establishment featured in the element
        /// </summary>
        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// object containing address components of the local establishment
        /// </summary>
        [JsonProperty("address_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressInfo AddressInfo { get; set; }

        /// <summary>
        /// unique place identifier
        /// <br/>place id of the local establishment featured in the element
        /// </summary>
        [JsonProperty("place_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceId { get; set; }

        /// <summary>
        /// phone number
        /// <br/>phone number of the local establishment featured in the element
        /// </summary>
        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// URL of the main image featured in Google My Business profile
        /// </summary>
        [JsonProperty("main_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainImage { get; set; }

        /// <summary>
        /// total count of images featured in Google My Business profile
        /// </summary>
        [JsonProperty("total_photos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPhotos { get; set; }

        /// <summary>
        /// business category
        /// <br/>Google My Business general category that best describes the services provided by the business entity
        /// </summary>
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// additional business categories
        /// <br/>additional Google My Business categories that describe the services provided by the business entity in more detail
        /// </summary>
        [JsonProperty("additional_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AdditionalCategories { get; set; }

        /// <summary>
        /// global category IDs
        /// <br/>universal category IDs that do not change based on the selected country
        /// </summary>
        [JsonProperty("category_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> CategoryIds { get; set; }

        /// <summary>
        /// open hours
        /// <br/>information about work hours of the local establishment
        /// </summary>
        [JsonProperty("work_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WorkHours WorkHours { get; set; }

        /// <summary>
        /// the unique identifier of the element in SERP
        /// </summary>
        [JsonProperty("feature_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureId { get; set; }

        /// <summary>
        /// google-defined client id
        /// <br/>unique id of a local establishment;
        /// <br/>can be used with Google Reviews API to get a full list of reviews
        /// </summary>
        [JsonProperty("cid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cid { get; set; }

        /// <summary>
        /// latitude coordinate of the local establishments in google maps
        /// <br/>example:
        /// <br/>'latitude': 51.584091
        /// </summary>
        [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Latitude { get; set; }

        /// <summary>
        /// longitude coordinate of the local establishment in google maps
        /// <br/>example:
        /// <br/>'longitude': -0.31365919999999997
        /// </summary>
        [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Longitude { get; set; }

        /// <summary>
        /// indicates whether ownership of this local establishment is claimed
        /// </summary>
        [JsonProperty("is_claimed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsClaimed { get; set; }

        /// <summary>
        /// Google local justifications
        /// <br/>snippets of text that “justify” why the business is showing up for search query
        /// </summary>
        [JsonProperty("local_justifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LocalJustificationInfo> LocalJustifications { get; set; }

        /// <summary>
        /// indicates whether this local establishment is a directory
        /// </summary>
        [JsonProperty("is_directory_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDirectoryItem { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}