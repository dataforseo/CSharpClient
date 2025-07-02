using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentGenerationCheckGrammarLiveItem 
    {

        /// <summary>
        /// message of the grammar or spelling error
        /// </summary>
        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// description of the grammar or spelling error
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// suggested corrections
        /// </summary>
        [JsonProperty("suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Suggestions { get; set; }

        /// <summary>
        /// offset token for subsequent requests
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// offset token for subsequent requests
        /// </summary>
        [JsonProperty("length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Length { get; set; }

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// id of the grammar or spelling rule
        /// <br/>see the List of Grammar Rules for Content Generation API
        /// </summary>
        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// description of the grammar or spelling rule
        /// </summary>
        [JsonProperty("rule_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// type of the issue found by the relevant rule
        /// </summary>
        [JsonProperty("rule_issue_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RuleIssueType { get; set; }

        /// <summary>
        /// id of the rule category
        /// </summary>
        [JsonProperty("rule_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RuleCategoryId { get; set; }

        /// <summary>
        /// name of the rule category
        /// </summary>
        [JsonProperty("rule_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RuleCategoryName { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}