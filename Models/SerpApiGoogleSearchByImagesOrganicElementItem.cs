using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleSearchByImagesOrganicElementItem  : BaseSerpApiGoogleSearchByImagesElementItem 
    {

        /// <summary>
        /// domain in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

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
        /// name of the website in SERP
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
        /// indicates whether the element is a featured_snippet
        /// </summary>
        [JsonProperty("is_featured_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFeaturedSnippet { get; set; }

        /// <summary>
        /// indicates whether the element is marked as malicious
        /// </summary>
        [JsonProperty("is_malicious", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMalicious { get; set; }

        /// <summary>
        /// indicates whether the element is marked as Google web story
        /// </summary>
        [JsonProperty("is_web_story", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWebStory { get; set; }

        /// <summary>
        /// description of the results element in SERP
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
        /// images of the element
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
        /// the item’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// pricing details
        /// <br/>contains the pricing details of the product or service featured in the result
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// words highlighted in bold within the results description
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        /// <summary>
        /// sitelinks
        /// <br/>the links shown below some of Google’s search results
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LinkElement> Links { get; set; }

        /// <summary>
        /// frequently asked questions
        /// <br/>questions and answers extension shown below some of Google’s search results
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("faq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FaqBox Faq { get; set; }

        /// <summary>
        /// extension of the organic element
        /// <br/>extension of the organic result containing related search queries
        /// <br/>Note: extension appears in SERP upon clicking on the result and then bouncing back to search results
        /// </summary>
        [JsonProperty("extended_people_also_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ExtendedPeopleAlsoSearch { get; set; }

        /// <summary>
        /// contains information from the ‘About this result’ panel
        /// <br/>‘About this result’ panel provides additional context about why Google returned this result for the given query;
        /// <br/>this feature appears after clicking on the three dots next to most results
        /// </summary>
        [JsonProperty("about_this_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AboutThisResultElement AboutThisResult { get; set; }

        /// <summary>
        /// related result from the same domain
        /// <br/>related result from the same domain appears as a part of the main result snippet;
        /// <br/>you can derive the related_result snippets as 'type': 'organic' results by setting the group_organic_results parameter to false in the POST request
        /// </summary>
        [JsonProperty("related_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<RelatedResult> RelatedResult { get; set; }

        /// <summary>
        /// date and time when the result was published
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