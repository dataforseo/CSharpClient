using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AboutThisResultElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// result’s URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// source of additional information about the result
        /// </summary>
        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// additional information about the result
        /// <br/>description of the website from Wikipedia or another additional context
        /// </summary>
        [JsonProperty("source_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInfo { get; set; }

        /// <summary>
        /// URL to full information from the 'source'
        /// </summary>
        [JsonProperty("source_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// the language of the result
        /// </summary>
        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// location for which the result is relevant
        /// </summary>
        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// matching search terms that appear in the result
        /// </summary>
        [JsonProperty("search_terms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SearchTerms { get; set; }

        /// <summary>
        /// related search terms that appear in the result
        /// </summary>
        [JsonProperty("related_terms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> RelatedTerms { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}