using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class MerchantAmazonAsinLiveHtmlRequestInfo 
    {

        /// <summary>
        /// product ID
        /// <br/>required field
        /// <br/><see href="https://dataforseo.com/help-center/asin-in-amazon-api">unique product identifier (ASIN)</see> in Amazon
        /// <br/>you can receive the <c>asin</c> parameter by making a separate request to the <see href="/v3/merchant/amazon/products/products/live/advanced/">Amazon Products endpoint</see>
        /// </summary>
        [JsonProperty("asin", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Asin { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> parameters by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/amazon/locations</c>
        /// <br/>example:
        /// <br/><c>HA1,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> parameters by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/merchant/amazon/locations</c>
        /// <br/>example:
        /// <br/><c>9045969</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_code</c>
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
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> parameters by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/merchant/amazon/languages</c>
        /// <br/>example:
        /// <br/><c>English (United Kingdom)</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> parameters by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/amazon/languages</c>
        /// <br/>example:
        /// <br/><c>en_GB</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search engine domain
        /// <br/>optional field
        /// <br/>we choose the relevant search engine domain automatically according to the location and language you specify
        /// <br/>however, you can set a custom search engine domain in this field
        /// <br/>example:
        /// <br/><c>amazon.com</c>, <c>amazon.co.uk</c>, <c>amazon.fr</c>, etc.
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

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}