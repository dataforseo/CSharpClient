using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataLabsGooglePostsSerpElementItem  : BaseDataforseoLabsApiElementItem 
    {

        /// <summary>
        /// the identifier of the google_posts feature
        /// </summary>
        [JsonProperty("posts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostsId { get; set; }

        /// <summary>
        /// the additional feature of the review
        /// </summary>
        [JsonProperty("feature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }

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