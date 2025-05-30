using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class SearchVolumeHistorySearchInfo 
    {

        /// <summary>
        /// device type = desktop
        /// <br/>contains historical search volume data for searches made from desktop devices
        /// </summary>
        [JsonProperty("desktop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SearchVolumeHistoryItemInfo> Desktop { get; set; }

        /// <summary>
        /// device type = non-smartphones
        /// <br/>contains historical search volume data for searches made from feature phones (non-smartphone mobile devices)
        /// </summary>
        [JsonProperty("non_smartphones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SearchVolumeHistoryItemInfo> NonSmartphones { get; set; }

        /// <summary>
        /// device type = mobile
        /// <br/>contains historical search volume data for searches made from mobile devices
        /// </summary>
        [JsonProperty("mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SearchVolumeHistoryItemInfo> Mobile { get; set; }

        /// <summary>
        /// device type = tablet
        /// <br/>contains historical search volume data for searches made from tablets
        /// </summary>
        [JsonProperty("tablet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SearchVolumeHistoryItemInfo> Tablet { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}