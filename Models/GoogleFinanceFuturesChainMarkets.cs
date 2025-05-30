using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleFinanceFuturesChainMarkets 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// futures’ date and time of expiration
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2025-02-10 09:40:00 +00:00
        /// </summary>
        [JsonProperty("expiration_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTimestamp { get; set; }

        /// <summary>
        /// futures’ symbol
        /// </summary>
        [JsonProperty("symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        /// <summary>
        /// price of the market instrument
        /// <br/>price of the market instrument at a given timestamp
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Price { get; set; }

        /// <summary>
        /// currency of the price value
        /// </summary>
        [JsonProperty("price_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// change in price of the market instrument
        /// <br/>change in price at a given timestamp
        /// </summary>
        [JsonProperty("price_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PriceDelta { get; set; }

        /// <summary>
        /// percentage of change in value of the market index
        /// </summary>
        [JsonProperty("percentage_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PercentageDelta { get; set; }

        /// <summary>
        /// growth trend of the market index
        /// <br/>possible values: up, down, stable
        /// </summary>
        [JsonProperty("trend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Trend { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}