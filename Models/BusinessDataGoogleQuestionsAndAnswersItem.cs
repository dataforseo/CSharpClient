using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataGoogleQuestionsAndAnswersItem 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankGroup { get; set; }

        /// <summary>
        /// absolute rank among all the elements
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RankAbsolute { get; set; }

        /// <summary>
        /// ID of the question
        /// </summary>
        [JsonProperty("question_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionId { get; set; }

        /// <summary>
        /// URL of the question
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

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
        /// current text of the question
        /// </summary>
        [JsonProperty("question_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionText { get; set; }

        /// <summary>
        /// original text of the question
        /// </summary>
        [JsonProperty("original_question_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalQuestionText { get; set; }

        /// <summary>
        /// estimated time when the question was posted
        /// </summary>
        [JsonProperty("time_ago", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeAgo { get; set; }

        /// <summary>
        /// exact time when the question was posted
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// array of google business question items with answers
        /// <br/>possible item types: google_business_question_item
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleBusinessAnswerElement> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}