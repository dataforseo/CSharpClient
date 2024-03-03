namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RedditReviews
    {
        /// <summary>
        /// the name of the subreddit
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subreddit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Subreddit { get; set; }

        /// <summary>
        /// nickname of the author
        /// <br/>nicknname of the user who published the post in the subreddit and shared the URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("author_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// title of the subreddit post
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL to the subreddit post
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permalink", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Permalink { get; set; }

        /// <summary>
        /// number of subreddit members
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subreddit_members", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SubredditMembers { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}