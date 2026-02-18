using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleFinanceMetricsBundleInfo 
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
        public double? Revenue { get; set; }

        /// <summary>
        /// change in revenue
        /// </summary>
        [JsonProperty("revenue_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RevenueDelta { get; set; }

        /// <summary>
        /// operating expense value
        /// </summary>
        [JsonProperty("operating_expense", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OperatingExpense { get; set; }

        /// <summary>
        /// change in operating expense
        /// </summary>
        [JsonProperty("operating_expense_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OperatingExpenseDelta { get; set; }

        /// <summary>
        /// net income value
        /// </summary>
        [JsonProperty("net_income", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NetIncome { get; set; }

        /// <summary>
        /// change in net income
        /// </summary>
        [JsonProperty("net_income_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NetIncomeDelta { get; set; }

        /// <summary>
        /// net profit margin value
        /// </summary>
        [JsonProperty("net_profit_margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NetProfitMargin { get; set; }

        /// <summary>
        /// change in net profit margin
        /// </summary>
        [JsonProperty("net_profit_margin_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NetProfitMarginDelta { get; set; }

        /// <summary>
        /// earnings per share value
        /// </summary>
        [JsonProperty("earnings_per_share", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? EarningsPerShare { get; set; }

        /// <summary>
        /// change in earnings per share
        /// </summary>
        [JsonProperty("earnings_per_share_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? EarningsPerShareDelta { get; set; }

        /// <summary>
        /// earnings before interest, taxes, deprecation, amortisation
        /// </summary>
        [JsonProperty("ebitda", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Ebitda { get; set; }

        /// <summary>
        /// change in ebitda
        /// </summary>
        [JsonProperty("ebitda_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? EbitdaDelta { get; set; }

        /// <summary>
        /// effective tax rate value
        /// </summary>
        [JsonProperty("effective_tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? EffectiveTaxRate { get; set; }

        /// <summary>
        /// cash and short-term investments value
        /// </summary>
        [JsonProperty("cash_and_short_term_investments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashAndShortTermInvestments { get; set; }

        /// <summary>
        /// change in cash and short-term investments
        /// </summary>
        [JsonProperty("cash_and_short_term_investments_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashAndShortTermInvestmentsDelta { get; set; }

        /// <summary>
        /// total assets value
        /// </summary>
        [JsonProperty("total_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAssets { get; set; }

        /// <summary>
        /// change in total assets
        /// </summary>
        [JsonProperty("total_assets_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAssetsDelta { get; set; }

        /// <summary>
        /// total liabilities value
        /// </summary>
        [JsonProperty("total_liabilities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLiabilities { get; set; }

        /// <summary>
        /// change in total liabilities
        /// </summary>
        [JsonProperty("total_liabilities_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalLiabilitiesDelta { get; set; }

        /// <summary>
        /// total equity value
        /// </summary>
        [JsonProperty("total_equity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalEquity { get; set; }

        /// <summary>
        /// outstanding shares value
        /// </summary>
        [JsonProperty("shares_outstanding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SharesOutstanding { get; set; }

        /// <summary>
        /// price to book
        /// </summary>
        [JsonProperty("price_to_book", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PriceToBook { get; set; }

        /// <summary>
        /// return on assets
        /// </summary>
        [JsonProperty("return_on_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ReturnOnAssets { get; set; }

        /// <summary>
        /// return on capital
        /// </summary>
        [JsonProperty("return_on_capital", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ReturnOnCapital { get; set; }

        /// <summary>
        /// cash from operations
        /// </summary>
        [JsonProperty("cash_from_operations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashFromOperations { get; set; }

        /// <summary>
        /// change in cash from operations
        /// </summary>
        [JsonProperty("cash_from_operations_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashFromOperationsDelta { get; set; }

        /// <summary>
        /// cash from investing
        /// </summary>
        [JsonProperty("cash_from_investing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashFromInvesting { get; set; }

        /// <summary>
        /// change in cash from investing
        /// </summary>
        [JsonProperty("cash_from_investing_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashFromInvestingDelta { get; set; }

        /// <summary>
        /// cash from financing
        /// </summary>
        [JsonProperty("cash_from_financing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashFromFinancing { get; set; }

        /// <summary>
        /// change in cash from financing
        /// </summary>
        [JsonProperty("cash_from_financing_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CashFromFinancingDelta { get; set; }

        /// <summary>
        /// net change in cash
        /// </summary>
        [JsonProperty("net_change_in_cash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NetChangeInCash { get; set; }

        /// <summary>
        /// change in net change in cash
        /// </summary>
        [JsonProperty("net_change_in_cash_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NetChangeInCashDelta { get; set; }

        /// <summary>
        /// free cash flow value
        /// </summary>
        [JsonProperty("free_cash_flow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FreeCashFlow { get; set; }

        /// <summary>
        /// change in free cash flow
        /// </summary>
        [JsonProperty("free_cash_flow_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FreeCashFlowDelta { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}