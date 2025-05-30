using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class MerchantGoogleSellersAdUrlResultInfo 
    {

        /// <summary>
        /// unique ad click referral parameter
        /// </summary>
        [JsonProperty("ad_aclk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdAclk { get; set; }

        /// <summary>
        /// full URL of the advertisement
        /// </summary>
        [JsonProperty("ad_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdUrl { get; set; }

        /// <summary>
        /// URLs where the link from Google Shopping redirects before reaching a final URL
        /// <br/>includes up to 10 URLs of the ad’s redirect path to the seller’s ad_url
        /// </summary>
        [JsonProperty("ad_url_redirects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AdUrlRedirects { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}