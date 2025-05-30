using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixStatusResultInfo
    {
        /// <summary>
        /// name of the API
        /// <br/>the list of APIs:
        /// <br/>serp
        /// <br/>keywords_data
        /// <br/>appendix
        /// <br/>dataforseo_labs
        /// <br/>domain_analytics
        /// <br/>merchant
        /// <br/>on_page
        /// <br/>business_data
        /// <br/>backlinks
        /// <br/>app_data
        /// <br/>content_analysis
        /// <br/>content_generation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("api", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Api { get; set; }

        /// <summary>
        /// current status
        /// <br/>you can find all information about the statuses of our endpoints for the last 60 days here
        /// <br/>the list of possible current statuses:
        /// <br/>major_outage
        /// <br/>partial_outage
        /// <br/>long_response_time
        /// <br/>long_execution_time
        /// <br/>webhook_delay
        /// <br/>send_delay
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// array of objects that contain status information for API endpoints
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endpoints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppendixStatusEndpointsInfo> Endpoints { get; set; }

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