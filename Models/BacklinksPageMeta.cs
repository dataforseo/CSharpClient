namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksPageMeta
    {
        /// <summary>
        /// page title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

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
        /// number of images on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ImagesCount { get; set; }

        /// <summary>
        /// number of words on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("words_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? WordsCount { get; set; }

        /// <summary>
        /// spam score of the page
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_spam_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageSpamScore { get; set; }

        /// <summary>
        /// array of social media tags found on the page
        /// <br/>contains social media tags and their content
        /// <br/>supported tags include but are not limited to Open Graph and Twitter card
        /// </summary>
        [Newtonsoft.Json.JsonProperty("social_media_tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> SocialMediaTags { get; set; }

        /// <summary>
        /// h1 tag
        /// <br/>content of h1 tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> H1 { get; set; }

        /// <summary>
        /// h2 tag
        /// <br/>content of h2 tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> H2 { get; set; }

        /// <summary>
        /// h3 tag
        /// <br/>content of h3 tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> H3 { get; set; }

        /// <summary>
        /// content of alt tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images_alt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ImagesAlt { get; set; }

        /// <summary>
        /// CMS details
        /// </summary>
        [Newtonsoft.Json.JsonProperty("powered_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PoweredBy { get; set; }

        /// <summary>
        /// page content language
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// character encoding
        /// <br/>examples:
        /// <br/>utf-8
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Charset { get; set; }

        /// <summary>
        /// type of a platform
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PlatformType { get; set; }

        /// <summary>
        /// website technologies
        /// </summary>
        [Newtonsoft.Json.JsonProperty("technologies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Technologies { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}