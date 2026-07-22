using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentParsingElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// date and time when the content was fethced
        /// <br/>example:
        /// <br/>'2022-11-01 10:02:52 +00:00'
        /// </summary>
        [JsonProperty("fetch_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FetchTime { get; set; }

        /// <summary>
        /// general status code
        /// <br/>you can find the full list of the response codes here
        /// <br/>Note: we strongly recommend designing a necessary system for handling related exceptional or error conditions
        /// </summary>
        [JsonProperty("status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// parsed content of the page
        /// </summary>
        [JsonProperty("page_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageContentInfo PageContent { get; set; }

        /// <summary>
        /// page content in the markdown format
        /// <br/>page content in the text-to-HTML markdown format
        /// <br/>specify markdown_view as true in the request to return the value
        /// </summary>
        [JsonProperty("page_as_markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageAsMarkdown { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}