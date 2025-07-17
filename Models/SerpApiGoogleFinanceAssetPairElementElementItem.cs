using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceAssetPairElementElementItem  : BaseSerpApiGoogleFinanceElementItem 
    {

        /// <summary>
        /// identifier of the base asset in a pair
        /// <br/>example: EUR
        /// </summary>
        [JsonProperty("base_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSymbol { get; set; }

        /// <summary>
        /// identifier of the quote asset in a pair
        /// <br/>example: USD
        /// </summary>
        [JsonProperty("quote_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string QuoteSymbol { get; set; }

        /// <summary>
        /// full name of the base asset in a pair
        /// <br/>example: Euro
        /// </summary>
        [JsonProperty("base_display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BaseDisplayName { get; set; }

        /// <summary>
        /// full name of the base asset in a pair
        /// <br/>example: Euro
        /// </summary>
        [JsonProperty("quote_display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string QuoteDisplayName { get; set; }

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
        /// identifier of the element
        /// <br/>full identifier of the element that consists from ticker and market_identifier
        /// <br/>example: PX1:INDEXDB
        /// </summary>
        [JsonProperty("identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// name of the market index as displayed on Google Finance
        /// <br/>example: CAC 40
        /// </summary>
        [JsonProperty("displayed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedName { get; set; }

        /// <summary>
        /// URL to the page of the market index on Google Finance
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// location of the market index
        /// <br/>example: Europe/Paris
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// growth trend of the market index
        /// <br/>possible values: up, down, stable
        /// </summary>
        [JsonProperty("trend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Trend { get; set; }

        /// <summary>
        /// date and time of the value readout
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2025-02-10 09:40:00 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// percentage of change in value of the market index
        /// </summary>
        [JsonProperty("percentage_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentageDelta { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}