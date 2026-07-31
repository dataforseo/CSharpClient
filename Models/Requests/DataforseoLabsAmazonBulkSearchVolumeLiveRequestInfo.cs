using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo 
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
        /// full name of the location
        /// <br/>required field if don't specify <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports the following locations and languages only:
        /// <br/><c>Australia</c> - <c>2036</c>, <c>en</c>
        /// <br/><c>Austria</c> - <c>2040</c>, <c>de</c>
        /// <br/><c>Canada</c> - <c>2124</c>, <c>en</c>
        /// <br/><c>Egypt</c> - <c>2818</c>, <c>ar</c>
        /// <br/><c>France</c> - <c>2250</c>, <c>fr</c>
        /// <br/><c>Germany</c> - <c>2276</c>, <c>de</c>
        /// <br/><c>India</c> - <c>2356</c>, <c>en</c>
        /// <br/><c>Italy</c> - <c>2380</c>, <c>it</c>
        /// <br/><c>Mexico</c> - <c>2484</c>, <c>es</c>
        /// <br/><c>Netherlands</c> - <c>2528</c>, <c>nl</c>
        /// <br/><c>Saudi Arabia</c> - <c>2682</c>, <c>ar</c>
        /// <br/><c>Singapore</c> - <c>2702</c>, <c>en</c>
        /// <br/><c>Spain</c> - <c>2724</c>, <c>es</c>
        /// <br/><c>United Arab Emirates</c> - <c>2784</c>, <c>ar</c>
        /// <br/><c>United Kingdom</c> - <c>2826</c>, <c>en</c>
        /// <br/><c>United States</c> - <c>2840</c>, <c>en</c>
        /// <br/>example:
        /// <br/><c>United States</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if don't specify <c>location_name</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>;
        /// <br/>Note: this endpoint currently supports <see href="#loc">these locations and languages only;</see>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if don't specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>Note: this endpoint currently supports <see href="#loc">these locations and languages only;</see>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if don't specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>Note: this endpoint currently supports <see href="#loc">these locations and languages only;</see>
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