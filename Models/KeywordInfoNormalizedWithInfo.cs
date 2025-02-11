namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordInfoNormalizedWithInfo
    {
        /// <summary>
        /// date and time when the clickstream dataset was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_updated_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// monthly average clickstream search volume rate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// keyword info is normalized
        /// <br/>if true, values are normalized with Bing data
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_normalized", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNormalized { get; set; }

        /// <summary>
        /// monthly clickstream search volume rates
        /// <br/>array of objects with clickstream search volume rates in a certain month of a year
        /// </summary>
        [Newtonsoft.Json.JsonProperty("monthly_searches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MonthlySearches> MonthlySearches { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}