using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixReviewsDayStatisticsMoneyData 
    {
        [JsonProperty("task_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TaskPost { get; set; }
        [JsonProperty("refund_money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RefundMoney { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}