using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class OnPageUncrawlableResourcesItem 
    {

        /// <summary>
        /// URL of the uncrawlable resource
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// reason the resource is uncrawlable
        /// <br/>can take the following values: <c>content_type_inconsistency</c>
        /// </summary>
        [JsonProperty("reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// general status code
        /// <br/>you can find the full list of the response codes <see href="/v3/appendix/errors">here</see>
        /// <br/>Note: we strongly recommend designing a necessary system for handling related exceptional or error conditions
        /// </summary>
        [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// date and time when the resource was fetched
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2026-03-09 18:20:32 +00:00</c>
        /// </summary>
        [JsonProperty("fetch_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// metadata of the uncrawlable resource
        /// </summary>
        [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UncrawlableResourcesMeta Meta { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}