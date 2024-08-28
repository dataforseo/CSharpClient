using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksIndexResultInfo
    {
        /// <summary>
        /// total number of backlinks our database contains for the moment of checking
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalBacklinks { get; set; }

        /// <summary>
        /// total number of pages our database contains for the moment of checking
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_pages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalPages { get; set; }

        /// <summary>
        /// total number of domains our database contains for the moment of checking
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_domains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? TotalDomains { get; set; }

        /// <summary>
        /// index volume data for the past 12 months
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index_history", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<IndexHistory> IndexHistory { get; set; }

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