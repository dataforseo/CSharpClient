using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppDataAppleAppListingsSearchLiveItem 
    {

        /// <summary>
        /// ID of the returned app
        /// </summary>
        [JsonProperty("app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// search engine domain in a POST array
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// location code in a POST array
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// direct URL to search engine results
        /// <br/>you can use it to make sure that we provided accurate results
        /// </summary>
        [JsonProperty("check_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// date and time when SERP data was last updated
        /// <br/>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”
        /// <br/>example:
        /// <br/>2023-05-23 10:16:19 +00:00
        /// </summary>
        [JsonProperty("time_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeUpdate { get; set; }

        /// <summary>
        /// detailed information about the app
        /// </summary>
        [JsonProperty("item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AppStoreInfoOrganic Item { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}