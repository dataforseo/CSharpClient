using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksTimeseriesNewLostSummaryLiveRequestInfo
    {
        /// <summary>
        /// domain to get data for
        /// <br/>required field
        /// <br/>a domain should be specified without https:// and www.
        /// <br/>example:
        /// <br/>"forbes.com"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>this field indicates the date which will be used as a threshold for new and lost backlinks and referring domains;
        /// <br/>the backlinks and referring domains that appeared in our index after the specified date will be considered as new;
        /// <br/>the backlinks and referring domains that weren’t found after the specified date, but were present before, will be considered as lost;
        /// <br/>minimum value: 2019-01-30
        /// <br/>maximum value shouldn’t exceed the date specified in the date_to
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2021-01-01"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the today’s date will be used by default
        /// <br/>minimum value shouldn’t preceed the date specified in the date_from
        /// <br/>maximum value: today’s date
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2021-01-15"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// time range which will be used to group the results
        /// <br/>optional field
        /// <br/>default value: month
        /// <br/>possible values: day, week, month, year
        /// <br/>note: for day, we will return items corresponding to all dates between and including date_from and date_to;
        /// <br/>for week/month/year, we will return items corresponding to full weeks/months/years, where each item will indicate the last day of the week/month/year
        /// <br/>for example, if you specify:
        /// <br/>"group_range": "month",
        /// <br/>"date_from": "2022-03-23",
        /// <br/>"date_to": "2022-05-13"
        /// <br/>we will return items falling between 2022-03-01 and 2022-05-31, namely, three items corresponding to the following dates: 2022-03-31, 2022-04-30, 2022-05-31
        /// <br/>if there is no data for a certain  day/week/month/year, we will return 0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_range", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupRange { get; set; }

        /// <summary>
        /// indicates if the subdomains of the target will be included in the search
        /// <br/>optional field
        /// <br/>if set to false, the subdomains will be ignored
        /// <br/>default value: true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_subdomains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

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