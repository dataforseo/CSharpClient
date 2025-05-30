using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageRedirectChainsItem 
    {

        /// <summary>
        /// indicates if redirects in chain start and end at the same URL
        /// <br/>if true, the last URL from the chain redirects back to the original URL
        /// </summary>
        [JsonProperty("is_redirect_loop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRedirectLoop { get; set; }

        /// <summary>
        /// contains links that form a chain
        /// </summary>
        [JsonProperty("chain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseOnPageLinkItemInfo> Chain { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}