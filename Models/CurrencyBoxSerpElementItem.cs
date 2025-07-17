using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class CurrencyBoxSerpElementItem  : BaseSerpApiElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values;
        /// <br/>positions of elements with different type values are omitted from rank_group;
        /// <br/>always equals 0 for desktop
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// <br/>always equals 0 for desktop
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the value of the rating
        /// </summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        /// <summary>
        /// value converted to a requested currency
        /// <br/>indicates the exact value based on Google Fincance data at the time when our API pulled the results
        /// <br/>note that exchange rates displayed in the currency_box element may be delayed according to the Google Finance disclaimer
        /// </summary>
        [JsonProperty("converted_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ConvertedValue { get; set; }

        /// <summary>
        /// currency of the listed price
        /// <br/>ISO code of the currency applied to the price
        /// </summary>
        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// converted currency
        /// </summary>
        [JsonProperty("converted_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ConvertedCurrency { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// results table
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Table Table { get; set; }

        /// <summary>
        /// contains data provided in the graph of the element
        /// </summary>
        [JsonProperty("graph", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Graph Graph { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}