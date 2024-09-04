namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StoresCountInfo
    {
        /// <summary>
        /// number of stores that offer the product
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Count { get; set; }

        /// <summary>
        /// text displayed on the Google Shopping page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayed_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayedText { get; set; }

        /// <summary>
        /// whether the number of stores is taken from text
        /// <br/>indicates whether the number of stores is taken from displayed_text;
        /// <br/>if the API finds the exact number of stores in the HTML code of the Google Shopping page, this parameter is false;
        /// <br/>if the API cannot find the number of stores in the HTML code of the page, it takes the number from the displayed_text;
        /// <br/>in this case, the parameter is true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count_from_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CountFromText { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}