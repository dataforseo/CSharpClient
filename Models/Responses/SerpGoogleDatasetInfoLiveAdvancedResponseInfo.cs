using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpGoogleDatasetInfoLiveAdvancedResponseInfo : BaseResponseInfo
    {
        /// <summary>
        /// array of tasks
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tasks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SerpGoogleDatasetInfoLiveAdvancedTaskInfo> Tasks { get; set; }
    }
}