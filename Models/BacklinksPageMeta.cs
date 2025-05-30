using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksPageMeta 
    {

        /// <summary>
        /// page title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// canonical page
        /// </summary>
        [JsonProperty("canonical", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Canonical { get; set; }

        /// <summary>
        /// number of internal links on the page
        /// </summary>
        [JsonProperty("internal_links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? InternalLinksCount { get; set; }

        /// <summary>
        /// number of external links on the page
        /// </summary>
        [JsonProperty("external_links_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ExternalLinksCount { get; set; }

        /// <summary>
        /// number of images on the page
        /// </summary>
        [JsonProperty("images_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ImagesCount { get; set; }

        /// <summary>
        /// number of words on the page
        /// </summary>
        [JsonProperty("words_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WordsCount { get; set; }

        /// <summary>
        /// spam score of the page
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [JsonProperty("page_spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PageSpamScore { get; set; }

        /// <summary>
        /// array of social media tags found on the page
        /// <br/>contains social media tags and their content
        /// <br/>supported tags include but are not limited to Open Graph and Twitter card
        /// </summary>
        [JsonProperty("social_media_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> SocialMediaTags { get; set; }

        /// <summary>
        /// h1 tag
        /// <br/>content of h1 tags
        /// </summary>
        [JsonProperty("h1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> H1 { get; set; }

        /// <summary>
        /// h2 tag
        /// <br/>content of h2 tags
        /// </summary>
        [JsonProperty("h2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> H2 { get; set; }

        /// <summary>
        /// h3 tag
        /// <br/>content of h3 tags
        /// </summary>
        [JsonProperty("h3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> H3 { get; set; }

        /// <summary>
        /// content of alt tags
        /// </summary>
        [JsonProperty("images_alt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ImagesAlt { get; set; }

        /// <summary>
        /// CMS details
        /// </summary>
        [JsonProperty("powered_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PoweredBy { get; set; }

        /// <summary>
        /// page content language
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// character encoding
        /// <br/>examples:
        /// <br/>utf-8
        /// </summary>
        [JsonProperty("charset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Charset { get; set; }

        /// <summary>
        /// type of a platform
        /// </summary>
        [JsonProperty("platform_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PlatformType { get; set; }

        /// <summary>
        /// website technologies
        /// </summary>
        [JsonProperty("technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Technologies { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}