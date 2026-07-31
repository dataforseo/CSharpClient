using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleAvailableHistoryResultInfo 
    {

        /// <summary>
        /// available date
        /// <br/>indicates the date of the range available for setting in the <see href="/v3/dataforseo_labs/google/domain_metrics_by_categories/live/">Domain Metrics by Categories</see> endpoint
        /// <br/>example:
        /// <br/><c>2022-05-16</c>
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}