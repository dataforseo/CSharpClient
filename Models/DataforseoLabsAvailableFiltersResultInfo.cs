using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsAvailableFiltersResultInfo 
    {
        [JsonProperty("related_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> RelatedKeywords { get; set; }
        [JsonProperty("keyword_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> KeywordSuggestions { get; set; }
        [JsonProperty("ranked_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> RankedKeywords { get; set; }
        [JsonProperty("keyword_ideas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> KeywordIdeas { get; set; }
        [JsonProperty("serp_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> SerpCompetitors { get; set; }
        [JsonProperty("relevant_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> RelevantPages { get; set; }
        [JsonProperty("subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> Subdomains { get; set; }
        [JsonProperty("competitors_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> CompetitorsDomain { get; set; }
        [JsonProperty("categories_for_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> CategoriesForDomain { get; set; }
        [JsonProperty("keywords_for_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> KeywordsForCategories { get; set; }
        [JsonProperty("domain_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> DomainIntersection { get; set; }
        [JsonProperty("page_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> PageIntersection { get; set; }
        [JsonProperty("domain_whois_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> DomainWhoisOverview { get; set; }
        [JsonProperty("top_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> TopSearches { get; set; }
        [JsonProperty("domain_metrics_by_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> DomainMetricsByCategories { get; set; }
        [JsonProperty("keywords_for_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> KeywordsForSite { get; set; }
        [JsonProperty("product_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> ProductCompetitors { get; set; }
        [JsonProperty("product_keyword_intersections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> ProductKeywordIntersections { get; set; }
        [JsonProperty("app_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> AppIntersection { get; set; }
        [JsonProperty("app_competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> AppCompetitors { get; set; }
        [JsonProperty("keywords_for_app", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IDictionary<string, string>> KeywordsForApp { get; set; }
        [JsonProperty("database_rows_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> DatabaseRowsCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}