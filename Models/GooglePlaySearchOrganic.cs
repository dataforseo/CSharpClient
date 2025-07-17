using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GooglePlaySearchOrganic 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// id of the app
        /// </summary>
        [JsonProperty("app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// title of the app
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL to the app page on Google Play
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL to the app icon
        /// </summary>
        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// the total number of reviews of the app
        /// </summary>
        [JsonProperty("reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// average rating of the app
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// indicates whether the app is free
        /// </summary>
        [JsonProperty("is_free", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        /// <summary>
        /// price of the app
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// name of the app developer
        /// </summary>
        [JsonProperty("developer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Developer { get; set; }

        /// <summary>
        /// URL to the developer page on Google Play
        /// </summary>
        [JsonProperty("developer_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}