using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataBingKeywordsForKeywordsTasksReadyResultInfo
    {
        /// <summary>
        /// task identifier of the completed task
        /// <br/>unique task identifier in our system in the UUID format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// search engine specified when setting the task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Se { get; set; }

        /// <summary>
        /// type of the task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("function", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Function { get; set; }

        /// <summary>
        /// date when the task was posted (in the UTC format)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_posted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatePosted { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// URL for collecting the results of the task
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endpoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

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