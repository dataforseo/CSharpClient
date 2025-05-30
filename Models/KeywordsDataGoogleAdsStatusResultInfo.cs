using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class KeywordsDataGoogleAdsStatusResultInfo 
    {

        /// <summary>
        /// indicates whether Google updated keyword data for the previous month
        /// <br/>generally, Google updates keyword data in the middle of the month
        /// <br/>if the value is true, Google currently provides up-to-date data for the previous month
        /// <br/>if the value is false, we are not able to provide data for the previous month
        /// </summary>
        [JsonProperty("actual_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActualData { get; set; }

        /// <summary>
        /// date of the latest update of Google Ads data
        /// <br/>indicates the latest date when Google updated search volume, CPC, and other keyword metrics
        /// <br/>example:
        /// <br/>2020-05-15
        /// </summary>
        [JsonProperty("date_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateUpdate { get; set; }

        /// <summary>
        /// the latest year for which search volume data is available
        /// </summary>
        [JsonProperty("last_year_in_monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LastYearInMonthlySearches { get; set; }

        /// <summary>
        /// the latest month for which search volume data is available
        /// </summary>
        [JsonProperty("last_month_in_monthly_searches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? LastMonthInMonthlySearches { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}