using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleDatasetSearchLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the keyword field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your keyword, please specify it as “%2B”;
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field if you don't specify language_name
        /// <br/>if you use this field, you don't need to specify language_name
        /// <br/>possible value:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value: 20
        /// <br/>max value: 700
        /// <br/>Your account will be billed per each SERP containing up to 20 results;
        /// <br/>Setting depth above 20 may result in additional charges if the search engine returns more than 20 results;
        /// <br/>If the specified depth is higher than the number of results in the response, the difference will be refunded to your account balance automatically.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>return results for a specific device type
        /// <br/>possible value: desktop
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify language_code
        /// <br/>possible value:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>choose from the following values: windows, macos
        /// <br/>default value: windows
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// last time the dataset was updated
        /// <br/>optional field
        /// <br/>possible values: 1m, 1y, 3y
        /// </summary>
        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// file formats of the dataset
        /// <br/>optional field
        /// <br/>possible values: other, archive, text, image, document, tabular
        /// </summary>
        [JsonProperty("file_formats", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> FileFormats { get; set; }

        /// <summary>
        /// usage rights of the dataset
        /// <br/>optional field
        /// <br/>possible values: commercial, noncommercial
        /// </summary>
        [JsonProperty("usage_rights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UsageRights { get; set; }

        /// <summary>
        /// indicates whether displayed datasets are free
        /// <br/>optional field
        /// <br/>possible values: true, false
        /// </summary>
        [JsonProperty("is_free", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        /// <summary>
        /// dataset topics
        /// <br/>optional field
        /// <br/>possible values: humanities, social_sciences, life_sciences, agriculture, natural_sciences, geo, computer, architecture_and_urban_planning, engineering
        /// </summary>
        [JsonProperty("topics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Topics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}