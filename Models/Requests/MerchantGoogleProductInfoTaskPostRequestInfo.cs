using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class MerchantGoogleProductInfoTaskPostRequestInfo 
    {

        /// <summary>
        /// unique product identifier on Google Shopping
        /// <br/>required field if <c>data_docid</c> or <c>gid</c> is not specified
        /// <br/>we recommend specifying <c>product_id</c> together with <c>data_docid</c> and <c>gid</c> for optimal results;
        /// <br/>you can get this value for a certain product by making a separate request to <see href="/v3/merchant/google/products/task_post">the Google Shopping Products endpoint</see>
        /// <br/>example:
        /// <br/><c>4485466949985702538</c>
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/product-id-google-shopping">this help center guide</see>
        /// </summary>
        [JsonProperty("product_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// unique identifier of the SERP data element
        /// <br/>required field if <c>product_id</c> or <c>gid</c> is not specified
        /// <br/>we recommend specifying <c>data_docid</c> together with <c>product_id</c> and <c>gid</c> for optimal results;
        /// <br/>you can get this value for a certain element by making a separate request to <see href="/v3/merchant/google/products/task_post">the Google Shopping Products endpoint</see>
        /// <br/>example:
        /// <br/><c>13071766526042404278</c>
        /// </summary>
        [JsonProperty("data_docid", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DataDocid { get; set; }

        /// <summary>
        /// global product identifier on Google Shopping
        /// <br/>required field if <c>product_id</c> or <c>data_docid</c> is not specified
        /// <br/>we recommend specifying <c>gid</c> together with <c>product_id</c> and <c>data_docid</c> for optimal results;
        /// <br/>you can get this value for a certain product by making a separate request to <see href="/v3/merchant/google/products/task_post">the Google Shopping Products endpoint</see>
        /// <br/>example:
        /// <br/><c>4702526954592161872</c>
        /// <br/>learn more about the parameter in <see href="https://dataforseo.com/help-center/whats-a-gid-in-google-shopping-api">this help center guide</see>
        /// </summary>
        [JsonProperty("gid", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Gid { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priorityYou will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/merchant/google-shopping-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available Google Shopping locations with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/google/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don't specify <c>location_name</c>_or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available Google Shopping locations with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/google/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don't specify <c>location_name</c>_or <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude,radius' format
        /// <br/>the maximum number of decimal digits for 'latitude' and 'longitude': 7
        /// <br/>the minimum value for 'radius': 199.9
        /// <br/>example:
        /// <br/><c>53.476225,-2.243572,200</c>
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available Google Shopping languages with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/google/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available Google Shopping languages with their <c>language_code</c>_by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/google/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search engine domain
        /// <br/>optional field
        /// <br/>we choose the relevant search engine domain automatically according to the location and language you specify
        /// <br/>however, you can set a custom search engine domain in this field
        /// <br/>example:
        /// <br/><c>google.co.uk</c>, <c>google.com.au</c>, <c>google.de</c>, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

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
        /// URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the <c>gzip</c> format to the <c>postback_url</c> you specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
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
        /// <br/>optional field
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible values:
        /// <br/><c>advanced</c>
        /// </summary>
        [JsonProperty("postback_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

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

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}