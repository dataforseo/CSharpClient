using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageErrorsResultInfo 
    {

        /// <summary>
        /// id of the task
        /// </summary>
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// date and time when an error occurred
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// corresponding API function
        /// </summary>
        [JsonProperty("function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Function { get; set; }

        /// <summary>
        /// error code
        /// </summary>
        [JsonProperty("error_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// error message or error URL
        /// <br/>error message (see full list) or URL that caused an error
        /// </summary>
        [JsonProperty("error_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// URL that caused an error
        /// <br/>URL you used for making an API call or pingback/postback URL
        /// </summary>
        [JsonProperty("http_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HttpUrl { get; set; }

        /// <summary>
        /// HTTP method
        /// </summary>
        [JsonProperty("http_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// HTTP status code
        /// </summary>
        [JsonProperty("http_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// time taken by HTTP request
        /// <br/>for tasks set with a pingback/postback, this field will show the time it took your server to respond
        /// </summary>
        [JsonProperty("http_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HttpTime { get; set; }

        /// <summary>
        /// HTTP response
        /// <br/>server response
        /// </summary>
        [JsonProperty("http_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HttpResponse { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}