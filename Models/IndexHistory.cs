using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class IndexHistory 
    {

        /// <summary>
        /// date for which index volume data is provided
        /// <br/>in the UTC format: “yyyy-mm-dd”
        /// <br/>example:
        /// <br/>2021-10-01
        /// </summary>
        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// total number of backlinks our database contained on the given date
        /// </summary>
        [JsonProperty("total_backlinks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalBacklinks { get; set; }

        /// <summary>
        /// total number of pages our database contained on the given date
        /// </summary>
        [JsonProperty("total_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPages { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}