using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class YoutubeCommentSerpElementItem  : BaseYoutubeSerpElementItem 
    {

        /// <summary>
        /// name of the author of the comment
        /// </summary>
        [JsonProperty("author_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// the URL of the page where the author’s channel logo is hosted
        /// </summary>
        [JsonProperty("author_thumbnail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorThumbnail { get; set; }

        /// <summary>
        /// URL of the author’s channel
        /// </summary>
        [JsonProperty("author_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// text of the comment
        /// </summary>
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// displayed publication date
        /// </summary>
        [JsonProperty("publication_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2022-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// number of likes on the comment
        /// </summary>
        [JsonProperty("likes_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? LikesCount { get; set; }

        /// <summary>
        /// number of replies on the comment
        /// </summary>
        [JsonProperty("reply_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplyCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}