using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AiOptimizationLLmMentionsKeywordElement  : BaseAiOptimizationLLmMentionsTargetElement 
    {

        /// <summary>
        /// target keyword
        /// <br/>required field if you don’t specify domain
        /// <br/>you can specify up to 2000 characters in the keyword field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your keyword, please specify it as “%2B”
        /// <br/>learn more about rules and limitations of keyword and keywords fields in
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// target keyword match type
        /// <br/>defines how the specified keyword is matched
        /// <br/>optional field
        /// <br/>possible values:
        /// <br/>word_match – full-text search for terms that match the specified seed keyword with additional words included before, after, or within the key phrase (e.g., search for “light” will return results with “light bulb”, “light switch”);
        /// <br/>partial_match – substring search that finds all instances containing the specified sequence of characters, even if it appears inside a longer word (e.g., search for “light” will return results with “lighting”, “highlight”);
        /// <br/>default value: word_match
        /// </summary>
        [JsonProperty("match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}