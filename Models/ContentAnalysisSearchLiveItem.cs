using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentAnalysisSearchLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// URL where the citation was found
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// main domain
        /// </summary>
        [JsonProperty("main_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// rank of the url
        /// <br/>this value is based on backlink data for the given URL from DataForSEO Backlink Index;
        /// <br/>url_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("url_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UrlRank { get; set; }

        /// <summary>
        /// backlink spam score of the url
        /// <br/>this value is based on backlink data for the given URL from DataForSEO Backlink Index;
        /// <br/>learn more about how the metric is calculated on this help center page
        /// </summary>
        [JsonProperty("spam_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SpamScore { get; set; }

        /// <summary>
        /// rank of the domain
        /// <br/>this value is based on backlink data for the given domain from DataForSEO Backlink Index;
        /// <br/>domain_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("domain_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomainRank { get; set; }

        /// <summary>
        /// date and time when our crawler visited the page
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [JsonProperty("fetch_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// country code of the domain registration
        /// <br/>to obtain a full list of available countries, refer to the Locations endpoint
        /// </summary>
        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// main language of the domain
        /// <br/>to obtain a full list of available languages, refer to the Languages endpoint
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// citation prominence score
        /// <br/>this value is based on url_rank, domain_rank, keyword presence in title, main_title, url, snippet
        /// <br/>the higher the score, the more value the related citation has
        /// </summary>
        [JsonProperty("score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Score { get; set; }

        /// <summary>
        /// contains all relevant page categories
        /// <br/>product and service categories relevant for the page
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [JsonProperty("page_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<int?> PageCategory { get; set; }

        /// <summary>
        /// page types
        /// </summary>
        [JsonProperty("page_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PageTypes { get; set; }

        /// <summary>
        /// ratings found on the page
        /// <br/>all ratings found on the page based on microdata
        /// </summary>
        [JsonProperty("ratings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentRatingInfo> Ratings { get; set; }

        /// <summary>
        /// social media engagement metrics
        /// <br/>data on social media interactions associated with the content based on website embeds developed and supported by social media platforms
        /// </summary>
        [JsonProperty("social_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SocialMetricsInfo> SocialMetrics { get; set; }

        /// <summary>
        /// contains data on citations from the given url
        /// </summary>
        [JsonProperty("content_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AnalysisContentInfo ContentInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}