using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("amazon_paid", typeof(MerchantAmazonPaidSerpElementItem))]
    [JsonInheritance("amazon_serp", typeof(MerchantAmazonSerpSerpElementItem))]
    [JsonInheritance("editorial_recommendations", typeof(MerchantEditorialRecommendationsSerpElementItem))]
    [JsonInheritance("related_searches", typeof(MerchantRelatedSearchesSerpElementItem))]
    [JsonInheritance("top_rated_from_our_brands", typeof(MerchantTopRatedFromOurBrandsSerpElementItem))]

    public class BaseMerchantAmazonElementItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical <c>type</c> values
        /// <br/>positions of elements with different <c>type</c> values are omitted from <c>rank_group</c>
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements found in Amazon SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the <see href="https://en.wikipedia.org/wiki/XPath">XPath</see> of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}