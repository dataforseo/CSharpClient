using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsAvailableFiltersResultInfo
    {
        [Newtonsoft.Json.JsonProperty("related_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> RelatedKeywords { get; set; }

        [Newtonsoft.Json.JsonProperty("keyword_suggestions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> KeywordSuggestions { get; set; }

        [Newtonsoft.Json.JsonProperty("ranked_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> RankedKeywords { get; set; }

        [Newtonsoft.Json.JsonProperty("keyword_ideas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> KeywordIdeas { get; set; }

        [Newtonsoft.Json.JsonProperty("serp_competitors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> SerpCompetitors { get; set; }

        [Newtonsoft.Json.JsonProperty("relevant_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> RelevantPages { get; set; }

        [Newtonsoft.Json.JsonProperty("subdomains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> Subdomains { get; set; }

        [Newtonsoft.Json.JsonProperty("competitors_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> CompetitorsDomain { get; set; }

        [Newtonsoft.Json.JsonProperty("categories_for_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> CategoriesForDomain { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> KeywordsForCategories { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> DomainIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("page_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> PageIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_whois_overview", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> DomainWhoisOverview { get; set; }

        [Newtonsoft.Json.JsonProperty("top_searches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> TopSearches { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_metrics_by_categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> DomainMetricsByCategories { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_site", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> KeywordsForSite { get; set; }

        [Newtonsoft.Json.JsonProperty("product_competitors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> ProductCompetitors { get; set; }

        [Newtonsoft.Json.JsonProperty("product_keyword_intersections", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> ProductKeywordIntersections { get; set; }

        [Newtonsoft.Json.JsonProperty("app_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> AppIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("app_competitors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> AppCompetitors { get; set; }

        [Newtonsoft.Json.JsonProperty("keywords_for_app", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> KeywordsForApp { get; set; }

        [Newtonsoft.Json.JsonProperty("database_rows_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> DatabaseRowsCount { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}