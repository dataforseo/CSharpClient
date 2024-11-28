using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResultInfo
    {
        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>
        /// <br/>Note:if the keyword in the POST array appears to be misspelled, data will be returned for the correctly spelled keyword;
        /// <br/>we use the functionality of Google Ads API to check and validate the spelling of keywords, learn more by this link
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// indicates if the use_clickstream parameter is active
        /// <br/>possible values: true, false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_clickstream", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UseClickstream { get; set; }

        /// <summary>
        /// ithe number of results returned in the items array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemsCount { get; set; }

        /// <summary>
        /// array of keywords
        /// <br/>contains keywords and their search volume rates
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<KeywordsDataClickstreamDataSearchVolumeLiveItem> Items { get; set; }

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