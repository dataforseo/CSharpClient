using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleFinanceDetailsSerpElementItem  : BaseGoogleFinanceSerpElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankAbsolute { get; set; }

        /// <summary>
        /// google finance badges relevant to the element
        /// <br/>example: Futures Contract
        /// </summary>
        [JsonProperty("badges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Badges { get; set; }

        /// <summary>
        /// value of the previous close
        /// </summary>
        [JsonProperty("previous_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PreviousClose { get; set; }

        /// <summary>
        /// value of the start day range
        /// </summary>
        [JsonProperty("start_day_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? StartDayRange { get; set; }

        /// <summary>
        /// value of the end day range
        /// </summary>
        [JsonProperty("end_day_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EndDayRange { get; set; }

        /// <summary>
        /// value of the start year range
        /// </summary>
        [JsonProperty("start_year_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? StartYearRange { get; set; }

        /// <summary>
        /// value of the end year range
        /// </summary>
        [JsonProperty("end_year_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EndYearRange { get; set; }

        /// <summary>
        /// market cap value
        /// </summary>
        [JsonProperty("market_cap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? MarketCap { get; set; }

        /// <summary>
        /// total volume value
        /// </summary>
        [JsonProperty("volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Volume { get; set; }

        /// <summary>
        /// average volume value
        /// </summary>
        [JsonProperty("avg_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AvgVolume { get; set; }

        /// <summary>
        /// price-earnings ratio
        /// </summary>
        [JsonProperty("pe_ratio", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PeRatio { get; set; }

        /// <summary>
        /// dividend yield value
        /// </summary>
        [JsonProperty("dividend_yield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? DividendYield { get; set; }

        /// <summary>
        /// primary exchange value
        /// </summary>
        [JsonProperty("primary_exchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryExchange { get; set; }

        /// <summary>
        /// year-to-date return value
        /// </summary>
        [JsonProperty("ytd_return", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? YtdReturn { get; set; }

        /// <summary>
        /// expense ratio value
        /// </summary>
        [JsonProperty("expense_ratio", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ExpenseRatio { get; set; }

        /// <summary>
        /// category name
        /// </summary>
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }
        [JsonProperty("net_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NetAssets { get; set; }

        /// <summary>
        /// yield value
        /// </summary>
        [JsonProperty("yield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Yield { get; set; }

        /// <summary>
        /// front load value
        /// </summary>
        [JsonProperty("front_load", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? FrontLoad { get; set; }

        /// <summary>
        /// name of the relevant market segment
        /// </summary>
        [JsonProperty("market_segment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MarketSegment { get; set; }

        /// <summary>
        /// open interest value
        /// </summary>
        [JsonProperty("open_interest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? OpenInterest { get; set; }

        /// <summary>
        /// settlement price value
        /// </summary>
        [JsonProperty("settlement_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? SettlementPrice { get; set; }

        /// <summary>
        /// climate change score by carbon disclosure project methodology
        /// </summary>
        [JsonProperty("cdp_climate_change_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CdpClimateChangeScore { get; set; }

        /// <summary>
        /// currency of the metrics
        /// </summary>
        [JsonProperty("metrics_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MetricsCurrency { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}