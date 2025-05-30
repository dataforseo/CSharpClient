using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ReviewMentionInfo 
    {

        /// <summary>
        /// title of the evaluated criterion
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// positive score by criterion
        /// </summary>
        [JsonProperty("positive_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? PositiveScore { get; set; }

        /// <summary>
        /// count of positive reviews by criterion
        /// </summary>
        [JsonProperty("positive_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PositiveCount { get; set; }

        /// <summary>
        /// count of negative reviews by criterion
        /// </summary>
        [JsonProperty("negative_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NegativeCount { get; set; }

        /// <summary>
        /// count of all reviews by criterion
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalCount { get; set; }

        /// <summary>
        /// element is visible by default
        /// <br/>indicates whether the review element is visible by default
        /// </summary>
        [JsonProperty("visible_by_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? VisibleByDefault { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}