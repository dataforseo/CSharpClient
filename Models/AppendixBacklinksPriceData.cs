namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixBacklinksPriceData
    {
        [Newtonsoft.Json.JsonProperty("anchors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo Anchors { get; set; }

        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo Backlinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo BulkBacklinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_new_lost_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo BulkNewLostBacklinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_new_lost_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo BulkNewLostReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_pages_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo BulkPagesSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_ranks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo BulkRanks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo BulkReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("competitors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo Competitors { get; set; }

        [Newtonsoft.Json.JsonProperty("content_duplicates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo ContentDuplicates { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo DomainIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo DomainPages { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_pages_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo DomainPagesSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo History { get; set; }

        [Newtonsoft.Json.JsonProperty("page_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo PageIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo ReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("referring_networks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo ReferringNetworks { get; set; }

        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo Summary { get; set; }

        [Newtonsoft.Json.JsonProperty("timeseries_new_lost_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo TimeseriesNewLostSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("timeseries_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixKeywordBingKeywordsDataPriceDataInfo TimeseriesSummary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}