using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class MerchantAmazonSellersLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// unique product identifier on Amazonrequired fieldyou can get this value making a separate request to the Amazon Products endpointnote that there is no full list of possible values as the asin values is a dynamic value assigned by Amazonexample:B085RFFC9Qlearn more about the identifier in this help center guide
        /// </summary>
        [JsonProperty("asin", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Asin { get; set; }

        /// <summary>
        /// full name of the locationrequired field if you don't specify location_code or location_coordinateif you use this field, you don't need to specify location_code or location_coordinateyou can receive the list of available Amazon locations with their location_name by making a separate request to the https://api.dataforseo.com/v3/merchant/amazon/locationsexample:London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// location coderequired field if you don't specify location_name or location_coordinateif you use this field, you don't need to specify location_name or location_coordinateyou can receive the list of available Amazon locations with their location_code by making a separate request to the https://api.dataforseo.com/v3/merchant/amazon/locationsexample:2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a locationrequired field if you don't specify location_name or location_codeif you use this field, you don't need to specify location_name or location_codelocation_coordinate parameter should be specified in the 'latitude,longitude,radius' formatthe maximum number of decimal digits for 'latitude' and 'longitude': 7the minimum value for 'radius': 199.9example:53.476225,-2.243572,200
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of the languagerequired field if you don't specify language_codeif you use this field, you don't need to specify language_codeyou can receive the list of available Amazon languages with their language_name by making a separate request to the https://api.dataforseo.com/v3/merchant/amazon/languagesexample:English (United States)
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// language coderequired field if you don't specify language_nameif you use this field, you don't need to specify language_nameyou can receive the list of available Amazon languages with their language_code by making a separate request to the https://api.dataforseo.com/v3/merchant/amazon/languagesexample:en_US
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search engine domainoptional fieldwe choose the relevant search engine domain automatically according to the location and language you specifyhowever, you can set a custom search engine domain in this fieldexample:amazon.co.uk, amazon.com.au, amazon.de, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response
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