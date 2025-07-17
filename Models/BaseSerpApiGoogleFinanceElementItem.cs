using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("google_finance_asset_pair_element", typeof(SerpApiGoogleFinanceAssetPairElementElementItem))]
    [JsonInheritance("google_finance_market_index_element", typeof(SerpApiGoogleFinanceMarketIndexElementElementItem))]
    [JsonInheritance("google_finance_market_instrument_element", typeof(SerpApiGoogleFinanceMarketInstrumentElementElementItem))]
    [JsonInheritance("google_finance_hero_groups", typeof(SerpApiGoogleFinanceHeroGroupsElementItem))]
    [JsonInheritance("google_finance_interested", typeof(SerpApiGoogleFinanceInterestedElementItem))]
    [JsonInheritance("google_finance_news", typeof(SerpApiGoogleFinanceNewsElementItem))]
    [JsonInheritance("google_finance_earnings_calendar", typeof(SerpApiGoogleFinanceEarningsCalendarElementItem))]
    [JsonInheritance("google_finance_most_followed", typeof(SerpApiGoogleFinanceMostFollowedElementItem))]
    [JsonInheritance("google_finance_market_trends", typeof(SerpApiGoogleFinanceMarketTrendsElementItem))]
    [JsonInheritance("google_finance_people_also_search", typeof(SerpApiGoogleFinancePeopleAlsoSearchElementItem))]
    [JsonInheritance("google_finance_explore_market_trends", typeof(SerpApiGoogleFinanceExploreMarketTrendsElementItem))]
    [JsonInheritance("google_finance_quote", typeof(SerpApiGoogleFinanceQuoteElementItem))]
    [JsonInheritance("google_finance_compare_to", typeof(SerpApiGoogleFinanceCompareToElementItem))]
    [JsonInheritance("google_finance_financial", typeof(SerpApiGoogleFinanceFinancialElementItem))]
    [JsonInheritance("google_finance_futures_chain", typeof(SerpApiGoogleFinanceFuturesChainElementItem))]
    [JsonInheritance("google_finance_details", typeof(SerpApiGoogleFinanceDetailsElementItem))]
    [JsonInheritance("google_finance_about", typeof(SerpApiGoogleFinanceAboutElementItem))]

    public class BaseSerpApiGoogleFinanceElementItem 
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