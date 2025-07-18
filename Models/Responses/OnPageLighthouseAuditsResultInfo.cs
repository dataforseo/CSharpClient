using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageLighthouseAuditsResultInfo
    {
        /// <summary>
        /// the list of available lighthouse audits
        /// <br/>an array containing the titles of available audits;
        /// <br/>Note: the titles can change depending on if the audit passed or failed and may contain markdown code;
        /// <br/>Note #2: if you’re using the audit that contains a slash (/) in its name, search by the last word after the slash
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Audits { get; set; }

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