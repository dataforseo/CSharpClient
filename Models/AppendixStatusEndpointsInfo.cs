using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixStatusEndpointsInfo 
    {

        /// <summary>
        /// name of the endpoint
        /// <br/>the list of possible endpoints:
        /// <br/>task_get
        /// <br/>task_post
        /// <br/>live
        /// <br/>postback/pingback
        /// </summary>
        [JsonProperty("endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// current status
        /// <br/>you can find all information about your API statuses for the last 60 days here
        /// <br/>the list of possible current statuses:
        /// <br/>major_outage
        /// <br/>partial_outage
        /// <br/>long_response_time
        /// <br/>long_execution_time
        /// <br/>webhook_delay
        /// <br/>send_delay
        /// </summary>
        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}