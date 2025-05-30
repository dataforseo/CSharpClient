using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsTechnologiesTechnologyStatsLiveItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date for which the data is provided
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// number of domains that use the specified technology
        /// </summary>
        [JsonProperty("domains_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainsCount { get; set; }

        /// <summary>
        /// distribution of websites by country
        /// <br/>contains country codes and number of websites per country
        /// </summary>
        [JsonProperty("countries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> Countries { get; set; }

        /// <summary>
        /// distribution of websites by language
        /// <br/>contains language codes and number of websites per language
        /// </summary>
        [JsonProperty("languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> Languages { get; set; }

        /// <summary>
        /// distribution of websites by backlink rank
        /// <br/>contains domain rank ranges and number of websites per range
        /// <br/>learn more about rank and how it is calculated in this help center article
        /// </summary>
        [JsonProperty("domains_rank", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> DomainsRank { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}