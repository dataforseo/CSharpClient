using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DomainAnalyticsTechnologiesDomainTechnologiesLiveResultInfo
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// specified domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// domain meta title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// domain meta description
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// domain meta keywords
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> MetaKeywords { get; set; }

        /// <summary>
        /// backlink rank of the target domain
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainRank { get; set; }

        /// <summary>
        /// most recent date when our crawler visited the domain
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2022-10-10 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_visited", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastVisited { get; set; }

        /// <summary>
        /// domain ISO code
        /// <br/>ISO code of the country that the target domain is determined to belong to
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country_iso_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// domain language
        /// <br/>code of the language that the target domain is determined to be associated with
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// content language
        /// <br/>code of the language that content on the target domain is written in
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContentLanguageCode { get; set; }

        /// <summary>
        /// phone numbers of the target
        /// <br/>contact phone numbers indicated on the target website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_numbers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PhoneNumbers { get; set; }

        /// <summary>
        /// emails of the target
        /// <br/>emails indicated on the target website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("emails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Emails { get; set; }

        /// <summary>
        /// social media links and handles
        /// <br/>social media URLs detected in the social graphs of the target website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("social_graph_urls", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SocialGraphUrls { get; set; }

        /// <summary>
        /// technologies used by target domain
        /// <br/>contains objects with the names of technologies used on the website
        /// <br/>see the full list of available technologies structured by groups and categories
        /// </summary>
        [Newtonsoft.Json.JsonProperty("technologies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TechnologiesInfo Technologies { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}