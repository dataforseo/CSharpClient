using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessWorkHoursInfo 
    {

        /// <summary>
        /// open hours
        /// <br/>information about work hours of the local establishment
        /// </summary>
        [JsonProperty("work_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WorkHours WorkHours { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}