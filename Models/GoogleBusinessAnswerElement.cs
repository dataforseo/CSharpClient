namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GoogleBusinessAnswerElement
    {
        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// ID of the answer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AnswerId { get; set; }

        /// <summary>
        /// URL of the user’s profile image
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profile_image_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// URL of the user’s profile
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profile_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// displayed name of the user
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profile_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileName { get; set; }

        /// <summary>
        /// current text of the answer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AnswerText { get; set; }

        /// <summary>
        /// original text of the answer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_answer_text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginalAnswerText { get; set; }

        /// <summary>
        /// estimated time when the answer was posted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_ago", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// exact time when the answer was posted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}