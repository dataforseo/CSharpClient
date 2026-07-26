using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinksBulkRanksLiveItem 
    {

        /// <summary>
        /// domain, subdomain or webpage from a POST array
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// rank of the <c>target</c>
        /// <br/>values represent real-time data for the date of the request
        /// <br/><c>rank</c> is calculated based on the method for node ranking in a linked database - a principle used in the original Google PageRank algorithm
        /// <br/>learn more about the metric and how it is calculated in <see href="https://dataforseo.com/help-center/what_is_rank_in_backlinks_api">this help center article</see>
        /// </summary>
        [JsonProperty("rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}