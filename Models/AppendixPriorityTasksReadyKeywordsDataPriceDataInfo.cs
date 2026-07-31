using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppendixPriorityTasksReadyKeywordsDataPriceDataInfo 
    {

        /// <summary>
        /// charge type
        /// <br/>can take the following values:
        /// <br/><c>per_result</c>_- charge for every row in the <c>result</c> array
        /// <br/><c>per_request</c>_- charge for a GET or POST requestn
        /// </summary>
        [JsonProperty("cost_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CostType { get; set; }

        /// <summary>
        /// cost, USD
        /// </summary>
        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}