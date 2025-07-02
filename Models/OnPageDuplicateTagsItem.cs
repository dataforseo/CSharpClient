using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageDuplicateTagsItem 
    {

        /// <summary>
        /// contains the value of duplicated tag
        /// </summary>
        [JsonProperty("accumulator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Accumulator { get; set; }

        /// <summary>
        /// total count of duplicate pages
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// pages with duplicate tags
        /// </summary>
        [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseOnPageResourceItemInfo> Pages { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}