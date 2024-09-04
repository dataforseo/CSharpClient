using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyTaskInfo : BaseResponseTaskInfo
    {
        /// <summary>
        /// array of results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResultInfo> Result { get; set; }
    }
}