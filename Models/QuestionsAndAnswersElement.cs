using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class QuestionsAndAnswersElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// source URL
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// question included in the item
        /// </summary>
        [JsonProperty("question_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionText { get; set; }

        /// <summary>
        /// answer included in the item
        /// </summary>
        [JsonProperty("answer_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AnswerText { get; set; }

        /// <summary>
        /// reference source name or title
        /// </summary>
        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// domain where a link points
        /// </summary>
        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// answer upvotes from the source
        /// </summary>
        [JsonProperty("votes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Votes { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}