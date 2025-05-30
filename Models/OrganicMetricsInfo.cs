using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OrganicMetricsInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date and time of the value readout
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2025-02-10 09:40:00 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// revenue value
        /// </summary>
        [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Revenue { get; set; }

        /// <summary>
        /// change in revenue
        /// </summary>
        [JsonProperty("revenue_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? RevenueDelta { get; set; }

        /// <summary>
        /// operating expense value
        /// </summary>
        [JsonProperty("operating_expense", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? OperatingExpense { get; set; }

        /// <summary>
        /// change in operating expense
        /// </summary>
        [JsonProperty("operating_expense_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? OperatingExpenseDelta { get; set; }

        /// <summary>
        /// net income value
        /// </summary>
        [JsonProperty("net_income", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NetIncome { get; set; }

        /// <summary>
        /// change in net income
        /// </summary>
        [JsonProperty("net_income_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NetIncomeDelta { get; set; }

        /// <summary>
        /// net profit margin value
        /// </summary>
        [JsonProperty("net_profit_margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NetProfitMargin { get; set; }

        /// <summary>
        /// change in net profit margin
        /// </summary>
        [JsonProperty("net_profit_margin_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NetProfitMarginDelta { get; set; }

        /// <summary>
        /// earnings per share value
        /// </summary>
        [JsonProperty("earnings_per_share", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EarningsPerShare { get; set; }

        /// <summary>
        /// change in earnings per share
        /// </summary>
        [JsonProperty("earnings_per_share_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EarningsPerShareDelta { get; set; }

        /// <summary>
        /// earnings before interest, taxes, deprecation, amortisation
        /// </summary>
        [JsonProperty("ebitda", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Ebitda { get; set; }

        /// <summary>
        /// change in ebitda
        /// </summary>
        [JsonProperty("ebitda_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EbitdaDelta { get; set; }

        /// <summary>
        /// effective tax rate value
        /// </summary>
        [JsonProperty("effective_tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EffectiveTaxRate { get; set; }

        /// <summary>
        /// cash and short-term investments value
        /// </summary>
        [JsonProperty("cash_and_short_term_investments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashAndShortTermInvestments { get; set; }

        /// <summary>
        /// change in cash and short-term investments
        /// </summary>
        [JsonProperty("cash_and_short_term_investments_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashAndShortTermInvestmentsDelta { get; set; }

        /// <summary>
        /// total assets value
        /// </summary>
        [JsonProperty("total_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TotalAssets { get; set; }

        /// <summary>
        /// change in total assets
        /// </summary>
        [JsonProperty("total_assets_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TotalAssetsDelta { get; set; }

        /// <summary>
        /// total liabilities value
        /// </summary>
        [JsonProperty("total_liabilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TotalLiabilities { get; set; }

        /// <summary>
        /// change in total liabilities
        /// </summary>
        [JsonProperty("total_liabilities_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TotalLiabilitiesDelta { get; set; }

        /// <summary>
        /// total equity value
        /// </summary>
        [JsonProperty("total_equity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TotalEquity { get; set; }

        /// <summary>
        /// outstanding shares value
        /// </summary>
        [JsonProperty("shares_outstanding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? SharesOutstanding { get; set; }

        /// <summary>
        /// price to book
        /// </summary>
        [JsonProperty("price_to_book", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PriceToBook { get; set; }

        /// <summary>
        /// return on assets
        /// </summary>
        [JsonProperty("return_on_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ReturnOnAssets { get; set; }

        /// <summary>
        /// return on capital
        /// </summary>
        [JsonProperty("return_on_capital", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ReturnOnCapital { get; set; }

        /// <summary>
        /// cash from operations
        /// </summary>
        [JsonProperty("cash_from_operations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashFromOperations { get; set; }

        /// <summary>
        /// change in cash from operations
        /// </summary>
        [JsonProperty("cash_from_operations_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashFromOperationsDelta { get; set; }

        /// <summary>
        /// cash from investing
        /// </summary>
        [JsonProperty("cash_from_investing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashFromInvesting { get; set; }

        /// <summary>
        /// change in cash from investing
        /// </summary>
        [JsonProperty("cash_from_investing_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashFromInvestingDelta { get; set; }

        /// <summary>
        /// cash from financing/em&gt;
        /// </summary>
        [JsonProperty("cash_from_financing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashFromFinancing { get; set; }

        /// <summary>
        /// change in cash from financing
        /// </summary>
        [JsonProperty("cash_from_financing_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CashFromFinancingDelta { get; set; }

        /// <summary>
        /// net change in cash
        /// </summary>
        [JsonProperty("net_change_in_cash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NetChangeInCash { get; set; }

        /// <summary>
        /// change in net change in cash
        /// </summary>
        [JsonProperty("net_change_in_cash_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NetChangeInCashDelta { get; set; }

        /// <summary>
        /// free cash flow value
        /// </summary>
        [JsonProperty("free_cash_flow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? FreeCashFlow { get; set; }

        /// <summary>
        /// change in free cash flow
        /// </summary>
        [JsonProperty("free_cash_flow_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? FreeCashFlowDelta { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #1
        /// </summary>
        [JsonProperty("pos_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos1 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #2-3
        /// </summary>
        [JsonProperty("pos_2_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos23 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #4-10
        /// </summary>
        [JsonProperty("pos_4_10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos410 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #11-20
        /// </summary>
        [JsonProperty("pos_11_20", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos1120 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #21-30
        /// </summary>
        [JsonProperty("pos_21_30", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos2130 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #31-40
        /// </summary>
        [JsonProperty("pos_31_40", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos3140 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #41-50
        /// </summary>
        [JsonProperty("pos_41_50", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos4150 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #51-60
        /// </summary>
        [JsonProperty("pos_51_60", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos5160 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #61-70
        /// </summary>
        [JsonProperty("pos_61_70", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos6170 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #71-80
        /// </summary>
        [JsonProperty("pos_71_80", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos7180 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #81-90
        /// </summary>
        [JsonProperty("pos_81_90", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos8190 { get; set; }

        /// <summary>
        /// number of organic SERPs where the domain ranks #91-100
        /// </summary>
        [JsonProperty("pos_91_100", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos91100 { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated organic monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("etv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// total count of organic SERPs that contain the domain
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Count { get; set; }

        /// <summary>
        /// estimated cost of converting organic search traffic into paid
        /// <br/>represents the estimated monthly cost of running ads (USD) for all keywords a domain ranks for
        /// <br/>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [JsonProperty("estimated_paid_traffic_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EstimatedPaidTrafficCost { get; set; }

        /// <summary>
        /// number of new ranked elements
        /// <br/>indicates how many new ranked elements were found for this domain
        /// </summary>
        [JsonProperty("is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsNew { get; set; }

        /// <summary>
        /// rank went up
        /// <br/>indicates how many ranked elements of this domain went up in Google Search
        /// </summary>
        [JsonProperty("is_up", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsUp { get; set; }

        /// <summary>
        /// rank went down
        /// <br/>indicates how many ranked elements of this domain went down in Google Search
        /// </summary>
        [JsonProperty("is_down", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsDown { get; set; }

        /// <summary>
        /// lost ranked elements
        /// <br/>indicates how many ranked elements of this domain were previously presented in SERPs, but weren’t found during the last check
        /// </summary>
        [JsonProperty("is_lost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? IsLost { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}