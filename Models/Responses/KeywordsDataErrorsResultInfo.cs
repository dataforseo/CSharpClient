using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataErrorsResultInfo
    {
        /// <summary>
        /// id of the task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// date and time when an error occurred
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// corresponding API function
        /// </summary>
        [Newtonsoft.Json.JsonProperty("function", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Function { get; set; }

        /// <summary>
        /// error code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ErrorCode { get; set; }

        /// <summary>
        /// error message or error URL
        /// <br/>error message (see full list) or URL that caused an error
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// URL that caused an error
        /// <br/>URL you used for making an API call or pingback/postback URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("http_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HttpUrl { get; set; }

        /// <summary>
        /// HTTP method
        /// </summary>
        [Newtonsoft.Json.JsonProperty("http_method", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// HTTP status code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("http_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HttpCode { get; set; }

        /// <summary>
        /// time taken by HTTP request
        /// <br/>for tasks set with a pingback/postback, this field will show the time it took your server to respond
        /// </summary>
        [Newtonsoft.Json.JsonProperty("http_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? HttpTime { get; set; }

        /// <summary>
        /// HTTP response
        /// <br/>server response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("http_response", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HttpResponse { get; set; }

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