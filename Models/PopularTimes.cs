using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PopularTimes 
    {

        /// <summary>
        /// popular hours
        /// <br/>information about busy hours of the local establishment on each day of the week
        /// </summary>
        [JsonProperty("popular_times_by_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, IEnumerable<PopularWorkTimeInfo>> PopularTimesByDays { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}