using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo
    {
        /// <summary>
        /// domain
        /// <br/>required field
        /// <br/>the domain name of the target website
        /// <br/>the domain should be specified without https:// and www.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>required field if you don’t specify location_code
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>United Kingdom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>required field if you don’t specify location_name
        /// <br/>Note: it is required to specify either location_name or location_code
        /// <br/>you can receive the list of available locations with their location_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>required field if you don’t specify language_code
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available locations with their language_name by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>Note: it is required to specify either language_name or language_code
        /// <br/>you can receive the list of available locations with their language_code by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages
        /// <br/>example:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the data will be provided for the previous 6 months
        /// <br/>minimal possible value: 2020-10-01
        /// <br/>date format: "yyyy-mm-dd"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the today’s date will be used by default
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2021-04-01"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// correlate data with previously obtained datasets
        /// <br/>optional field
        /// <br/>default value: true
        /// <br/>if you use this parameter, our system will correlate data you obtain now with previously obtained datasets
        /// <br/>this parameter is intended to mitigate any inconsistencies that may result from changes to our database
        /// <br/>we recommend always setting correlate to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("correlate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Correlate { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to true, only data based on core keywords will be returned, data for all highly similar keywords will be excluded;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ignore_synonyms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

        /// <summary>
        /// include or exclude data from clickstream-based metrics in the result
        /// <br/>optional field
        /// <br/>if the parameter is set to true, you will receive clickstream_etv, clickstream_gender_distribution, and clickstream_age_distribution fields with clickstream data in the response;
        /// <br/>default value: false;
        /// <br/>Note: historical clickstream data is available from 2024/05 (May, 2024);
        /// <br/>with this parameter enabled, you will be charged double the price for the request;
        /// <br/>learn more about how clickstream-based metrics are calculated in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_clickstream_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeClickstreamData { get; set; }

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