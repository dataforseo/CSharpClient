using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Markets 
    {

        /// <summary>
        /// financial market identifier
        /// <br/>possible values: US, Europe, Asia, Currencies, Crypto, Futures
        /// </summary>
        [JsonProperty("market", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Market { get; set; }

        /// <summary>
        /// elements of search results found in SERP
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseGoogleFinanceSerpElementItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}