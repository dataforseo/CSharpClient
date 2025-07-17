using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageRedirectResourceItem  : BaseOnPageResourceItem 
    {

        /// <summary>
        /// time range within which a result was fetched
        /// </summary>
        [JsonProperty("fetch_timing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FetchTiming FetchTiming { get; set; }

        /// <summary>
        /// indicates whether a page is a single resource
        /// </summary>
        [JsonProperty("is_resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsResource { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}