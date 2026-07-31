using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleSearchIntentLiveRequestInfo 
    {

        /// <summary>
        /// target keywords
        /// <br/>required field
        /// <br/>UTF-8 encoding
        /// <br/>maximum number of keywords you can specify in this array: 1000;
        /// <br/>the keywords will be converted to lowercase format
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keywords", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Keywords { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if don't specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>Note: this endpoint currently supports the following languages only:
        /// <br/><c>Arabic</c>, <c>ar</c>,
        /// <br/><c>Chinese(Traditional)</c>, <c>zh-TW</c>,
        /// <br/><c>Czech</c>, <c>cs</c>,
        /// <br/><c>Danish</c>, <c>da</c>,
        /// <br/><c>Dutch</c>, <c>nl</c>,
        /// <br/><c>English</c>, <c>en</c>,
        /// <br/><c>Finnish</c>, <c>fi</c>,
        /// <br/><c>French</c>, <c>fr</c>,
        /// <br/><c>German</c>, <c>de</c>,
        /// <br/><c>Hebrew</c>, <c>he</c>,
        /// <br/><c>Hindi</c>, <c>hi</c>,
        /// <br/><c>Italian</c>, <c>it</c>,
        /// <br/><c>Japanese</c>, <c>ja</c>,
        /// <br/><c>Korean</c>, <c>ko</c>,
        /// <br/><c>Malay</c>, <c>ms</c>,
        /// <br/><c>Norwegian(Bokmål)</c>, <c>nb</c>,
        /// <br/><c>Polish</c>, <c>pl</c>,
        /// <br/><c>Portuguese</c>, <c>pt</c>,
        /// <br/><c>Romanian</c>, <c>ro</c>,
        /// <br/><c>Russian</c>, <c>ru</c>,
        /// <br/><c>Spanish</c>, <c>es</c>,
        /// <br/><c>Swedish</c>, <c>sv</c>,
        /// <br/><c>Thai</c>, <c>th</c>,
        /// <br/><c>Ukrainian</c>, <c>uk</c>,
        /// <br/><c>Vietnamese</c>, <c>vi</c>,
        /// <br/><c>Bulgarian</c>, <c>bg</c>,
        /// <br/><c>Croatian</c>, <c>hr</c>,
        /// <br/><c>Serbian</c>, <c>sr</c>,
        /// <br/><c>Slovenian</c>, <c>sl</c>,
        /// <br/><c>Bosnian</c>, <c>bs</c>,
        /// <br/><c>Greek</c>, <c>el</c>,
        /// <br/><c>Hungarian</c>, <c>hu</c>,
        /// <br/><c>Slovak</c>, <c>sk</c>,
        /// <br/><c>Turkish</c>, <c>tr</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if don't specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>Note: this endpoint currently supports <see href="#lng">these languages only;</see>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}