using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MerchantGoogleSellersAdUrlResultInfo
    {
        /// <summary>
        /// unique ad click referral parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_aclk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdAclk { get; set; }

        /// <summary>
        /// full URL of the advertisement
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdUrl { get; set; }

        /// <summary>
        /// URLs where the link from Google Shopping redirects before reaching a final URL
        /// <br/>includes up to 10 URLs of the ad’s redirect path to the seller’s ad_url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_url_redirects", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AdUrlRedirects { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}