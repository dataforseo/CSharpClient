using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataBusinessListingsSearchLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// title of the element in SERP
        /// <br/>the name of the business entity for which the results are collected
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// original title of the element
        /// <br/>original title not translated by Google
        /// </summary>
        [JsonProperty("original_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// description of the element in SERP
        /// <br/>the description of the business entity for which the results are collected
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// business category
        /// <br/>Google My Business general category that best describes the services provided by the business entity
        /// </summary>
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// global category IDs
        /// <br/>universal category IDs that do not change based on the selected country
        /// </summary>
        [JsonProperty("category_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> CategoryIds { get; set; }

        /// <summary>
        /// additional business categories
        /// <br/>additional Google My Business categories that describe the services provided by the business entity in more detail
        /// </summary>
        [JsonProperty("additional_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AdditionalCategories { get; set; }

        /// <summary>
        /// google-defined client id
        /// <br/>unique id of a local establishment
        /// <br/>learn more about the identifier in this help center article
        /// </summary>
        [JsonProperty("cid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cid { get; set; }

        /// <summary>
        /// the unique identifier of the element in SERP
        /// <br/>learn more about the identifier in this help center article
        /// </summary>
        [JsonProperty("feature_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureId { get; set; }

        /// <summary>
        /// address of the business entity
        /// </summary>
        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// object containing address components of the business entity
        /// </summary>
        [JsonProperty("address_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressInfo AddressInfo { get; set; }

        /// <summary>
        /// unique place identifier
        /// <br/>place id of the local establishment featured in the element
        /// <br/>learn more about the identifier in this help center article
        /// </summary>
        [JsonProperty("place_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceId { get; set; }

        /// <summary>
        /// phone number of the business entity
        /// </summary>
        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// absolute url of the business entity
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain of the business entity
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// URL of the logo featured in Google My Business profile
        /// </summary>
        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }

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
        /// additional information on the business entity
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

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
        /// shows whether the entity is verified by its owner on Google Maps
        /// </summary>
        [JsonProperty("is_claimed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsClaimed { get; set; }

        /// <summary>
        /// service details in a form of user-reviewed checks;
        /// <br/>service details of a business entity displayed in a form of checks and based on user feedback and business category
        /// </summary>
        [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessDataAttributesInfo Attributes { get; set; }

        /// <summary>
        /// keywords mentioned in customer reviews
        /// <br/>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword
        /// <br/>example: 
        /// <br/>'place_topics': {
        /// <br/>'egg roll': 48,
        /// <br/>'birthday': 33
        /// <br/>}
        /// </summary>
        [JsonProperty("place_topics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> PlaceTopics { get; set; }

        /// <summary>
        /// the element’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessDataRatingInfo Rating { get; set; }

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
        /// the distribution of ratings of the business entity
        /// <br/>the object displays the number of 1-star to 5-star ratings, as reviewed by users
        /// </summary>
        [JsonProperty("rating_distribution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, int?> RatingDistribution { get; set; }

        /// <summary>
        /// related business entities
        /// </summary>
        [JsonProperty("people_also_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<PeopleAlsoSearch> PeopleAlsoSearch { get; set; }

        /// <summary>
        /// work time details
        /// <br/>information related to operational hours of the business entity
        /// </summary>
        [JsonProperty("work_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessWorkHoursInfo WorkTime { get; set; }

        /// <summary>
        /// popular times
        /// <br/>information related to busy hours of the business entity
        /// </summary>
        [JsonProperty("popular_times", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PopularTimes PopularTimes { get; set; }

        /// <summary>
        /// available interactions with the business
        /// <br/>list of options to interact with the business directly from search results
        /// </summary>
        [JsonProperty("local_business_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseLocalBusinessLink> LocalBusinessLinks { get; set; }

        /// <summary>
        /// available contacts of the business
        /// <br/>list of contacts to interact with the business
        /// </summary>
        [JsonProperty("contact_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BusinessDataContactInfo> ContactInfo { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the data was last updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2023-01-26 09:03:15 +00:00
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// date and time when our crawler found the business listing element for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2023-03-11 10:04:11 +00:00
        /// </summary>
        [JsonProperty("first_seen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstSeen { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}