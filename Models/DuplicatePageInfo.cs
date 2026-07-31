using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DuplicatePageInfo 
    {
        [JsonProperty("similarity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Similarity { get; set; }

        /// <summary>
        /// information about the page with duplicate content
        /// </summary>
        [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<OnPageHtmlResourceItem> Page { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}