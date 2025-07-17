using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class TopicListDataItemInfo 
    {

        /// <summary>
        /// unique topic identifier in Google Trends
        /// </summary>
        [JsonProperty("topic_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TopicId { get; set; }

        /// <summary>
        /// title of the topic
        /// </summary>
        [JsonProperty("topic_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TopicTitle { get; set; }

        /// <summary>
        /// type of the topic
        /// <br/>represents the general type of the topic
        /// </summary>
        [JsonProperty("topic_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TopicType { get; set; }

        /// <summary>
        /// search term popularity
        /// <br/>represents the popularity of the topic. Scoring is on a relative scale where a value of 100 is the most commonly searched topic and a value of 50 is a topic searched half as often as the most popular term, and so on.
        /// </summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}