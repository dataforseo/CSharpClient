using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class ContentGenerationGenerateTextLiveRequestInfo 
    {

        /// <summary>
        /// main topic of the content to generate
        /// <br/>required field
        /// <br/>main topic for generating content;
        /// <br/>can contain from 1 to 50 tokens
        /// </summary>
        [JsonProperty("topic", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// number of words in content
        /// <br/>required field
        /// <br/>the number of tokens in the generated text;
        /// <br/>can take values from 1 to 1000
        /// </summary>
        [JsonProperty("word_count", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? WordCount { get; set; }

        /// <summary>
        /// secondary topics of the content to generate
        /// <br/>optional field
        /// <br/>secondary topics for generating content;
        /// <br/>can contain up to 10 terms;
        /// <br/>example: 'sub_topics': ['Apple','Pixar','Amazing Products']
        /// </summary>
        [JsonProperty("sub_topics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> SubTopics { get; set; }

        /// <summary>
        /// meta description of the content to generate
        /// <br/>optional field
        /// <br/>can contain from 1 to 1000 tokens
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// keywords for the content to generate
        /// <br/>optional field
        /// <br/>can contain up to 10 terms;
        /// <br/>learn more about this parameter on our help center
        /// <br/>example: 'meta_keywords': ['iPhone','sell','CEO']
        /// </summary>
        [JsonProperty("meta_keywords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> MetaKeywords { get; set; }

        /// <summary>
        /// creativity of content generation
        /// <br/>optional field
        /// <br/>the randomness of the selection of equally probable subsequent tokens;
        /// <br/>can take values from 0 to 1
        /// <br/>default value: 0.8
        /// <br/>learn more about this parameter on our help center
        /// </summary>
        [JsonProperty("creativity_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CreativityIndex { get; set; }

        /// <summary>
        /// include conclusion in generated text
        /// <br/>optional field
        /// <br/>if set to true, generated content will include a logical conclusion
        /// </summary>
        [JsonProperty("include_conclusion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeConclusion { get; set; }

        /// <summary>
        /// token for generating subsequent results
        /// <br/>optional field
        /// <br/>provided in the identical filed of the response to each request;
        /// <br/>you can use this parameter to continue the generation of text from the initial response
        /// <br/>supplement_token values are unique for each subsequent task
        /// </summary>
        [JsonProperty("supplement_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SupplementToken { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}