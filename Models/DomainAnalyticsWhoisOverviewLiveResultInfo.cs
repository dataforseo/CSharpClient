using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsWhoisOverviewLiveResultInfo 
    {

        /// <summary>
        /// total amount of results in our database relevant to your request
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// the number of results returned in the <c>items</c> array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// results offset value specified in POST request
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }
        [JsonProperty("offset_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OffsetToken { get; set; }

        /// <summary>
        /// contains ranking and traffic data
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<DomainAnalyticsWhoisOverviewLiveItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}