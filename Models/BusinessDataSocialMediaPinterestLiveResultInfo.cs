using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class BusinessDataSocialMediaPinterestLiveResultInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// URL of the page the data is provided for
        /// <br/>corresponding URL you specified in the targets array when setting a task
        /// </summary>
        [JsonProperty("page_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageUrl { get; set; }

        /// <summary>
        /// number of pins for the related page_url
        /// <br/>pins on Pinterest correspond to content saves;
        /// <br/>this field shows the number of content saves made from the related page_url using the Pinterest Save Button
        /// </summary>
        [JsonProperty("pins_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PinsCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}