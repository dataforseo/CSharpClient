using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleAdsAdvertisersAdsMultiAccountAdvertiserSerpElementItem  : BaseGoogleAdsAdvertisersSerpElementItem 
    {

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// advertiser location
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// ads count
        /// <br/>the approximate number of ads that are run by the advertiser across all available Google Ads platforms
        /// </summary>
        [JsonProperty("approx_ads_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ApproxAdsCount { get; set; }

        /// <summary>
        /// associated advertiser accounts
        /// <br/>contains objects with data on associated advertiser accounts
        /// </summary>
        [JsonProperty("advertisers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Advertiser> Advertisers { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}