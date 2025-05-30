using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpAiSummaryRequestInfo 
    {

        /// <summary>
        /// task identifier
        /// <br/>required field
        /// <br/>unique identifier of the associated task in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time
        /// </summary>
        [JsonProperty("task_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// AI prompt
        /// <br/>optional field
        /// <br/>additional task for AI summariser;
        /// <br/>any form of text, question or information that communicates to AI what response you’re looking for;
        /// <br/>max number of symbols or characters you can specify: 2000;
        /// <br/>note: your prompt has to be relevant to the keyword specified in the POST request to SERP API
        /// </summary>
        [JsonProperty("prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Prompt { get; set; }

        /// <summary>
        /// support extra SERP features
        /// <br/>optional field
        /// <br/>if set to true, the AI model will consider the following extra SERP features, in addition to organic results: answer_box, knowledge_graph, featured_snippet;
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("support_extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportExtra { get; set; }

        /// <summary>
        /// fetch content from pages in SERPs
        /// <br/>optional field
        /// <br/>if set to true, the API will fetch the content from pages featured in SERP results, and the AI model will consider this content when generating the summary in the result;
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("fetch_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FetchContent { get; set; }

        /// <summary>
        /// include source links in the summary
        /// <br/>optional field
        /// <br/>if set to true, the summary field in the API response will contain links to sources of the generated summary;
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("include_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeLinks { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}