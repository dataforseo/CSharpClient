using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordInfoNormalizedWithInfo 
    {

        /// <summary>
        /// date and time when the dataset was updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// current search volume rate of a keyword
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchVolume { get; set; }

        /// <summary>
        /// keyword info is normalized
        /// <br/>if true, values are normalized with Bing data
        /// </summary>
        [JsonProperty("is_normalized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IsNormalized { get; set; }

        /// <summary>
        /// monthly search volume rates
        /// <br/>array of objects with search volume rates in a certain month of a year
        /// </summary>
        [JsonProperty("monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MonthlySearches> MonthlySearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}