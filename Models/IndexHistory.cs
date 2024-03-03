namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class IndexHistory
    {
        /// <summary>
        /// date for which index volume data is provided
        /// <br/>in the UTC format: “yyyy-mm-dd”
        /// <br/>example:
        /// <br/>2021-10-01
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// total number of backlinks our database contained on the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalBacklinks { get; set; }

        /// <summary>
        /// total number of pages our database contained on the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalPages { get; set; }

        /// <summary>
        /// total number of domains our database contained on the given date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalDomains { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}