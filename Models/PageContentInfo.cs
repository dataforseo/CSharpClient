namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PageContentInfo
    {
        /// <summary>
        /// content of the header of the table
        /// </summary>
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PageSectionContentInfo Header { get; set; }

        /// <summary>
        /// parsed content of the footer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("footer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PageSectionContentInfo Footer { get; set; }

        /// <summary>
        /// main topic on the page
        /// <br/>you can find more information about topic priority calculation in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TopicInfo> MainTopic { get; set; }

        /// <summary>
        /// secondary topic on the page
        /// <br/>you can find more information about topic priority calculation in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secondary_topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TopicInfo> SecondaryTopic { get; set; }

        /// <summary>
        /// contains objects with rating information for the products displayed on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ratings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentRatingInfo> Ratings { get; set; }

        /// <summary>
        /// array of products displayed on the page
        /// <br/>contains objects with information on products displayed on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentOfferInfo> Offers { get; set; }

        /// <summary>
        /// array of comments displayed on the page
        /// <br/>contains objects with information on comments related to displayed products
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContentCommentInfo> Comments { get; set; }

        /// <summary>
        /// contact information
        /// <br/>contains contact information displayed on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contacts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Contacts Contacts { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}