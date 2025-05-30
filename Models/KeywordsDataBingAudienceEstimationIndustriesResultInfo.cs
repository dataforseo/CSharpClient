using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataBingAudienceEstimationIndustriesResultInfo 
    {

        /// <summary>
        /// ID of the industry
        /// </summary>
        [JsonProperty("industry_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? IndustryId { get; set; }

        /// <summary>
        /// name of the industry
        /// </summary>
        [JsonProperty("industry_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IndustryName { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}