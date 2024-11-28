using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataBingAudienceEstimationJobFunctionsResultInfo
    {
        /// <summary>
        /// ID of the job function
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_function_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? JobFunctionId { get; set; }

        /// <summary>
        /// name of the job function
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_function_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string JobFunctionName { get; set; }

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