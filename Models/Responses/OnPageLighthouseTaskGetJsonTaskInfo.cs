using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageLighthouseTaskGetJsonTaskInfo : BaseResponseTaskInfo
    {
        /// <summary>
        /// results of Lighthouse audit
        /// <br/>this array will include data according to the parameters specified in the POST request;
        /// <br/>description of the fields in the result array is available in the official documentation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<System.Collections.Generic.IDictionary<string, object>> Result { get; set; }
    }
}