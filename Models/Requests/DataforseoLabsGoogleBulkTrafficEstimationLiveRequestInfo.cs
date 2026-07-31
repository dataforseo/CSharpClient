using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo 
    {

        /// <summary>
        /// target domains, subdomains, and webpages
        /// <br/>required field
        /// <br/>you can specify domains, subdomains, and webpages in this field;
        /// <br/>domains and subdomains should be specified without <c>https://</c> and <c>www.</c>;
        /// <br/>pages should be specified with absolute URL, including <c>https://</c> and <c>www.</c>;
        /// <br/>you can set up to 1000 domains, subdomains or webpages
        /// </summary>
        [JsonProperty("targets", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Targets { get; set; }

        /// <summary>
        /// full name of the location
        /// <br/>if you use this field, you don't have to specify <c>location_code</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available locations
        /// <br/>example:
        /// <br/><c>United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location code
        /// <br/>if you use this field, you don't have to specify <c>location_name</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available locations
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// full name of the language
        /// <br/>if you use this field, you don’t need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language code
        /// <br/>if you use this field, you don’t need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> by making a separate request to the 
        /// <br/><c>https://api.dataforseo.com/v3/dataforseo_labs/locations_and_languages</c>
        /// <br/>ignore this field to get the results for all available languages
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// display results by item type
        /// <br/>optional field
        /// <br/>indicates the type of search results included in the response
        /// <br/>Note: if the <c>item_types</c> array contains item types that are different from <c>organic</c>, the results will be ordered by the first item type in the array
        /// <br/>possible values: 
        /// <br/><c>['organic', 'paid', 'featured_snippet', 'local_pack']</c>
        /// <br/>default value: 
        /// <br/><c>['organic', 'paid']</c>
        /// </summary>
        [JsonProperty("item_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> ItemTypes { get; set; }

        /// <summary>
        /// ignore highly similar keywords
        /// <br/>optional field
        /// <br/>if set to_<c>true</c>, only core keywords will be returned, all highly similar keywords will be excluded;  
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("ignore_synonyms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSynonyms { get; set; }

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