using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleQuestionsAndAnswersTaskGetResultInfo
    {
        /// <summary>
        /// keyword received in a POST array
        /// <br/>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character)
        /// <br/>this field will contain the cid parameter if you specified it in the keyword field when setting a task;
        /// <br/>example:
        /// <br/>cid:2946633002421908862
        /// <br/>learn more about the parameter in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine domain as specified in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when the result was received
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Datetime { get; set; }

        /// <summary>
        /// google-defined client id
        /// <br/>unique id of a local establishment;
        /// <br/>learn more about the identifier in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cid { get; set; }

        /// <summary>
        /// unique identifier of the SERP feature
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feature_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FeatureId { get; set; }

        /// <summary>
        /// item types
        /// <br/>types of search engine results encountered in the items array;
        /// <br/>possible item types: google_business_question_item
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ItemTypes { get; set; }

        /// <summary>
        /// array of google business question items without answers
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items_without_answers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ItemsWithoutAnswers> ItemsWithoutAnswers { get; set; }

        /// <summary>
        /// the number of items in the items array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ItemsCount { get; set; }

        /// <summary>
        /// array of items within google_business_question_item
        /// <br/>contains answers to the google business questions;
        /// <br/>the maximum number of answers returned for each question: 5
        /// <br/>possible item types google_business_answer_element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BusinessDataGoogleQuestionsAndAnswersItem> Items { get; set; }

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