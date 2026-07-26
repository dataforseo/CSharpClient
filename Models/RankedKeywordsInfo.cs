using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RankedKeywordsInfo 
    {
        [JsonProperty("page_from_keywords_count_top_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop3 { get; set; }
        [JsonProperty("page_from_keywords_count_top_10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PageFromKeywordsCountTop10 { get; set; }
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