using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveItem 
    {

        /// <summary>
        /// specified keyword
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// current AI search volume rate of a keyword
        /// <br/>learn more about this metric here
        /// </summary>
        [JsonProperty("ai_search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AiSearchVolume { get; set; }

        /// <summary>
        /// monthly AI search volume rates
        /// <br/>array of objects with AI search volume rates in a certain month of a year
        /// </summary>
        [JsonProperty("ai_monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AiMonthlySearches> AiMonthlySearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}