using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleFinanceHeroGroupsSerpElementItem  : BaseGoogleFinanceSerpElementItem 
    {

        /// <summary>
        /// financial markets data
        /// <br/>array of items containing market indexes and other financial information related to these indexes
        /// </summary>
        [JsonProperty("markets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleFinanceMarketsInfo> Markets { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}