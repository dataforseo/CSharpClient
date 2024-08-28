using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpGoogleDatasetSearchLiveAdvancedRequestInfo
    {
        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 symbols in the keyword field
        /// <br/>all %## will be decoded (plus symbol ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” symbol for your keyword, please specify it as “%25”;
        /// <br/>if you need to use the “+” symbol for your keyword, please specify it as “%2B”;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>possible value:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field if you don’t specify language_name
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>possible value:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>possible value: desktop
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>choose from the following values: windows, macos
        /// <br/>default value: windows
        /// </summary>
        [Newtonsoft.Json.JsonProperty("os", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value: 20
        /// <br/>max value: 700
        /// <br/>Note: your account will be billed per each SERP containing up to 20 results;
        /// <br/>thus, setting a depth above 20 may result in additional charges if the search engine returns more than 20 results;
        /// <br/>if the specified depth is higher than the number of results in the response, the difference will be refunded automatically to your account balance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// last time the dataset was updated
        /// <br/>optional field
        /// <br/>possible values: 1m, 1y, 3y
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_updated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// file formats of the dataset
        /// <br/>optional field
        /// <br/>possible values: other, archive, text, image, document, tabular
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_formats", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> FileFormats { get; set; }

        /// <summary>
        /// usage rights of the dataset
        /// <br/>optional field
        /// <br/>possible values: commercial, noncommercial
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usage_rights", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UsageRights { get; set; }

        /// <summary>
        /// indicates whether displayed datasets are free
        /// <br/>optional field
        /// <br/>possible values: true, false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_free", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        /// <summary>
        /// dataset topics
        /// <br/>optional field
        /// <br/>possible values: humanities, social_sciences, life_sciences, agriculture, natural_sciences, geo, computer, architecture_and_urban_planning, engineering
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Topics { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

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