namespace DataForSeo.Client.Models
{

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritanceAttribute("GoogleFinanceHeroGroupsSerpElementItem", typeof(GoogleFinanceHeroGroupsSerpElementItem))]
    [JsonInheritanceAttribute("GoogleFinanceInterestedSerpElementItem", typeof(GoogleFinanceInterestedSerpElementItem))]
    [JsonInheritanceAttribute("GoogleFinanceNewsSerpElementItem", typeof(GoogleFinanceNewsSerpElementItem))]
    [JsonInheritanceAttribute("GoogleFinanceEarningsCalendarSerpElementItem", typeof(GoogleFinanceEarningsCalendarSerpElementItem))]
    [JsonInheritanceAttribute("GoogleFinanceMostFollowedSerpElementItem", typeof(GoogleFinanceMostFollowedSerpElementItem))]
    [JsonInheritanceAttribute("GoogleFinanceMarketTrendsSerpElementItem", typeof(GoogleFinanceMarketTrendsSerpElementItem))]
    [JsonInheritanceAttribute("GoogleFinancePeopleAlsoSearchSerpElementItem", typeof(GoogleFinancePeopleAlsoSearchSerpElementItem))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BaseGoogleFinanceSerpElementItem
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

    }
}