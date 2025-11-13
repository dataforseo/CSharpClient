using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiStopCrawlOnMatchInfo 
    {

        /// <summary>
        /// arget domain or wildcard value
        /// <br/>required field if stop_crawl_on_match is specified;
        /// <br/>specify a target domain or wildcard value;
        /// <br/>Note: domain name must be specified without a request protocol;
        /// <br/>example: dataforseo.com
        /// </summary>
        [JsonProperty("match_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchValue { get; set; }

        /// <summary>
        /// target match type
        /// <br/>required field if stop_crawl_on_match is specified;
        /// <br/>type of match for the match_value
        /// <br/>possible values: domain, with_subdomains, wildcard
        /// </summary>
        [JsonProperty("match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}