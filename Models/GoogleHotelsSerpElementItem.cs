using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleHotelsSerpElementItem  : BaseSerpApiElementItem 
    {

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values;
        /// <br/>positions of elements with different type values are omitted from rank_group;
        /// <br/>always equals 0 for desktop
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// <br/>always equals 0 for desktop
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// unique hotel identifier
        /// <br/>unique hotel identifier assigned by Google;
        /// <br/>example: 'CgoIjaeSlI6CnNpVEAE'
        /// </summary>
        [JsonProperty("hotel_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// google-defined client id
        /// </summary>
        [JsonProperty("cid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cid { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}