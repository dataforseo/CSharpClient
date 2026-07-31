using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PaidSerpElementItem  : BaseSerpApiElementItem 
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
        /// name of the website in SERP
        /// </summary>
        [JsonProperty("website_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string WebsiteName { get; set; }

        /// <summary>
        /// indicates whether the element contains an image
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("is_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImage { get; set; }

        /// <summary>
        /// indicates whether the element contains a video
        /// <br/>Note: this check no longer appears in SERP
        /// </summary>
        [JsonProperty("is_video", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVideo { get; set; }

        /// <summary>
        /// array of properties detected for the SERP element
        /// <br/>lists the properties that are true for this element
        /// <br/>each value in the array represents a detected property
        /// <br/>example:
        /// <br/>if is_image is present in the array, the element contains an image
        /// <br/>possible values in the array:
        /// <br/>is_image, is_video, is_featured_snippet, amp_version, is_malicious, is_web_story, is_highly_cited
        /// <br/>equals null if none of the properties are detected for the element
        /// <br/>learn more about the checks array in this Help Center article
        /// </summary>
        [JsonProperty("checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Checks { get; set; }

        /// <summary>
        /// images of the element
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiModeImagesElementInfo> Images { get; set; }

        /// <summary>
        /// words highlighted in bold within the results description
        /// </summary>
        [JsonProperty("highlighted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Highlighted { get; set; }

        /// <summary>
        /// additional information about the result
        /// </summary>
        [JsonProperty("extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Extra { get; set; }

        /// <summary>
        /// extended description
        /// <br/>if there is none, equals null
        /// </summary>
        [JsonProperty("description_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DescriptionRows { get; set; }

        /// <summary>
        /// link of the element
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AdLinkElement> Links { get; set; }

        /// <summary>
        /// pricing details
        /// <br/>contains the pricing details of the product or service featured in the result;
        /// <br/>if there is none, equals null
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// the item’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// <br/>if there is none, equals null
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingInfo Rating { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}