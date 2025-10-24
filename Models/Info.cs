using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Info 
    {
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }
        [JsonProperty("category_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryIds { get; set; }
        [JsonProperty("additional_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalCategories { get; set; }
        [JsonProperty("cid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cid { get; set; }
        [JsonProperty("feature_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureId { get; set; }
        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }
        [JsonProperty("address_info.borough", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AddressInfoBorough { get; set; }
        [JsonProperty("address_info.address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AddressInfoAddress { get; set; }
        [JsonProperty("address_info.city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AddressInfoCity { get; set; }
        [JsonProperty("address_info.zip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AddressInfoZip { get; set; }
        [JsonProperty("address_info.region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AddressInfoRegion { get; set; }
        [JsonProperty("address_info.country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AddressInfoCountryCode { get; set; }
        [JsonProperty("place_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceId { get; set; }
        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }
        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Logo { get; set; }
        [JsonProperty("main_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainImage { get; set; }
        [JsonProperty("total_photos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPhotos { get; set; }
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }
        [JsonProperty("latitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }
        [JsonProperty("longitude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }
        [JsonProperty("is_claimed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IsClaimed { get; set; }
        [JsonProperty("rating.rating_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingRatingType { get; set; }
        [JsonProperty("rating.value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingValue { get; set; }
        [JsonProperty("rating.votes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingVotesCount { get; set; }

        /// <summary>
        /// the maximum value for a rating_type
        /// </summary>
        [JsonProperty("rating.rating_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RatingRatingMax { get; set; }
        [JsonProperty("rating_distribution.1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingDistribution1 { get; set; }
        [JsonProperty("rating_distribution.2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingDistribution2 { get; set; }
        [JsonProperty("rating_distribution.3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingDistribution3 { get; set; }
        [JsonProperty("rating_distribution.4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingDistribution4 { get; set; }
        [JsonProperty("rating_distribution.5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RatingDistribution5 { get; set; }
        [JsonProperty("work_time.work_hours.current_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WorkTimeWorkHoursCurrentStatus { get; set; }
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }
        [JsonProperty("price_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PriceLevel { get; set; }
        [JsonProperty("hotel_rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HotelRating { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("contact_info.type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContactInfoType { get; set; }
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