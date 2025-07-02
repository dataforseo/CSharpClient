using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataBingAudienceEstimationJobFunctionsResultInfo 
    {

        /// <summary>
        /// ID of the job function
        /// </summary>
        [JsonProperty("job_function_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? JobFunctionId { get; set; }

        /// <summary>
        /// name of the job function
        /// </summary>
        [JsonProperty("job_function_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string JobFunctionName { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}