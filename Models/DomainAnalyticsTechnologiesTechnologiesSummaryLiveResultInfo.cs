using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DomainAnalyticsTechnologiesTechnologiesSummaryLiveResultInfo 
    {

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
        /// distribution of websites by content language
        /// <br/>contains content language codes and number of websites per language
        /// </summary>
        [JsonProperty("content_languages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ContentLanguages { get; set; }

        /// <summary>
        /// distribution of websites by keywords
        /// <br/>contains keywords found in the websites’ titles, descriptions or meta keywords, and number of websites using each keyword
        /// </summary>
        [JsonProperty("keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> Keywords { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}