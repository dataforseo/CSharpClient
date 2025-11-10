using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageAlternateLinkItem  : BaseOnPageLinkItem 
    {

        /// <summary>
        /// hreflang validity status
        /// <br/>indicates whether the hreflang attribute is correctly implemented
        /// </summary>
        [JsonProperty("is_valid_hreflang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValidHreflang { get; set; }

        /// <summary>
        /// hreflang attribute value
        /// <br/>language and optional country code specified in the hreflang attribute
        /// <br/>example: 'en-US', 'fr'
        /// </summary>
        [JsonProperty("hreflang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Hreflang { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}