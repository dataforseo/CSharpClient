using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixDataforseoLabsPriceData 
    {
        [JsonProperty("app_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo AppCompetitors { get; set; }
        [JsonProperty("app_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo AppIntersection { get; set; }
        [JsonProperty("bulk_app_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkAppMetrics { get; set; }
        [JsonProperty("bulk_keyword_difficulty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkKeywordDifficulty { get; set; }
        [JsonProperty("bulk_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkSearchVolume { get; set; }
        [JsonProperty("bulk_traffic_estimation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkTrafficEstimation { get; set; }
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Categories { get; set; }
        [JsonProperty("categories_for_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo CategoriesForDomain { get; set; }
        [JsonProperty("categories_for_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo CategoriesForKeywords { get; set; }
        [JsonProperty("competitors_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo CompetitorsDomain { get; set; }
        [JsonProperty("domain_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo DomainIntersection { get; set; }
        [JsonProperty("domain_metrics_by_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo DomainMetricsByCategories { get; set; }
        [JsonProperty("domain_rank_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo DomainRankOverview { get; set; }
        [JsonProperty("domain_whois_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo DomainWhoisOverview { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }
        [JsonProperty("historical_bulk_traffic_estimation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo HistoricalBulkTrafficEstimation { get; set; }
        [JsonProperty("historical_keyword_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo HistoricalKeywordData { get; set; }
        [JsonProperty("historical_rank_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo HistoricalRankOverview { get; set; }
        [JsonProperty("historical_serps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo HistoricalSerps { get; set; }
        [JsonProperty("keyword_ideas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordIdeas { get; set; }
        [JsonProperty("keyword_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordOverview { get; set; }
        [JsonProperty("keywords_for_app", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordsForApp { get; set; }
        [JsonProperty("keywords_for_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordsForCategories { get; set; }
        [JsonProperty("keywords_for_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordsForSite { get; set; }
        [JsonProperty("keyword_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo KeywordSuggestions { get; set; }
        [JsonProperty("locations_and_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo LocationsAndLanguages { get; set; }
        [JsonProperty("page_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo PageIntersection { get; set; }
        [JsonProperty("product_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo ProductCompetitors { get; set; }
        [JsonProperty("product_keyword_intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo ProductKeywordIntersections { get; set; }
        [JsonProperty("product_rank_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo ProductRankOverview { get; set; }
        [JsonProperty("ranked_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo RankedKeywords { get; set; }
        [JsonProperty("related_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo RelatedKeywords { get; set; }
        [JsonProperty("relevant_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo RelevantPages { get; set; }
        [JsonProperty("search_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo SearchIntent { get; set; }
        [JsonProperty("serp_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo SerpCompetitors { get; set; }
        [JsonProperty("subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Subdomains { get; set; }
        [JsonProperty("top_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TopSearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}