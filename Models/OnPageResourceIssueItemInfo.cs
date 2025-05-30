using Newtonsoft.Json;
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
        public double? Line { get; set; }

        /// <summary>
        /// column where the error was found
        /// </summary>
        [JsonProperty("column", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Column { get; set; }

        /// <summary>
        /// text message of the error
        /// <br/>the full list of possible HTML errors can be found here
        /// </summary>
        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// status code of the error
        /// <br/>possible values:
        /// <br/>0 — Unidentified Error;
        /// <br/>501 — Html Parse Error;
        /// <br/>1501 — JS Parse Error;
        /// <br/>2501 — CSS Parse Error;
        /// <br/>3501 — Image Parse Error;
        /// <br/>3502 — Image Scale Is Zero;
        /// <br/>3503 — Image Size Is Zero;
        /// <br/>3504 — Image Format Invalid
        /// </summary>
        [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? StatusCode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}