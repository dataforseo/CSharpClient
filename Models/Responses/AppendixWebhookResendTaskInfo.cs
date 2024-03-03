using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixWebhookResendTaskInfo : BaseResponseTaskInfo
    {
        /// <summary>
        /// array of results
        /// <br/>the value of this array is always null;
        /// <br/>you can get the results by the preferred method of results delivery (pingback or postback) you specified when setting a task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Result { get; set; }
    }
}