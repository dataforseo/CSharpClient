namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AnalysisContentInfo
    {
        /// <summary>
        /// type of content
        /// <br/>example:
        /// <br/>page_content, comment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <summary>
        /// title of the result
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// page title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainTitle { get; set; }

        /// <summary>
        /// title of the previous content block
        /// </summary>
        [Newtonsoft.Json.JsonProperty("previous_title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PreviousTitle { get; set; }

        /// <summary>
        /// title heading level
        /// <br/>indicates h-tag level from 1 (top) to 6 (bottom)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// author of the content
        /// </summary>
        [Newtonsoft.Json.JsonProperty("author", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// content snippet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snippet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// character length of the snippet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("snippet_length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SnippetLength { get; set; }

        /// <summary>
        /// social media engagement metrics
        /// <br/>data on social media interactions associated with the content based on website embeds developed and supported by social media platforms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("social_metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SocialMetricsInfo> SocialMetrics { get; set; }

        /// <summary>
        /// highlighted text from the snippet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("highlighted_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HighlightedText { get; set; }

        /// <summary>
        /// content language
        /// <br/>to obtain a full list of available languages, refer to the Languages endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// sentiment connotations
        /// <br/>contains sentiments (emotional reactions) related to the given citation and probability index per each sentiment
        /// <br/>possible sentiment connotations: anger, happiness, love, sadness, share, fun
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sentiment_connotations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> SentimentConnotations { get; set; }

        /// <summary>
        /// connotation types
        /// <br/>contains types of sentiments (sentiment polarity) related to the given citation and probability index per each sentiment type
        /// <br/>possible sentiment connotation types: positive, negative, neutral
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connotation_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ConnotationTypes { get; set; }

        /// <summary>
        /// text category
        /// <br/>to obtain a full list of available categories, refer to the Categories endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text_category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> TextCategory { get; set; }

        /// <summary>
        /// date and time when the content was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_published", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatePublished { get; set; }

        /// <summary>
        /// content quality score
        /// <br/>this value is calculated based on the number of words, sentences and characters the content contains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_quality_score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ContentQualityScore { get; set; }

        /// <summary>
        /// semantic location
        /// <br/>indicates semantic element in HTML where the target keyword citation is located
        /// <br/>example:
        /// <br/>article, header
        /// </summary>
        [Newtonsoft.Json.JsonProperty("semantic_location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SemanticLocation { get; set; }

        /// <summary>
        /// content rating
        /// <br/>rating related to content_info
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentAnalysisRatingInfo Rating { get; set; }

        /// <summary>
        /// citation group date and time
        /// <br/>indicates content publication date or date and time when our crawler visited the page for the first time;
        /// <br/>this field can be used to group citations by date and display citation trends;
        /// <br/>date and time are provided in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2017-01-24 13:20:59 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupDate { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}