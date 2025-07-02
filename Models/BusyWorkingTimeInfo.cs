using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusyWorkingTimeInfo 
    {

        /// <summary>
        /// busy hours
        /// </summary>
        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WorkTimeInfo Time { get; set; }

        /// <summary>
        /// popularity index
        /// <br/>relative time-bound popularity index measured from 0 to 100;
        /// <br/>higher value corresponds to a busier time of a day
        /// </summary>
        [JsonProperty("popular_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PopularIndex { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}