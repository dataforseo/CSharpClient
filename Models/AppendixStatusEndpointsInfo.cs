namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppendixStatusEndpointsInfo
    {
        /// <summary>
        /// name of the endpoint
        /// <br/>the list of possible endpoints:
        /// <br/>task_get
        /// <br/>task_post
        /// <br/>live
        /// <br/>postback/pingback
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endpoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

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

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}