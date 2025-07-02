using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonRankedSerpElement 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// contains data on the SERP element
        /// <br/>the list of supported SERP elements can be found below
        /// </summary>
        [JsonProperty("serp_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BaseAmazonSerpElementItem SerpItem { get; set; }

        /// <summary>
        /// direct URL to Amazon results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// direct URL to Amazon results
        /// <br/>contains types of all search results (items) found in the returned SERP;
        /// <br/>possible item types:
        /// <br/>amazon_serp, amazon_paid, editorial_recommendations, top_rated_from_our_brands, related_searches
        /// </summary>
        [JsonProperty("serp_item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SerpItemTypes { get; set; }

        /// <summary>
        /// total number of results in Amazon SERP
        /// </summary>
        [JsonProperty("se_results_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? SeResultsCount { get; set; }

        /// <summary>
        /// date and time when SERP data was last updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// previous to the most recent update of SERP data
        /// <br/>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”
        /// <br/>example:
        /// <br/>2020-09-12T00:07:43.0733218Z
        /// </summary>
        [JsonProperty("previous_updated_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousUpdatedTime { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}