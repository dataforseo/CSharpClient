using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataSocialMediaRedditLiveResultInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// URL of the page the data is provided for
        /// <br/>corresponding URL you specified in the targets array when setting a task
        /// </summary>
        [JsonProperty("page_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageUrl { get; set; }

        /// <summary>
        /// reddit reviews for the page_url
        /// </summary>
        [JsonProperty("reddit_reviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<RedditReviews> RedditReviews { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}