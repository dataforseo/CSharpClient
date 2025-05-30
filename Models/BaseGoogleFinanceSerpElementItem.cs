using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("google_finance_asset_pair_element", typeof(GoogleFinanceAssetPairElementSerpElementItem))]
    [JsonInheritance("google_finance_market_index_element", typeof(GoogleFinanceMarketIndexElementSerpElementItem))]
    [JsonInheritance("google_finance_market_instrument_element", typeof(GoogleFinanceMarketInstrumentElementSerpElementItem))]
    [JsonInheritance("google_finance_hero_groups", typeof(GoogleFinanceHeroGroupsSerpElementItem))]
    [JsonInheritance("google_finance_interested", typeof(GoogleFinanceInterestedSerpElementItem))]
    [JsonInheritance("google_finance_news", typeof(GoogleFinanceNewsSerpElementItem))]
    [JsonInheritance("google_finance_earnings_calendar", typeof(GoogleFinanceEarningsCalendarSerpElementItem))]
    [JsonInheritance("google_finance_most_followed", typeof(GoogleFinanceMostFollowedSerpElementItem))]
    [JsonInheritance("google_finance_market_trends", typeof(GoogleFinanceMarketTrendsSerpElementItem))]
    [JsonInheritance("google_finance_people_also_search", typeof(GoogleFinancePeopleAlsoSearchSerpElementItem))]
    [JsonInheritance("google_finance_explore_market_trends", typeof(GoogleFinanceExploreMarketTrendsSerpElementItem))]
    [JsonInheritance("google_finance_quote", typeof(GoogleFinanceQuoteSerpElementItem))]
    [JsonInheritance("google_finance_compare_to", typeof(GoogleFinanceCompareToSerpElementItem))]
    [JsonInheritance("google_finance_financial", typeof(GoogleFinanceFinancialSerpElementItem))]
    [JsonInheritance("google_finance_futures_chain", typeof(GoogleFinanceFuturesChainSerpElementItem))]
    [JsonInheritance("google_finance_details", typeof(GoogleFinanceDetailsSerpElementItem))]
    [JsonInheritance("google_finance_about", typeof(GoogleFinanceAboutSerpElementItem))]

    public class BaseGoogleFinanceSerpElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}