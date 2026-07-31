using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PeriodCovered 
    {

        /// <summary>
        /// date and time when the period starts
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2020-03-02 02:00:00 +00:00</c>
        /// </summary>
        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// date and time when the period ends
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/><c>2022-12-09 02:00:00 +00:00</c>
        /// </summary>
        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// period displayed in SERP
        /// <br/>example:
        /// <br/><c>Mar 2, 2020 - Dec 9, 2022</c>
        /// </summary>
        [JsonProperty("displayed_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayedDate { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}