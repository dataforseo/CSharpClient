using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsGoogleSearchIntentLiveRequestInfo
    {
        /// <summary>
        /// target keywords
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>maximum number of keywords you can specify in this array: 1000;
        /// <br/>the keywords will be converted to lowercase format
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Keywords { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if don’t specify language_code
        /// <br/>you can receive the list of available languages with their language_name by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>
        /// <br/>Note: this endpoint currently supports the following languages only:
        /// <br/>Arabic, ar,
        /// <br/>Chinese(Traditional), zh-TW,
        /// <br/>Czech, cs,
        /// <br/>Danish, da,
        /// <br/>Dutch, nl,
        /// <br/>English, en,
        /// <br/>Finnish, fi,
        /// <br/>French, fr,
        /// <br/>German, de,
        /// <br/>Hebrew, he,
        /// <br/>Hindi, hi,
        /// <br/>Italian, it,
        /// <br/>Japanese, ja,
        /// <br/>Korean, ko,
        /// <br/>Malay, ms,
        /// <br/>Norwegian(Bokmål), nb,
        /// <br/>Polish, pl,
        /// <br/>Portuguese, pt,
        /// <br/>Romanian, ro,
        /// <br/>Russian, ru,
        /// <br/>Spanish, es,
        /// <br/>Swedish, sv,
        /// <br/>Thai, th,
        /// <br/>Ukrainian, uk,
        /// <br/>Vietnamese, vi,
        /// <br/>Bulgarian, bg,
        /// <br/>Croatian, hr,
        /// <br/>Serbian, sr,
        /// <br/>Slovenian, sl,
        /// <br/>Bosnian, bs
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if don’t specify language_name
        /// <br/>you can receive the list of available languages with their language_code by making a separate request to https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>Note: this endpoint currently supports these languages only;
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

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