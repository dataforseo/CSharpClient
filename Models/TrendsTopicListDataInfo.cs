namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TrendsTopicListDataInfo
    {
        /// <summary>
        /// the most popular related topics
        /// <br/>represents the list of the most popular related topics
        /// </summary>
        [Newtonsoft.Json.JsonProperty("top", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TopicListDataItemInfo> Top { get; set; }

        /// <summary>
        /// emerging related topics
        /// <br/>represents the list of related topics with the biggest increase in search frequency since the last time period
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rising", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TopicListDataItemInfo> Rising { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}