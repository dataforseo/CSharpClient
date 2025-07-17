using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceFinancialElementItem  : BaseSerpApiGoogleFinanceElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// quarterly google finance metrics
        /// </summary>
        [JsonProperty("quarterly_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleFinanceMetricsBundleInfo> QuarterlyMetrics { get; set; }

        /// <summary>
        /// annual google finance metrics
        /// </summary>
        [JsonProperty("annual_metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleFinanceMetricsBundleInfo> AnnualMetrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}