using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OtherSitesReviewsInfo 
    {

        /// <summary>
        /// review title
        /// <br/>contains a name of the third-party site where review initially appeared
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// review url
        /// <br/>URL to the a third-party site where review initially appeared
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// review text
        /// <br/>text of the review
        /// </summary>
        [JsonProperty("review_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// rating in the review
        /// <br/>information about the rating enclosed in the review on a third-party site
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