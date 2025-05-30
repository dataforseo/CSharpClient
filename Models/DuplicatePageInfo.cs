using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DuplicatePageInfo 
    {

        /// <summary>
        /// content similarity score
        /// <br/>by default, the content is considered duplicate if the value is greater than or equals 6
        /// <br/>can take values from 0 to 10
        /// </summary>
        [JsonProperty("similarity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Similarity { get; set; }

        /// <summary>
        /// information about the page with duplicate content
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<BaseOnPageResourceItemInfo> Page { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}