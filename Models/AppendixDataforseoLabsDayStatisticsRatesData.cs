using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixDataforseoLabsDayStatisticsRatesData 
    {
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LocationsAndLanguages { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Categories { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("product_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo ProductCompetitors { get; set; }
        [JsonProperty("product_keyword_intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo ProductKeywordIntersections { get; set; }
        [JsonProperty("product_rank_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo ProductRankOverview { get; set; }
        [JsonProperty("ranked_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo RankedKeywords { get; set; }
        [JsonProperty("serp_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SerpCompetitors { get; set; }
        [JsonProperty("subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Subdomains { get; set; }
        [JsonProperty("relevant_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo RelevantPages { get; set; }
        [JsonProperty("competitors_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo CompetitorsDomain { get; set; }
        [JsonProperty("related_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo RelatedKeywords { get; set; }
        [JsonProperty("domain_rank_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainRankOverview { get; set; }
        [JsonProperty("domain_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainIntersection { get; set; }
        [JsonProperty("page_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo PageIntersection { get; set; }
        [JsonProperty("bulk_traffic_estimation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkTrafficEstimation { get; set; }
        [JsonProperty("bulk_keyword_difficulty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkKeywordDifficulty { get; set; }
        [JsonProperty("bulk_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkSearchVolume { get; set; }
        [JsonProperty("keywords_for_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsForSite { get; set; }
        [JsonProperty("keyword_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordSuggestions { get; set; }
        [JsonProperty("keyword_ideas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordIdeas { get; set; }
        [JsonProperty("categories_for_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo CategoriesForDomain { get; set; }
        [JsonProperty("domain_metrics_by_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainMetricsByCategories { get; set; }
        [JsonProperty("top_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopSearches { get; set; }
        [JsonProperty("domain_whois_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainWhoisOverview { get; set; }
        [JsonProperty("historical_rank_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo HistoricalRankOverview { get; set; }
        [JsonProperty("keywords_for_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsForCategories { get; set; }
        [JsonProperty("historical_serps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo HistoricalSerps { get; set; }
        [JsonProperty("app_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo AppCompetitors { get; set; }
        [JsonProperty("keywords_for_app", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordsForApp { get; set; }
        [JsonProperty("app_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo AppIntersection { get; set; }
        [JsonProperty("bulk_app_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkAppMetrics { get; set; }
        [JsonProperty("search_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo SearchIntent { get; set; }
        [JsonProperty("historical_bulk_traffic_estimation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo HistoricalBulkTrafficEstimation { get; set; }
        [JsonProperty("categories_for_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo CategoriesForKeywords { get; set; }
        [JsonProperty("keyword_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo KeywordOverview { get; set; }
        [JsonProperty("historical_keyword_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo HistoricalKeywordData { get; set; }
        [JsonProperty("top_google_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TopGoogleSearches { get; set; }
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Languages { get; set; }
        [JsonProperty("amazon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixDataforseoLabsLimitsRatesDataInfo Amazon { get; set; }
        [JsonProperty("historical_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo HistoricalSearchVolume { get; set; }
        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Status { get; set; }
        [JsonProperty("id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IdList { get; set; }
        [JsonProperty("available_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableHistory { get; set; }
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableFilters { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}