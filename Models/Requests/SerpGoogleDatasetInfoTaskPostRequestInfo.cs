using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleDatasetInfoTaskPostRequestInfo 
    {

        /// <summary>
        /// ID of the dataset
        /// <br/>required field
        /// <br/>you can find dataset ID in the dataset URL or <c>dataset</c> item of <see href="https://docs.dataforseo.com/v3/serp/google/dataset_search/live/advanced">Google Dataset Search</see> result
        /// <br/>example:
        /// <br/><c>L2cvMTFqbl85ZHN6MQ==</c>
        /// </summary>
        [JsonProperty("dataset_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetId { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>possible value:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priority
        /// <br/>You will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/google-dataset-info-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>return results for a specific device type
        /// <br/>possible value: <c>desktop</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/><c>http://your-server.com/pingscript?id=$id</c>
        /// <br/><c>http://your-server.com/pingscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special characters in <c>pingback_url</c> will be urlencoded;
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("pingback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

        /// <summary>
        /// URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the <c>gzip</c> format to the <c>postback_url</c> you specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request
        /// <br/>example:
        /// <br/><c>http://your-server.com/postbackscript?id=$id</c>
        /// <br/><c>http://your-server.com/postbackscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special characters in <c>postback_url</c> will be urlencoded;
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("postback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// postback_url datatype
        /// <br/>required field if you specify <c>postback_url</c>
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible value: <c>advanced</c>
        /// </summary>
        [JsonProperty("postback_data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

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

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}