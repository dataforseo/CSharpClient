using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SerpApiProductConsiderationsExpandedElementItem  : BaseSerpApiProductConsiderationExpandedElementItem 
    {

        /// <summary>
        /// title of the carousel item
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// the title of the featured snippets source page
        /// </summary>
        [JsonProperty("featured_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FeaturedTitle { get; set; }

        /// <summary>
        /// breadcrumb of the Ad element in SERP
        /// </summary>
        [JsonProperty("breadcrumb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// text alongside the link title
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// source domain
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// relevant URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2019-11-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// ((‘related_searches’ element in SERP|https://dataforseo.com/wp-content/uploads/2020/02/window-feature-related-searches.png))
        /// </summary>
        [JsonProperty("related_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> RelatedSearches { get; set; }

        /// <summary>
        /// contains information from the 'About this result' panel
        /// <br/>Note: this object is deprecated and always returns null
        /// </summary>
        [Obsolete]
        [JsonProperty("about_this_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AboutThisResultElement AboutThisResult { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}