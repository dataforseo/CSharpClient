using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class RankChanges 
    {

        /// <summary>
        /// previous absolute rank in SERP
        /// <br/>indicates previous rank of the element in Google SERP;
        /// <br/>if this element is new, the value will be null
        /// </summary>
        [JsonProperty("previous_rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PreviousRankAbsolute { get; set; }

        /// <summary>
        /// element was previously present in SERP
        /// <br/>if the value is true, previously collected SERP didn’t contain this element
        /// </summary>
        [JsonProperty("is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// rank of this element went up
        /// <br/>if the value is true, position of the element in SERP is higher compared to the previous check
        /// </summary>
        [JsonProperty("is_up", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUp { get; set; }

        /// <summary>
        /// rank of this element went down
        /// <br/>if the value is true, position of the element in SERP is lower compared to the previous check
        /// </summary>
        [JsonProperty("is_down", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDown { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}