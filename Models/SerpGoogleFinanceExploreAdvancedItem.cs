using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpGoogleFinanceExploreAdvancedItem 
    {

        /// <summary>
        /// array of items
        /// <br/>this array can take the following names: most_active, gainers, losers
        /// </summary>
        [JsonProperty("most_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleFinanceMarketTrendsElement> MostActive { get; set; }
        [JsonProperty("gainers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleFinanceMarketTrendsElement> Gainers { get; set; }
        [JsonProperty("losers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleFinanceMarketTrendsElement> Losers { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}