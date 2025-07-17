using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiAdsDomainElementItem  : BaseSerpApiAdsAdvertiserElementItem 
    {

        /// <summary>
        /// domain in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}