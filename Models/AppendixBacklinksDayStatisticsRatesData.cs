using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixBacklinksDayStatisticsRatesData 
    {
        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Summary { get; set; }
        [JsonProperty("history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo History { get; set; }
        [JsonProperty("content_duplicates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo ContentDuplicates { get; set; }
        [JsonProperty("domain_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainIntersection { get; set; }
        [JsonProperty("backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Backlinks { get; set; }
        [JsonProperty("domain_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainPages { get; set; }
        [JsonProperty("anchors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Anchors { get; set; }
        [JsonProperty("referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo ReferringDomains { get; set; }
        [JsonProperty("page_intersection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo PageIntersection { get; set; }
        [JsonProperty("referring_networks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo ReferringNetworks { get; set; }
        [JsonProperty("bulk_ranks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkRanks { get; set; }
        [JsonProperty("bulk_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkBacklinks { get; set; }
        [JsonProperty("bulk_new_lost_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkNewLostBacklinks { get; set; }
        [JsonProperty("bulk_new_lost_referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkNewLostReferringDomains { get; set; }
        [JsonProperty("bulk_referring_domains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkReferringDomains { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("domain_pages_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo DomainPagesSummary { get; set; }
        [JsonProperty("timeseries_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TimeseriesSummary { get; set; }
        [JsonProperty("timeseries_new_lost_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo TimeseriesNewLostSummary { get; set; }
        [JsonProperty("competitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Competitors { get; set; }
        [JsonProperty("bulk_spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkSpamScore { get; set; }
        [JsonProperty("bulk_pages_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo BulkPagesSummary { get; set; }
        [JsonProperty("pages_summary_with_page_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo PagesSummaryWithPageInfo { get; set; }
        [JsonProperty("id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IdList { get; set; }
        [JsonProperty("available_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AvailableFilters { get; set; }
        [JsonProperty("historical_new_lost_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo HistoricalNewLostSummary { get; set; }
        [JsonProperty("index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Index { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}