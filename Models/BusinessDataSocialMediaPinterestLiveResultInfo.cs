using Newtonsoft.Json;
using System;
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
        /// <br/>corresponding URL you specified in the <c>targets</c> array when setting a task
        /// </summary>
        [JsonProperty("page_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageUrl { get; set; }

        /// <summary>
        /// number of pins for the related <c>page_url</c>
        /// <br/><see href="https://help.pinterest.com/en/business/article/build-a-pin">pins on Pinterest</see> correspond to content saves;
        /// <br/>this field shows the number of content saves made from the related <c>page_url</c> using the <see href="https://developers.pinterest.com/docs/widgets/save/?">Pinterest Save Button</see>
        /// </summary>
        [JsonProperty("pins_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? PinsCount { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}