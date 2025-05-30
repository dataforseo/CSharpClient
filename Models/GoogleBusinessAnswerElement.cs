using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class GoogleBusinessAnswerElement 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// ID of the answer
        /// </summary>
        [JsonProperty("answer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AnswerId { get; set; }

        /// <summary>
        /// URL of the user’s profile image
        /// </summary>
        [JsonProperty("profile_image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// URL of the user’s profile
        /// </summary>
        [JsonProperty("profile_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// displayed name of the user
        /// </summary>
        [JsonProperty("profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileName { get; set; }

        /// <summary>
        /// current text of the answer
        /// </summary>
        [JsonProperty("answer_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AnswerText { get; set; }

        /// <summary>
        /// original text of the answer
        /// </summary>
        [JsonProperty("original_answer_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAnswerText { get; set; }

        /// <summary>
        /// estimated time when the answer was posted
        /// </summary>
        [JsonProperty("time_ago", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// exact time when the answer was posted
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}