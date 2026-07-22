using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageResourceIssueItemInfo 
    {

        /// <summary>
        /// line where the error was found
        /// </summary>
        [JsonProperty("line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line { get; set; }

        /// <summary>
        /// column where the error was found
        /// </summary>
        [JsonProperty("column", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Column { get; set; }

        /// <summary>
        /// text message of the error
        /// <br/>the full list of possible HTML errors can be found here
        /// </summary>
        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// general status code
        /// <br/>you can find the full list of the response codes here
        /// <br/>Note: we strongly recommend designing a necessary system for handling related exceptional or error conditions
        /// </summary>
        [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}