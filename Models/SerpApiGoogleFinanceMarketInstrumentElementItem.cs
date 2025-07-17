using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceMarketInstrumentElementItem  : BaseSerpApiGoogleFinanceTickerSearchElementItem 
    {

        /// <summary>
        /// ticker of the market index
        /// <br/>example: DAX
        /// </summary>
        [JsonProperty("ticker", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ticker { get; set; }

        /// <summary>
        /// value of the base asset compared to the quote asset
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// change in price
        /// <br/>change in price at a given timestamp
        /// </summary>
        [JsonProperty("price_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceDelta { get; set; }

        /// <summary>
        /// price currency
        /// <br/>example: USD
        /// </summary>
        [JsonProperty("price_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PriceCurrency { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}