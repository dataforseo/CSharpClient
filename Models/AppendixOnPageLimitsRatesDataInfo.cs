using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixOnPageLimitsRatesDataInfo 
    {
        [JsonProperty("task_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TaskPost { get; set; }
        [JsonProperty("tasks_ready", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }
        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Summary { get; set; }
        [JsonProperty("resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Resources { get; set; }
        [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pages { get; set; }
        [JsonProperty("non_indexable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NonIndexable { get; set; }
        [JsonProperty("duplicate_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DuplicateTags { get; set; }
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Links { get; set; }
        [JsonProperty("waterfall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Waterfall { get; set; }
        [JsonProperty("errors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Errors { get; set; }
        [JsonProperty("pages_by_resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PagesByResource { get; set; }
        [JsonProperty("duplicate_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DuplicateContent { get; set; }
        [JsonProperty("raw_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RawHtml { get; set; }
        [JsonProperty("instant_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? InstantPages { get; set; }
        [JsonProperty("redirect_chains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RedirectChains { get; set; }
        [JsonProperty("lighthouse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppendixInfo Lighthouse { get; set; }
        [JsonProperty("keyword_density", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? KeywordDensity { get; set; }
        [JsonProperty("page_screenshot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PageScreenshot { get; set; }
        [JsonProperty("content_parsing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ContentParsing { get; set; }
        [JsonProperty("content_parsing_live", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ContentParsingLive { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}