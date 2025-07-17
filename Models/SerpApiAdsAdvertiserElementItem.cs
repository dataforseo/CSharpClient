using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiAdsAdvertiserElementItem  : BaseSerpApiAdsAdvertiserElementItem 
    {

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// unique identifier of the advertiser account
        /// <br/>can be used to obtain data on advertising campaigns from the Google Ads Search endpoint
        /// </summary>
        [JsonProperty("advertiser_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdvertiserId { get; set; }

        /// <summary>
        /// advertiser location
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// verified advertiser account
        /// <br/>equals true if advertiser account is verified by Google Ads
        /// </summary>
        [JsonProperty("verified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        /// <summary>
        /// ads count
        /// <br/>the approximate number of ads that are run by the advertiser across all available Google Ads platforms
        /// </summary>
        [JsonProperty("approx_ads_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ApproxAdsCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}