namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PageMetaInfo
    {
        /// <summary>
        /// page title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// code page
        /// <br/>example: 65001
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Charset { get; set; }

        /// <summary>
        /// indicates whether a page’s ‘meta robots’ allows crawlers to follow the links on the page
        /// <br/>if false, the page’s ‘meta robots’ tag contains “nofollow” parameter instructing crawlers not to follow the links on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("follow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Follow { get; set; }

        /// <summary>
        /// meta tag generator
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Generator { get; set; }

        /// <summary>
        /// HTML header tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty("htags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<string>> Htags { get; set; }

        /// <summary>
        /// content of the meta description tag
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// favicon of the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("favicon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Favicon { get; set; }

        /// <summary>
        /// content of the keywords meta tag
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// canonical page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("canonical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Canonical { get; set; }

        /// <summary>
        /// number of internal links on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internal_links_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? InternalLinksCount { get; set; }

        /// <summary>
        /// number of external links on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_links_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ExternalLinksCount { get; set; }

        /// <summary>
        /// number of internal links pointing at the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inbound_links_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? InboundLinksCount { get; set; }

        /// <summary>
        /// number of images on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ImagesCount { get; set; }

        /// <summary>
        /// total size of images on the page measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ImagesSize { get; set; }

        /// <summary>
        /// number of scripts on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scripts_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ScriptsCount { get; set; }

        /// <summary>
        /// total size of scripts on the page measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scripts_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ScriptsSize { get; set; }

        /// <summary>
        /// number of stylesheets on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stylesheets_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StylesheetsCount { get; set; }

        /// <summary>
        /// total size of stylesheets on the page measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stylesheets_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StylesheetsSize { get; set; }

        /// <summary>
        /// length of the title tag in characters
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TitleLength { get; set; }

        /// <summary>
        /// length of the description tag in characters
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description_length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DescriptionLength { get; set; }

        /// <summary>
        /// number of scripts on the page that block page rendering
        /// </summary>
        [Newtonsoft.Json.JsonProperty("render_blocking_scripts_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RenderBlockingScriptsCount { get; set; }

        /// <summary>
        /// number of CSS styles on the page that block page rendering
        /// </summary>
        [Newtonsoft.Json.JsonProperty("render_blocking_stylesheets_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RenderBlockingStylesheetsCount { get; set; }

        /// <summary>
        /// Core Web Vitals metric measuring the layout stability of the page
        /// <br/>measures the sum total of all individual layout shift scores for every unexpected layout shift that occurs during the entire lifespan of the page. Learn more.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cumulative_layout_shift", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? CumulativeLayoutShift { get; set; }

        /// <summary>
        /// meta title of the page
        /// <br/>meta tag in the head section of an HTML document that defines the title of a page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MetaTitle { get; set; }

        /// <summary>
        /// overall information about content of the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HtmlContentInfo Content { get; set; }

        /// <summary>
        /// deprecated tags on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deprecated_tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DeprecatedTags { get; set; }

        /// <summary>
        /// duplicate meta tags on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duplicate_meta_tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DuplicateMetaTags { get; set; }

        /// <summary>
        /// autocorrection of the search engine
        /// <br/>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spell", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpellInfo Spell { get; set; }

        /// <summary>
        /// object of social media tags found on the page
        /// <br/>contains social media tags and their content
        /// <br/>supported tags include but are not limited to Open Graph and Twitter card
        /// </summary>
        [Newtonsoft.Json.JsonProperty("social_media_tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> SocialMediaTags { get; set; }

        /// <summary>
        /// resource errors and warnings
        /// </summary>
        [Newtonsoft.Json.JsonProperty("broken_html", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OnPageResourceIssueInfo BrokenHtml { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}