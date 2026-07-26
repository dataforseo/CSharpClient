using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleDatasetSearchLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your <c>keyword</c>, please specify it as “%2B”;
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>possible value:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value: <c>20</c>
        /// <br/>max value: <c>200</c>
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
        /// <br/>possible value: <c>desktop</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>possible value:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>choose from the following values: <c>windows</c>, <c>macos</c>
        /// <br/>default value: <c>windows</c>
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// last time the dataset was updated
        /// <br/>optional field
        /// <br/>possible values: <c>1m</c>, <c>1y</c>, <c>3y</c>
        /// </summary>
        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// file formats of the dataset
        /// <br/>optional field
        /// <br/>possible values: <c>other</c>, <c>archive</c>, <c>text</c>, <c>image</c>, <c>document</c>, <c>tabular</c>
        /// </summary>
        [JsonProperty("file_formats", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> FileFormats { get; set; }

        /// <summary>
        /// usage rights of the dataset
        /// <br/>optional field
        /// <br/>possible values: <c>commercial</c>, <c>noncommercial</c>
        /// </summary>
        [JsonProperty("usage_rights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UsageRights { get; set; }

        /// <summary>
        /// indicates whether displayed datasets are free
        /// <br/>optional field
        /// <br/>possible values: <c>true</c>, <c>false</c>
        /// </summary>
        [JsonProperty("is_free", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        /// <summary>
        /// dataset topics
        /// <br/>optional field
        /// <br/>possible values: <c>humanities</c>, <c>social_sciences</c>, <c>life_sciences</c>, <c>agriculture</c>, <c>natural_sciences</c>, <c>geo</c>, <c>computer</c>, <c>architecture_and_urban_planning</c>, <c>engineering</c>
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