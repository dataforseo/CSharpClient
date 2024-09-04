namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PageMetrics
    {
        /// <summary>
        /// number of external links
        /// <br/>the number of links pointing to other websites
        /// </summary>
        [Newtonsoft.Json.JsonProperty("links_external", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinksExternal { get; set; }

        /// <summary>
        /// number of internal links
        /// <br/>the number of links pointing to other pages within the target website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("links_internal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinksInternal { get; set; }

        /// <summary>
        /// number of pages with duplicate titles
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DuplicateTitle { get; set; }

        /// <summary>
        /// number of pages with duplicate descriptions
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DuplicateDescription { get; set; }

        /// <summary>
        /// number of pages with duplicate content
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DuplicateContent { get; set; }

        /// <summary>
        /// number of broken links
        /// <br/>number of broken links across all crawled pages on a target website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("broken_links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BrokenLinks { get; set; }

        /// <summary>
        /// number of broken resources
        /// <br/>the number of images and other resources with broken links
        /// </summary>
        [Newtonsoft.Json.JsonProperty("broken_resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BrokenResources { get; set; }

        /// <summary>
        /// number of links present on the target website that may have a conflict
        /// <br/>for example, if "links_relation_conflict": 2, the target website is referring to the same source by at least one internal link with the rel="nofollow" attribute and by at least one dofollow link
        /// </summary>
        [Newtonsoft.Json.JsonProperty("links_relation_conflict", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LinksRelationConflict { get; set; }

        /// <summary>
        /// number of redirect chains that start and end at the same URL
        /// <br/>number of redirect chains where the destination URL redirects back to the original URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_loop", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RedirectLoop { get; set; }

        /// <summary>
        /// shows how website is optimized on a 100-point scale
        /// <br/>this field shows how website is optimized considering critical on-page issues and warnings detected;
        /// <br/>100 is the highest possible score that means website does not have any critical on-page issues and important warnings;
        /// <br/>note that this value depends on the number of crawled pages;
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("onpage_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? OnpageScore { get; set; }

        /// <summary>
        /// number of non-indexable pages
        /// <br/>number of pages that are blocked from being indexed by Google and other search engines by robots.txt, HTTP headers, or meta tags settings;
        /// <br/>you can receive a list of non-indexable URLs using this endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("non_indexable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NonIndexable { get; set; }

        /// <summary>
        /// page-specific on-page check-ups
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> Checks { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}