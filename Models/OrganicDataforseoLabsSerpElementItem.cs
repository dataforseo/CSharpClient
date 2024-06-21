namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrganicDataforseoLabsSerpElementItem : BaseDataforseoLabsSerpElementItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// subdomain in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// relevant URL in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// breadcrumb in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("breadcrumb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// relevant website name in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WebsiteName { get; set; }

        /// <summary>
        /// indicates whether the element contains an image
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsImage { get; set; }

        /// <summary>
        /// indicates whether the element contains a video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_video", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsVideo { get; set; }

        /// <summary>
        /// indicates whether the element is a featured_snippet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_featured_snippet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsFeaturedSnippet { get; set; }

        /// <summary>
        /// indicates whether the element is marked as malicious
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_malicious", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsMalicious { get; set; }

        /// <summary>
        /// description of the results element in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// includes additional information appended before the result description in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_snippet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PreSnippet { get; set; }

        /// <summary>
        /// includes additional information appended after the result description in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extended_snippet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExtendedSnippet { get; set; }

        /// <summary>
        /// Accelerated Mobile Pages
        /// <br/>indicates whether an item has the Accelerated Mobile Page (AMP) version
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amp_version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AmpVersion { get; set; }

        /// <summary>
        /// the item’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        /// <summary>
        /// words highlighted in bold within the results description
        /// </summary>
        [Newtonsoft.Json.JsonProperty("highlighted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Highlighted { get; set; }

        /// <summary>
        /// sitelinks
        /// <br/>the links shown below some of Google’s search results
        /// <br/>if there are none, equals null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdLinkElement> Links { get; set; }

        /// <summary>
        /// contains information from the ‘About this result’ panel
        /// <br/>‘About this result’ panel provides additional context about why Google returned this result for the given query;
        /// <br/>this feature appears after clicking on the three dots next to most results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("about_this_result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, AboutThisResultElement> AboutThisResult { get; set; }

        /// <summary>
        /// primary domain name in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainDomain { get; set; }

        /// <summary>
        /// URL in SERP that does not specify the HTTPs protocol and domain name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relative_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelativeUrl { get; set; }

        /// <summary>
        /// estimated traffic volume
        /// <br/>estimated paid monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Etv { get; set; }

        /// <summary>
        /// estimated traffic volume based on impressions
        /// <br/>estimated paid monthly traffic to the domain
        /// <br/>calculated as the product of CTR (click-through-rate) and impressions values of all keywords in the category that the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("impressions_etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ImpressionsEtv { get; set; }

        /// <summary>
        /// estimated cost of monthly search traffic
        /// <br/>represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values of all keywords in the category that the domain ranks for
        /// <br/>learn more about how the metric is calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_paid_traffic_cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? EstimatedPaidTrafficCost { get; set; }

        /// <summary>
        /// estimated traffic volume based on clickstream data
        /// <br/>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clickstream_etv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ClickstreamEtv { get; set; }

        /// <summary>
        /// changes in rankings
        /// <br/>contains information about the ranking changes of the SERP element since the previous_updated_time
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_changes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RankChanges RankChanges { get; set; }

        /// <summary>
        /// backlinks information for the target website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BacklinksInfo BacklinksInfo { get; set; }

        /// <summary>
        /// page and domain rank information
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RankInfo RankInfo { get; set; }

    }
}