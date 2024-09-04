using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleAdsStatusResultInfo
    {
        /// <summary>
        /// indicates whether Google updated keyword data for the previous month
        /// <br/>generally, Google updates keyword data in the middle of the month
        /// <br/>if the value is true, Google currently provides up-to-date data for the previous month
        /// <br/>if the value is false, we are not able to provide data for the previous month
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actual_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ActualData { get; set; }

        /// <summary>
        /// date of the latest update of Google Ads data
        /// <br/>indicates the latest date when Google updated search volume, CPC, and other keyword metrics
        /// <br/>example:
        /// <br/>2020-05-15
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_update", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateUpdate { get; set; }

        /// <summary>
        /// the latest year for which search volume data is available
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_year_in_monthly_searches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LastYearInMonthlySearches { get; set; }

        /// <summary>
        /// the latest month for which search volume data is available
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_month_in_monthly_searches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LastMonthInMonthlySearches { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}