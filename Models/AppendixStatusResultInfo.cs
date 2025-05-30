using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixStatusResultInfo 
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
        [JsonProperty("api", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// array of objects that contain status information for API endpoints
        /// </summary>
        [JsonProperty("endpoints", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AppendixStatusEndpointsInfo> Endpoints { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}