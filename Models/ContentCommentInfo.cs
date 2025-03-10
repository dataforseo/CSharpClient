namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentCommentInfo
    {
        /// <summary>
        /// product’s rating
        /// <br/>contains information about the rating a customer has given to the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ContentRatingInfo Rating { get; set; }

        /// <summary>
        /// title of the customer’s comment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Title { get; set; }

        /// <summary>
        /// date when the comment was published
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublishDate { get; set; }

        /// <summary>
        /// author of the comment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("author", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Author { get; set; }

        [Newtonsoft.Json.JsonProperty("have_form", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HaveForm { get; set; }

        /// <summary>
        /// primary content on the page
        /// <br/>you can find more information about content priority calculation in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primary_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SectionContentItemInfo> PrimaryContent { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}