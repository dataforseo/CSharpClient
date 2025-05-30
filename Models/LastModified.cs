using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class LastModified 
    {

        /// <summary>
        /// date and time when the header was last modified
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// <br/>if there is no data, the value will be null
        /// </summary>
        [JsonProperty("header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Header { get; set; }

        /// <summary>
        /// date and time when the sitemap was last modified
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// <br/>if there is no data, the value will be null
        /// </summary>
        [JsonProperty("sitemap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Sitemap { get; set; }

        /// <summary>
        /// date and time when the meta tag was last modified
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// <br/>if there is no data, the value will be null
        /// </summary>
        [JsonProperty("meta_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MetaTag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}