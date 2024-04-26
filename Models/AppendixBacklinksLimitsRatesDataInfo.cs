namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixBacklinksLimitsRatesDataInfo
    {
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo Summary { get; set; }

        [Newtonsoft.Json.JsonProperty("history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo History { get; set; }

        [Newtonsoft.Json.JsonProperty("content_duplicates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo ContentDuplicates { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo DomainIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo Backlinks { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo DomainPages { get; set; }

        [Newtonsoft.Json.JsonProperty("anchors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo Anchors { get; set; }

        [Newtonsoft.Json.JsonProperty("referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo ReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("page_intersection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo PageIntersection { get; set; }

        [Newtonsoft.Json.JsonProperty("referring_networks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo ReferringNetworks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_ranks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo BulkRanks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo BulkBacklinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_new_lost_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo BulkNewLostBacklinks { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_new_lost_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo BulkNewLostReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_referring_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo BulkReferringDomains { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("domain_pages_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo DomainPagesSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("timeseries_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo TimeseriesSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("timeseries_new_lost_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo TimeseriesNewLostSummary { get; set; }

        [Newtonsoft.Json.JsonProperty("competitors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo Competitors { get; set; }

        [Newtonsoft.Json.JsonProperty("bulk_pages_summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixFunctionInfo BulkPagesSummary { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}