using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppDataGoogleAppReviewsTaskGetAdvancedResultInfo 
    {

        /// <summary>
        /// application id received in a POST array
        /// </summary>
        [JsonProperty("app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// search engine domain in a POST array
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

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
        /// title of the app
        /// <br/>title of the application for which the reviews are collected
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// rating of the app
        /// <br/>rating of the application for which the reviews are collected
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// the total number of reviews
        /// </summary>
        [JsonProperty("reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// the number of reviews items in the results array
        /// <br/>you can get more results by using the depth parameter when setting a task
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// found reviews
        /// <br/>you can get more results by using the depth parameter when setting a task
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GooglePlayReviewsSearch> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}