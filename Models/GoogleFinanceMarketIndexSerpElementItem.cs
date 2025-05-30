using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleFinanceMarketIndexSerpElementItem  : BaseGoogleFinanceTickerSearchSerpElementItem 
    {

        /// <summary>
        /// ticker of the market index
        /// <br/>example: DAX
        /// </summary>
        [JsonProperty("ticker", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ticker { get; set; }

        /// <summary>
        /// market identifier
        /// <br/>example: INDEXDB
        /// </summary>
        [JsonProperty("market_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MarketIdentifier { get; set; }

        /// <summary>
        /// value of the market index
        /// <br/>numerical value of the index at a given timestamp
        /// </summary>
        [JsonProperty("index_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? IndexValue { get; set; }

        /// <summary>
        /// change in value of the market index
        /// <br/>change in the index_value at a given timestamp
        /// </summary>
        [JsonProperty("index_value_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? IndexValueDelta { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}