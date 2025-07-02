using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsTechnologiesDomainsByLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// specified domain name
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// domain meta title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// domain meta description
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// domain meta keywords
        /// </summary>
        [JsonProperty("meta_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> MetaKeywords { get; set; }

        /// <summary>
        /// backlink rank of the target domain
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("domain_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DomainRank { get; set; }

        /// <summary>
        /// most recent date when our crawler visited the domain
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2022-10-10 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_visited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastVisited { get; set; }

        /// <summary>
        /// domain ISO code
        /// <br/>ISO code of the country that target domain is determined to belong to
        /// </summary>
        [JsonProperty("country_iso_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// domain language
        /// <br/>code of the language that target domain is determined to be associated with
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// content language
        /// <br/>code of the language that content on the target domain is written with
        /// </summary>
        [JsonProperty("content_language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContentLanguageCode { get; set; }

        /// <summary>
        /// phone numbers of the target
        /// <br/>contact phone numbers indicated on the target website
        /// </summary>
        [JsonProperty("phone_numbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PhoneNumbers { get; set; }

        /// <summary>
        /// emails of the target
        /// <br/>emails indicated on the target website
        /// </summary>
        [JsonProperty("emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Emails { get; set; }

        /// <summary>
        /// social media links and handles
        /// <br/>social media URLs detected in the social graphs of the target website
        /// </summary>
        [JsonProperty("social_graph_urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SocialGraphUrls { get; set; }

        /// <summary>
        /// technologies used by target domain
        /// <br/>contains objects with the names of technologies used on the website;
        /// <br/>to get a full list of technologies and their structure, refer to the technologies endpoint
        /// </summary>
        [JsonProperty("technologies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TechnologiesInfo Technologies { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}