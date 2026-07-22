using Newtonsoft.Json;
using System;
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
        public int? PreviousRankAbsolute { get; set; }

        /// <summary>
        /// number of new ranked elements
        /// <br/>indicates how many new ranked elements were found for this domain or webpage
        /// </summary>
        [JsonProperty("is_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNew { get; set; }

        /// <summary>
        /// rank went up
        /// <br/>indicates how many ranked elements of this target went up in Google Search
        /// </summary>
        [JsonProperty("is_up", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUp { get; set; }

        /// <summary>
        /// rank went down
        /// <br/>indicates how many ranked elements of this target went down in Google Search
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