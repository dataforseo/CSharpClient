using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpAiSummaryRequestInfo
    {
        /// <summary>
        /// task identifier
        /// <br/>required field
        /// <br/>unique identifier of the associated task in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// AI prompt
        /// <br/>optional field
        /// <br/>additional task for AI summariser;
        /// <br/>any form of text, question or information that communicates to AI what response you’re looking for;
        /// <br/>max number of symbols or characters you can specify: 2000;
        /// <br/>note: your prompt has to be relevant to the keyword specified in the POST request to SERP API
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prompt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Prompt { get; set; }

        /// <summary>
        /// support extra SERP features
        /// <br/>optional field
        /// <br/>if set to true, the AI model will consider the following extra SERP features, in addition to organic results: answer_box, knowledge_graph, featured_snippet;
        /// <br/>default value: true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_extra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SupportExtra { get; set; }

        /// <summary>
        /// fetch content from pages in SERPs
        /// <br/>optional field
        /// <br/>if set to true, the API will fetch the content from pages featured in SERP results, and the AI model will consider this content when generating the summary in the result;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fetch_content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FetchContent { get; set; }

        /// <summary>
        /// include source links in the summary
        /// <br/>optional field
        /// <br/>if set to true, the summary field in the API response will contain links to sources of the generated summary;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeLinks { get; set; }

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