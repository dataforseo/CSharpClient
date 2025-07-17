using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataClickstreamDataSearchVolumeLiveItem 
    {

        /// <summary>
        /// keyword provided in the POST array
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// current search volume rate of a keyword
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SearchVolume { get; set; }

        /// <summary>
        /// monthly search volume rates
        /// <br/>array of objects with search volume rates in a certain month of a year
        /// </summary>
        [JsonProperty("monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<MonthlySearchesInfo> MonthlySearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}