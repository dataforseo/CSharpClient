using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleQuestionsAndAnswersTaskPostRequestInfo : BusinessDataTaskRequestInfo
    {
        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of question rows in the result
        /// <br/>default value: 20
        /// <br/>max value: 700
        /// <br/>Note: your account will be billed for every 20 questions;
        /// <br/>thus, setting a depth above 20 may result in additional charges if the search engine returns more than 20 questions;
        /// <br/>if the specified depth is higher than the number of questions in the response, the difference will be refunded automatically to your account balance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }
    }
}