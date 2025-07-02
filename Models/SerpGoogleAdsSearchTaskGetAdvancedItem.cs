using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpGoogleAdsSearchTaskGetAdvancedItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
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
        /// unique identifier of the advertiser account
        /// </summary>
        [JsonProperty("advertiser_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdvertiserId { get; set; }

        /// <summary>
        /// unique identifier of the advertisement
        /// </summary>
        [JsonProperty("creative_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CreativeId { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// search URL with refinement parameters
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// verified advertiser account
        /// <br/>equals true if advertiser account is verified by Google Ads
        /// </summary>
        [JsonProperty("verified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// format of the advertisement
        /// <br/>possible values: text, image, video
        /// </summary>
        [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// preview image of the advertisement
        /// </summary>
        [JsonProperty("preview_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PreviewImage PreviewImage { get; set; }

        /// <summary>
        /// url pointing to the ad preview
        /// </summary>
        [JsonProperty("preview_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// date and time when the ad was shown for the first time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// </summary>
        [JsonProperty("first_shown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstShown { get; set; }

        /// <summary>
        /// date and time when the ad was shown the last time
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// </summary>
        [JsonProperty("last_shown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastShown { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}