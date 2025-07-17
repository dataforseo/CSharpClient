using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PageMetaInfo 
    {

        /// <summary>
        /// page title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// code page
        /// <br/>example: 65001
        /// </summary>
        [JsonProperty("charset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Charset { get; set; }

        /// <summary>
        /// indicates whether a page’s ‘meta robots’ allows crawlers to follow the links on the page
        /// <br/>if false, the page’s ‘meta robots’ tag contains “nofollow” parameter instructing crawlers not to follow the links on the page
        /// </summary>
        [JsonProperty("follow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Follow { get; set; }

        /// <summary>
        /// meta tag generator
        /// </summary>
        [JsonProperty("generator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Generator { get; set; }

        /// <summary>
        /// HTML header tags
        /// </summary>
        [JsonProperty("htags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<string>> Htags { get; set; }

        /// <summary>
        /// content of the meta description tag
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// favicon of the page
        /// </summary>
        [JsonProperty("favicon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Favicon { get; set; }

        /// <summary>
        /// content of the keywords meta tag
        /// </summary>
        [JsonProperty("meta_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// canonical page
        /// </summary>
        [JsonProperty("canonical", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Canonical { get; set; }

        /// <summary>
        /// number of internal links on the page
        /// </summary>
        [JsonProperty("internal_links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? InternalLinksCount { get; set; }

        /// <summary>
        /// number of external links on the page
        /// </summary>
        [JsonProperty("external_links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ExternalLinksCount { get; set; }

        /// <summary>
        /// number of internal links pointing at the page
        /// </summary>
        [JsonProperty("inbound_links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? InboundLinksCount { get; set; }

        /// <summary>
        /// number of images on the page
        /// </summary>
        [JsonProperty("images_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ImagesCount { get; set; }

        /// <summary>
        /// total size of images on the page measured in bytes
        /// </summary>
        [JsonProperty("images_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImagesSize { get; set; }

        /// <summary>
        /// number of scripts on the page
        /// </summary>
        [JsonProperty("scripts_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ScriptsCount { get; set; }

        /// <summary>
        /// total size of scripts on the page measured in bytes
        /// </summary>
        [JsonProperty("scripts_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScriptsSize { get; set; }

        /// <summary>
        /// number of stylesheets on the page
        /// </summary>
        [JsonProperty("stylesheets_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? StylesheetsCount { get; set; }

        /// <summary>
        /// total size of stylesheets on the page measured in bytes
        /// </summary>
        [JsonProperty("stylesheets_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StylesheetsSize { get; set; }

        /// <summary>
        /// length of the title tag in characters
        /// </summary>
        [JsonProperty("title_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TitleLength { get; set; }

        /// <summary>
        /// length of the description tag in characters
        /// </summary>
        [JsonProperty("description_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DescriptionLength { get; set; }

        /// <summary>
        /// number of scripts on the page that block page rendering
        /// </summary>
        [JsonProperty("render_blocking_scripts_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? RenderBlockingScriptsCount { get; set; }

        /// <summary>
        /// number of CSS styles on the page that block page rendering
        /// </summary>
        [JsonProperty("render_blocking_stylesheets_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? RenderBlockingStylesheetsCount { get; set; }

        /// <summary>
        /// Core Web Vitals metric measuring the layout stability of the page
        /// <br/>measures the sum total of all individual layout shift scores for every unexpected layout shift that occurs during the entire lifespan of the page. Learn more.
        /// </summary>
        [JsonProperty("cumulative_layout_shift", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CumulativeLayoutShift { get; set; }

        /// <summary>
        /// meta title of the page
        /// <br/>meta tag in the head section of an HTML document that defines the title of a page
        /// </summary>
        [JsonProperty("meta_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MetaTitle { get; set; }

        /// <summary>
        /// overall information about content of the page
        /// </summary>
        [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HtmlContentInfo Content { get; set; }

        /// <summary>
        /// deprecated tags on the page
        /// </summary>
        [JsonProperty("deprecated_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DeprecatedTags { get; set; }

        /// <summary>
        /// duplicate meta tags on the page
        /// </summary>
        [JsonProperty("duplicate_meta_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DuplicateMetaTags { get; set; }

        /// <summary>
        /// spellcheck
        /// <br/>hunspell spellcheck errors
        /// </summary>
        [JsonProperty("spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HunspellInfo Spell { get; set; }

        /// <summary>
        /// object of social media tags found on the page
        /// <br/>contains social media tags and their content
        /// <br/>supported tags include but are not limited to Open Graph and Twitter card
        /// </summary>
        [JsonProperty("social_media_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> SocialMediaTags { get; set; }

        /// <summary>
        /// resource errors and warnings
        /// </summary>
        [JsonProperty("broken_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OnPageResourceIssueInfo BrokenHtml { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}