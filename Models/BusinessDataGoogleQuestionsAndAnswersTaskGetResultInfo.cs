using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataGoogleQuestionsAndAnswersTaskGetResultInfo 
    {

        /// <summary>
        /// keyword received in a POST array
        /// <br/>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character)
        /// <br/>this field will contain the cid parameter if you specified it in the keyword field when setting a task;
        /// <br/>example:
        /// <br/>cid:2946633002421908862
        /// <br/>learn more about the parameter in this help center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine domain as specified in a POST array
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the result was received
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// google-defined client id
        /// <br/>unique id of a local establishment;
        /// <br/>learn more about the identifier in this help center article
        /// </summary>
        [JsonProperty("cid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Cid { get; set; }

        /// <summary>
        /// unique identifier of the SERP feature
        /// </summary>
        [JsonProperty("feature_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureId { get; set; }

        /// <summary>
        /// item types
        /// <br/>types of search engine results encountered in the items array;
        /// <br/>possible item types: google_business_question_item
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// array of google business question items without answers
        /// </summary>
        [JsonProperty("items_without_answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleBusinessQuestionItem> ItemsWithoutAnswers { get; set; }

        /// <summary>
        /// the number of items in the items array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// array of items within google_business_question_item
        /// <br/>contains answers to the google business questions;
        /// <br/>the maximum number of answers returned for each question: 5
        /// <br/>possible item types google_business_answer_element
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GoogleBusinessQuestionItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}