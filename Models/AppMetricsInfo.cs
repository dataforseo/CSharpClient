using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppMetricsInfo 
    {

        /// <summary>
        /// number of organic SERPs where the product ranks #1
        /// </summary>
        [JsonProperty("pos_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos1 { get; set; }

        /// <summary>
        /// number of organic SERPs where the product ranks #2-3
        /// </summary>
        [JsonProperty("pos_2_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos23 { get; set; }

        /// <summary>
        /// number of organic SERPs where the product ranks #4-10
        /// </summary>
        [JsonProperty("pos_4_10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos410 { get; set; }

        /// <summary>
        /// number of organic SERPs where the product ranks #11-100
        /// </summary>
        [JsonProperty("pos_11_100", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pos11100 { get; set; }

        /// <summary>
        /// total count of Amazon organic SERPs that contain the product
        /// </summary>
        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Count { get; set; }

        /// <summary>
        /// total search volume of the product’s ranking keywords in organic SERP
        /// </summary>
        [JsonProperty("search_volume", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SearchVolume { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}