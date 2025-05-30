using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class WorkHours 
    {

        /// <summary>
        /// work hours timetable
        /// </summary>
        [JsonProperty("timetable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<WorkDayInfo>> Timetable { get; set; }

        /// <summary>
        /// current status of the establishment
        /// <br/>indicates whether the establishment is opened or closed
        /// </summary>
        [JsonProperty("current_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentStatus { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}