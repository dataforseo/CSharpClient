namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixPriorityTasksReadyKeywordsDataPriceDataInfo
    {
        /// <summary>
        /// charge type
        /// <br/>can take the following values:
        /// <br/>per_result – charge for every row in the result array
        /// <br/>per_request – charge for a GET or POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CostType { get; set; }

        /// <summary>
        /// cost, USD
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}