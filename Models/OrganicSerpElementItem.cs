using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OrganicSerpElementItem  : BaseSerpApiElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical <c>type</c> values
        /// <br/>positions of elements with different <c>type</c> values are omitted from <c>rank_group</c>
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements found in SERPnote values are returned in the ascending order, with values corresponding to advanced SERP features omitted from the results;
        /// <br/>to get all items (including SERP features and rich snippets) with their positions, please refer to the <see href="https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?php">Google Organiс Advanced SERP</see> endpoint
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// domain in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the results element in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the results element in SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// relevant URL in SERP
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// breadcrumb in SERP
        /// </summary>
        [JsonProperty("breadcrumb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// cached version of the page
        /// </summary>
        [JsonProperty("cache_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CacheUrl { get; set; }

        /// <summary>
        /// URL to a similar search
        /// <br/>URL to a new search for the same keyword(s) <see href="https://support.google.com/websearch/answer/2466433?hl=en#:~:text=Search%20for%20related%20sites">on related sites</see>
        /// </summary>
        [JsonProperty("related_search_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedSearchUrl { get; set; }

        /// <summary>
        /// name of the website in SERP
        /// </summary>
        [JsonProperty("website_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebsiteName { get; set; }

        /// <summary>
        /// indicates whether the element contains an_<c>image</c>
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("is_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImage { get; set; }

        /// <summary>
        /// indicates whether the element contains a <c>video</c>
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("is_video", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVideo { get; set; }

        /// <summary>
        /// indicates whether the element is a <c>featured_snippet</c>
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("is_featured_snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFeaturedSnippet { get; set; }

        /// <summary>
        /// indicates whether the element is marked as malicious
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("is_malicious", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMalicious { get; set; }

        /// <summary>
        /// indicates whether the element is marked as Google web story
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("is_web_story", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWebStory { get; set; }

        /// <summary>
        /// array of properties detected for the SERP element
        /// <br/>lists the properties that are true for this element
        /// <br/>each value in the array represents a detected property 
        /// <br/>example:
        /// <br/>if <c>is_image</c> is present in the array, the element contains an image
        /// <br/>possible values in the array:
        /// <br/><c>is_image</c>, <c>is_video</c>, <c>is_featured_snippet</c>, <c>amp_version</c>, <c>is_malicious</c>, <c>is_web_story</c>, <c>is_highly_cited</c>
        /// <br/>equals <c>null</c> if none of the properties are detected for the element
        /// <br/>learn more about the <c>checks</c> array in <see href="https://dataforseo.com/help-center/whats-a-checks-array-in-the-google-organic-serp-api">this Help Center article</see>
        /// </summary>
        [JsonProperty("checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Checks { get; set; }

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
        /// <br/>if there are none, equals <c>null</c>
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeImagesElementInfo> Images { get; set; }

        /// <summary>
        /// Accelerated Mobile Pages
        /// <br/>indicates whether an item has the Accelerated Mobile Page (AMP) version
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("amp_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AmpVersion { get; set; }

        /// <summary>
        /// the item's rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// <br/>if there is none, equals <c>null</c>
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// pricing details
        /// <br/>contains the pricing details of the product or service featured in the result;
        /// <br/>if there is none, equals <c>null</c>
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// words highlighted in bold within the results <c>description</c>
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        /// <summary>
        /// link of the element
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LinkElement> Links { get; set; }

        /// <summary>
        /// frequently asked questions
        /// <br/>questions and answers extension shown below some of Google's search results
        /// <br/>Note: this object is deprecated and always returns <c>null</c>
        /// </summary>
        [Obsolete]
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
        /// contains information from the 'About this result' panel
        /// <br/>Note: this object is deprecated and always returns <c>null</c>
        /// </summary>
        [Obsolete]
        [JsonProperty("about_this_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AboutThisResultElement AboutThisResult { get; set; }

        /// <summary>
        /// related result from the same domain
        /// <br/>related result from the same domain appears as a part of the main result snippet;
        /// <br/>you can derive the <c>related_result</c> snippets as <c>'type': 'organic'</c> results by setting the <c>group_organic_results</c> parameter to <c>false</c> in the POST request
        /// </summary>
        [JsonProperty("related_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<RelatedResult> RelatedResult { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
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