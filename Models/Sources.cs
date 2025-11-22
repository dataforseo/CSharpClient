using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Sources 
    {

        /// <summary>
        /// source description
        /// </summary>
        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Snippet { get; set; }

        /// <summary>
        /// source name
        /// </summary>
        [JsonProperty("source_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SourceName { get; set; }

        /// <summary>
        /// source thumbnail
        /// </summary>
        [JsonProperty("thumbnail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// content of the element in markdown format
        /// <br/>content of the result formatted in the markdown markup language
        /// </summary>
        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Markdown { get; set; }

        /// <summary>
        /// position in the results
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// source title
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// source domain
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// source URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// date and time when the result was published
        /// <br/>in the format: “year-month-date:minutes:UTC_difference_hours:UTC_difference_minutes”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("publication_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PublicationDate { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}