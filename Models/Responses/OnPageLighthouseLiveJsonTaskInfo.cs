using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageLighthouseLiveJsonTaskInfo : BaseResponseTaskInfo
    {
        /// <summary>
        /// results of Lighthouse audit
        /// <br/>this array will include data according to the parameters you specified when setting a task;
        /// <br/>all fields and their descriptions are available in the official documentation by this link.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<System.Collections.Generic.IDictionary<string, object>> Result { get; set; }
    }
}