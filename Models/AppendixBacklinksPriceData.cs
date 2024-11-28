namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixBacklinksPriceData
    {
        [Newtonsoft.Json.JsonProperty("anchors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Anchors { get; set; }

        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Backlinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkBacklinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_new_lost_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkNewLostBacklinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_new_lost_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkNewLostReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_pages_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkPagesSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_ranks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkRanks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_spam_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo BulkSpamScore { get; set; }

        [Newtonsoft.Json.JsonProperty("competitors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Competitors { get; set; }

        [Newtonsoft.Json.JsonProperty("content_duplicates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo ContentDuplicates { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo DomainIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo DomainPages { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_pages_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo DomainPagesSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixTaskKeywordsDataPriceDataInfo Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo History { get; set; }

        [Newtonsoft.Json.JsonProperty("page_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo PageIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo ReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("referring_networks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo ReferringNetworks { get; set; }

        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo Summary { get; set; }

        [Newtonsoft.Json.JsonProperty("timeseries_new_lost_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TimeseriesNewLostSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("timeseries_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixBingKeywordsDataPriceDataInfo TimeseriesSummary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}