using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class DataforseoLabsGoogleCategoriesForDomainLiveItem 
    {

        /// <summary>
        /// search engine type
        /// </summary>
        [JsonProperty("se_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// product and service categories
        /// <br/>you can download <see href="https://cdn.dataforseo.com/v3/categories/categories_dataforseo_labs_2023_10_25.csv">the full list of possible categories</see>
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<int?> Categories { get; set; }

        /// <summary>
        /// ranking data relevant to the specified domain or subdomain
        /// </summary>
        [JsonProperty("metrics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, DataforseoLabsMetricsInfo> Metrics { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}