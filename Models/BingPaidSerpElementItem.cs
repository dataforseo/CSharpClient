using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BingPaidSerpElementItem  : BaseBingSerpApiElementItem 
    {

        /// <summary>
        /// domain of the ad element in SERP
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// title of the ad element in SERP
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the ad element in SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// relevant URL of the ad element in SERP
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// breadcrumb of the ad element in SERP
        /// </summary>
        [JsonProperty("breadcrumb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// website name in SERP
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
        /// images of the element
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
        /// links featured in the organic result
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AdLinkElement> Links { get; set; }

        /// <summary>
        /// price of booking a place for the specified dates of stay
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// the item’s rating 
        /// <br/>the popularity rate based on reviews and displayed in SERP
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}