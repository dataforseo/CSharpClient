using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksTimeseriesSummaryLiveRequestInfo 
    {

        /// <summary>
        /// domain to get data for
        /// <br/>required field
        /// <br/>a domain should be specified without https:// and www.
        /// <br/>example:
        /// <br/>'forbes.com'
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>this field indicates the date which will be used as a threshold for summary data;
        /// <br/>minimum value: 2019-01-30
        /// <br/>maximum value shouldn’t exceed the date specified in the date_to
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2021-01-01'
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the today’s date will be used by default
        /// <br/>minimum value shouldn’t preceed the date specified in the date_from
        /// <br/>maximum value: today’s date
        /// <br/>date format: 'yyyy-mm-dd'
        /// <br/>example:
        /// <br/>'2021-01-15'
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// time range which will be used to group the results
        /// <br/>optional field
        /// <br/>default value: month
        /// <br/>possible values: day, week, month, year
        /// <br/>note: for day, we will return items corresponding to all dates between and including date_from and date_to;
        /// <br/>for week/month/year, we will return items corresponding to full weeks/months/years, where each item will indicate the last day of the week/month/year
        /// <br/>for example, if you specify:
        /// <br/>'group_range': 'month',
        /// <br/>'date_from': '2022-03-23',
        /// <br/>'date_to': '2022-05-13'
        /// <br/>we will return items falling between 2022-03-01 and 2022-05-31, namely, three items corresponding to the following dates: 2022-03-31, 2022-04-30, 2022-05-31
        /// <br/>if there is no data for a certain  day/week/month/year, we will return 0
        /// </summary>
        [JsonProperty("group_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GroupRange { get; set; }

        /// <summary>
        /// indicates if the subdomains of the target will be included in the search
        /// <br/>optional field
        /// <br/>if set to false, the subdomains will be ignored
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// defines the scale used for calculating and displaying the rank, domain_from_rank, and page_from_rank values
        /// <br/>optional field
        /// <br/>you can use this parameter to choose whether rank values are presented on a 0–100 or 0–1000 scale
        /// <br/>possible values:
        /// <br/>one_hundred — rank values are displayed on a 0–100 scale
        /// <br/>one_thousand — rank values are displayed on a 0–1000 scale
        /// <br/>default value: one_thousand
        /// <br/>learn more about how this parameter works and how ranking metrics are calculated in this Help Center article
        /// </summary>
        [JsonProperty("rank_scale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RankScale { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}