using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationGenerateSubTopicsLiveRequestInfo
    {
        /// <summary>
        /// main topic of the content to generate
        /// <br/>required field
        /// <br/>main topic for content generation;
        /// <br/>can contain from 1 to 50 tokens
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Topic { get; set; }

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