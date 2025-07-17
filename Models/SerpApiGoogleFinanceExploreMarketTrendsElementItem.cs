using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiGoogleFinanceExploreMarketTrendsElementItem  : BaseSerpApiGoogleFinanceElementItem 
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
        /// title of the market trends element
        /// <br/>example: Europe, Middle East, and Africa
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// sub-title of the market trends element
        /// </summary>
        [JsonProperty("sub_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SubTitle { get; set; }

        /// <summary>
        /// URL to finance pair on Google Finance
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// market indexes data
        /// <br/>array of items containing market indexes data;
        /// <br/>possible type of items: google_finance_asset_pair_element, google_finance_market_instrument_element, google_finance_market_index_element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseSerpApiGoogleFinanceElementItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}