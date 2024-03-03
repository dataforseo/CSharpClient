namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationCheckGrammarLiveItem
    {
        /// <summary>
        /// message of the grammar or spelling error
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// description of the grammar or spelling error
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// suggested corrections
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suggestions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Suggestions { get; set; }

        /// <summary>
        /// offset token for subsequent requests
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// offset token for subsequent requests
        /// </summary>
        [Newtonsoft.Json.JsonProperty("length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Length { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// id of the grammar or spelling rule
        /// <br/>see the List of Grammar Rules for Content Generation API
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// description of the grammar or spelling rule
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// type of the issue found by the relevant rule
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_issue_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RuleIssueType { get; set; }

        /// <summary>
        /// id of the rule category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_category_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RuleCategoryId { get; set; }

        /// <summary>
        /// name of the rule category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_category_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RuleCategoryName { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}