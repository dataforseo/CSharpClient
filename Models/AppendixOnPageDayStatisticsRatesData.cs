namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixOnPageDayStatisticsRatesData
    {
        [Newtonsoft.Json.JsonProperty("task_post", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TaskPost { get; set; }

        [Newtonsoft.Json.JsonProperty("tasks_ready", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TasksReady { get; set; }

        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Summary { get; set; }

        [Newtonsoft.Json.JsonProperty("resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Resources { get; set; }

        [Newtonsoft.Json.JsonProperty("pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Pages { get; set; }

        [Newtonsoft.Json.JsonProperty("non_indexable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NonIndexable { get; set; }

        [Newtonsoft.Json.JsonProperty("duplicate_tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DuplicateTags { get; set; }

        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Links { get; set; }

        [Newtonsoft.Json.JsonProperty("waterfall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Waterfall { get; set; }

        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Errors { get; set; }

        [Newtonsoft.Json.JsonProperty("pages_by_resource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PagesByResource { get; set; }

        [Newtonsoft.Json.JsonProperty("duplicate_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DuplicateContent { get; set; }

        [Newtonsoft.Json.JsonProperty("raw_html", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RawHtml { get; set; }

        [Newtonsoft.Json.JsonProperty("instant_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InstantPages { get; set; }

        [Newtonsoft.Json.JsonProperty("redirect_chains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RedirectChains { get; set; }

        [Newtonsoft.Json.JsonProperty("lighthouse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AppendixLighthouseOnPageDayStatisticsRatesData Lighthouse { get; set; }

        [Newtonsoft.Json.JsonProperty("keyword_density", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KeywordDensity { get; set; }

        [Newtonsoft.Json.JsonProperty("page_screenshot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PageScreenshot { get; set; }

        [Newtonsoft.Json.JsonProperty("content_parsing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContentParsing { get; set; }

        [Newtonsoft.Json.JsonProperty("content_parsing_live", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContentParsingLive { get; set; }

        [Newtonsoft.Json.JsonProperty("force_stop", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ForceStop { get; set; }

        [Newtonsoft.Json.JsonProperty("available_filters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AvailableFilters { get; set; }

        [Newtonsoft.Json.JsonProperty("id_list", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IdList { get; set; }

        [Newtonsoft.Json.JsonProperty("microdata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Microdata { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}