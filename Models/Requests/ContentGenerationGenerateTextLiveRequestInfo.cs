using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationGenerateTextLiveRequestInfo
    {
        /// <summary>
        /// main topic of the content to generate
        /// <br/>required field
        /// <br/>main topic for generating content;
        /// <br/>can contain from 1 to 50 tokens
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// number of words in content
        /// <br/>required field
        /// <br/>the number of tokens in the generated text;
        /// <br/>can take values from 1 to 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("word_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? WordCount { get; set; }

        /// <summary>
        /// secondary topics of the content to generate
        /// <br/>optional field
        /// <br/>secondary topics for generating content;
        /// <br/>can contain up to 10 terms;
        /// <br/>example: "sub_topics": ["Apple","Pixar","Amazing Products"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_topics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> SubTopics { get; set; }

        /// <summary>
        /// meta description of the content to generate
        /// <br/>optional field
        /// <br/>can contain from 1 to 1000 tokens
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// keywords for the content to generate
        /// <br/>optional field
        /// <br/>can contain up to 10 terms;
        /// <br/>learn more about this parameter on our help center
        /// <br/>example: "meta_keywords": ["iPhone","sell","CEO"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta_keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> MetaKeywords { get; set; }

        /// <summary>
        /// creativity of content generation
        /// <br/>optional field
        /// <br/>the randomness of the selection of equally probable subsequent tokens;
        /// <br/>can take values from 0 to 1
        /// <br/>default value: 0.8
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creativity_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? CreativityIndex { get; set; }

        /// <summary>
        /// include conclusion in generated text
        /// <br/>optional field
        /// <br/>if set to true, generated content will include a logical conclusion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_conclusion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeConclusion { get; set; }

        /// <summary>
        /// token for generating subsequent results
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>you can use this parameter to continue the generation of text from the initial response
        /// <br/>supplement_token values are unique for each subsequent task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplement_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplementToken { get; set; }

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