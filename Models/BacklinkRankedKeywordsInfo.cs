using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BacklinkRankedKeywordsInfo 
    {

        /// <summary>
        /// number of keywords for which the page is ranked in top 3 search results
        /// </summary>
        [JsonProperty("page_from_keywords_count_top_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop3 { get; set; }

        /// <summary>
        /// number of keywords for which the page is ranked in top 10 search results
        /// </summary>
        [JsonProperty("page_from_keywords_count_top_10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop10 { get; set; }

        /// <summary>
        /// number of keywords for which the page is ranked in top 100 search results
        /// </summary>
        [JsonProperty("page_from_keywords_count_top_100", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop100 { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}