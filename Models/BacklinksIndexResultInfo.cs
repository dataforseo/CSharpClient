using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksIndexResultInfo 
    {

        /// <summary>
        /// total number of backlinks our database contains for the moment of checking
        /// </summary>
        [JsonProperty("total_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalBacklinks { get; set; }

        /// <summary>
        /// total number of pages our database contains for the moment of checking
        /// </summary>
        [JsonProperty("total_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPages { get; set; }

        /// <summary>
        /// index volume data for the past 12 months
        /// </summary>
        [JsonProperty("index_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<IndexHistory> IndexHistory { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}