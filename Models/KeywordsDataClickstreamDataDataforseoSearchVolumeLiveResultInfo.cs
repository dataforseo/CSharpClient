using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResultInfo 
    {

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// <br/>
        /// <br/>Note:if the keyword in the POST array appears to be misspelled, data will be returned for the correctly spelled keyword;
        /// <br/>we use the functionality of Google Ads API to check and validate the spelling of keywords, learn more by this link
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// indicates if the use_clickstream parameter is active
        /// <br/>possible values: true, false
        /// </summary>
        [JsonProperty("use_clickstream", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseClickstream { get; set; }

        /// <summary>
        /// ithe number of results returned in the items array
        /// </summary>
        [JsonProperty("items_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ItemsCount { get; set; }

        /// <summary>
        /// array of keywords
        /// <br/>contains keywords and their search volume rates
        /// </summary>
        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<KeywordsDataClickstreamDataSearchVolumeLiveItem> Items { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}