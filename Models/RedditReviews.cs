using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RedditReviews 
    {

        /// <summary>
        /// the name of the subreddit
        /// </summary>
        [JsonProperty("subreddit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Subreddit { get; set; }

        /// <summary>
        /// nickname of the author
        /// <br/>nicknname of the user who published the post in the subreddit and shared the URL
        /// </summary>
        [JsonProperty("author_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// title of the subreddit post
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL to the subreddit post
        /// </summary>
        [JsonProperty("permalink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Permalink { get; set; }

        /// <summary>
        /// number of subreddit members
        /// </summary>
        [JsonProperty("subreddit_members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SubredditMembers { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}