using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsStatusResultInfo
    {
        /// <summary>
        /// update information for the Google endpoints
        /// </summary>
        [Newtonsoft.Json.JsonProperty("google", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DataforseoLabsStatusInfo Google { get; set; }

        /// <summary>
        /// update information for the Bing endpoints
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DataforseoLabsStatusInfo Bing { get; set; }

        /// <summary>
        /// update information for the Amazon endpoints
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amazon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DataforseoLabsStatusInfo Amazon { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}