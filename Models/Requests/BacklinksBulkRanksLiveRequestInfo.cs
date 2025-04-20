using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksBulkRanksLiveRequestInfo
    {
        /// <summary>
        /// domains, subdomains or webpages to get rank for
        /// <br/>required field
        /// <br/>you can set up to 1000 domains, subdomains or webpages
        /// <br/>the domain or subdomain should be specified without https:// and www.
        /// <br/>the page should be specified with absolute URL (including http:// or https://)
        /// <br/>example:
        /// <br/>"targets": [
        /// <br/>  "forbes.com",
        /// <br/>  "cnn.com",
        /// <br/>  "bbc.com",
        /// <br/>  "yelp.com",
        /// <br/>  "https://www.apple.com/iphone/",
        /// <br/>  "https://ahrefs.com/blog/",
        /// <br/>  "ibm.com",
        /// <br/>  "https://variety.com/",
        /// <br/>  "https://stackoverflow.com/",
        /// <br/>  "www.trustpilot.com"
        /// <br/>]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("targets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Targets { get; set; }

        /// <summary>
        /// defines the scale used for calculating and displaying the rank, domain_from_rank, and page_from_rank values
        /// <br/>optional field
        /// <br/>you can use this parameter to choose whether rank values are presented on a 0–100 or 0–1000 scale
        /// <br/>possible values:
        /// <br/>one_hundred — rank values are displayed on a 0–100 scale
        /// <br/>one_thousand — rank values are displayed on a 0–1000 scale
        /// <br/>default value: one_thousand
        /// <br/>learn more about how this parameter works and how ranking metrics are calculated in this Help Center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_scale", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RankScale { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}