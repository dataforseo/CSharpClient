using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RelatedResult 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// search results page number
        /// <br/>indicates the number of the SERP page on which the element is located
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// website domain
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// reference page title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// cached version of the page
        /// </summary>
        [JsonProperty("cache_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CacheUrl { get; set; }

        /// <summary>
        /// URL to a similar search
        /// <br/>URL to a new search for the same keyword(s) on related sites
        /// </summary>
        [JsonProperty("related_search_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedSearchUrl { get; set; }

        /// <summary>
        /// breadcrumb in SERP
        /// </summary>
        [JsonProperty("breadcrumb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// name of the website in the ad element
        /// </summary>
        [JsonProperty("website_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebsiteName { get; set; }

        /// <summary>
        /// indicates whether the element contains an image
        /// </summary>
        [JsonProperty("is_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImage { get; set; }

        /// <summary>
        /// indicates whether the element contains a video
        /// </summary>
        [JsonProperty("is_video", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVideo { get; set; }

        /// <summary>
        /// description of the hotel booking element
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// includes additional information appended before the result description in SERP
        /// </summary>
        [JsonProperty("pre_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PreSnippet { get; set; }

        /// <summary>
        /// includes additional information appended after the result description in SERP
        /// </summary>
        [JsonProperty("extended_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendedSnippet { get; set; }

        /// <summary>
        /// images of the component
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeImagesElementInfo> Images { get; set; }

        /// <summary>
        /// Accelerated Mobile Pages
        /// <br/>indicates whether an item has the Accelerated Mobile Page (AMP) version
        /// </summary>
        [JsonProperty("amp_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AmpVersion { get; set; }

        /// <summary>
        /// the element’s rating
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// price indicated in the element
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// words highlighted in bold within the results description
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        /// <summary>
        /// contains information from the ‘About this result’ panel
        /// <br/>‘About this result’ panel provides additional context about why Google returned this result for the given query;
        /// <br/>this feature appears after clicking on the three dots next to most results
        /// </summary>
        [JsonProperty("about_this_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AboutThisResultElement AboutThisResult { get; set; }

        /// <summary>
        /// date and time when the video was published or indexed
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}