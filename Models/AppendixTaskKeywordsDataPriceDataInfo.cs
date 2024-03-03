namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixTaskKeywordsDataPriceDataInfo
    {
        [Newtonsoft.Json.JsonProperty("priority_low", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityLow { get; set; }

        [Newtonsoft.Json.JsonProperty("priority_normal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityNormal { get; set; }

        [Newtonsoft.Json.JsonProperty("priority_high", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppendixPriorityTasksReadyKeywordsDataPriceDataInfo> PriorityHigh { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}