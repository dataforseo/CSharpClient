using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("google_finance_hero_groups", typeof(GoogleFinanceHeroGroupsSerpElementItem))]
    [JsonInheritance("google_finance_interested", typeof(GoogleFinanceInterestedSerpElementItem))]
    [JsonInheritance("google_finance_news", typeof(GoogleFinanceNewsSerpElementItem))]
    [JsonInheritance("google_finance_earnings_calendar", typeof(GoogleFinanceEarningsCalendarSerpElementItem))]
    [JsonInheritance("google_finance_most_followed", typeof(GoogleFinanceMostFollowedSerpElementItem))]
    [JsonInheritance("google_finance_market_trends", typeof(GoogleFinanceMarketTrendsSerpElementItem))]
    [JsonInheritance("google_finance_people_also_search", typeof(GoogleFinancePeopleAlsoSearchSerpElementItem))]

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