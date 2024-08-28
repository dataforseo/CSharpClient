namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsBingDomainIntersectionLiveItem
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
        public KeywordData KeywordData { get; set; }

        /// <summary>
        /// contains data on the first domain’s SERP element found for the returned keyword
        /// <br/>the list of supported SERP elements can be found below
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_domain_serp_element", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BaseDataforseoLabsSerpElementItem FirstDomainSerpElement { get; set; }

        /// <summary>
        /// contains data on the second domain’s SERP element found for the returned keyword
        /// <br/>the list of supported SERP elements can be found below
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_domain_serp_element", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BaseDataforseoLabsSerpElementItem SecondDomainSerpElement { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}