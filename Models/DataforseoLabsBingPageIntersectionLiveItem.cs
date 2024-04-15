namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsBingPageIntersectionLiveItem
    {
        /// <summary>
        /// search engine type
        /// <br/>search engine type specified in a POST request;
        /// <br/>for this endpoint, the field equals bing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// keyword data for the returned keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeywordDataKeywordDataInfo KeywordData { get; set; }

        /// <summary>
        /// contains data on the SERP elements found for the returned keyword
        /// <br/>data will be provided in separate arrays for each URL you specified in the pages object when setting a task;
        /// <br/>depending on the number of specified URLs, it can contain from 1 to 20 arrays named respectively
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intersection_result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, BaseDataforseoLabsSerpElementItem> IntersectionResult { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}