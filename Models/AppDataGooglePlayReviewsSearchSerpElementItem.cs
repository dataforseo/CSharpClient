using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppDataGooglePlayReviewsSearchSerpElementItem  : BaseAppDataSerpElementItem 
    {

        /// <summary>
        /// version of the app
        /// <br/>version of the app for which the review is submitted
        /// </summary>
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// date and time when the review was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// id of the review
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// number of helpful votes
        /// <br/>indicates how many users considered the review helpful and voted with the thumbs up icon
        /// </summary>
        [JsonProperty("helpful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? HelpfulCount { get; set; }

        /// <summary>
        /// content of the review
        /// </summary>
        [JsonProperty("review_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// user profile of the reviewer
        /// </summary>
        [JsonProperty("user_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppUserProfileInfo UserProfile { get; set; }

        /// <summary>
        /// response from the developer
        /// </summary>
        [JsonProperty("responses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ResponseDataInfo> Responses { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}