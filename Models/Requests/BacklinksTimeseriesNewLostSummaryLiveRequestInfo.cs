using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class BacklinksTimeseriesNewLostSummaryLiveRequestInfo 
    {

        /// <summary>
        /// domain to get data for
        /// <br/>required field
        /// <br/>a domain should be specified without <c>https://</c> and <c>www.</c>
        /// <br/>example:
        /// <br/><c>'forbes.com'</c>
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// starting date of the time range
        /// <br/>optional field
        /// <br/>this field indicates the date which will be used as a threshold for new and lost backlinks and referring domains;
        /// <br/>the backlinks and referring domains that appeared in our index after the specified date will be considered as new;
        /// <br/>the backlinks and referring domains that weren't found after the specified date, but were present before, will be considered as lost;
        /// <br/>minimum value: <c>2019-01-30</c>
        /// <br/>maximum value shouldn't exceed the date specified in the <c>date_to</c>
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2021-01-01'</c>
        /// </summary>
        [JsonProperty("date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateFrom { get; set; }

        /// <summary>
        /// ending date of the time range
        /// <br/>optional field
        /// <br/>if you don't specify this field, the today's date will be used by default
        /// <br/>minimum value shouldn't preceed the date specified in the <c>date_from</c>
        /// <br/>maximum value: today's date
        /// <br/>date format: <c>'yyyy-mm-dd'</c>
        /// <br/>example:
        /// <br/><c>'2021-01-15'</c>
        /// </summary>
        [JsonProperty("date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DateTo { get; set; }

        /// <summary>
        /// time range which will be used to group the results
        /// <br/>optional field
        /// <br/>default value: <c>month</c>
        /// <br/>possible values: <c>day</c>, <c>week</c>, <c>month</c>, <c>year</c>
        /// <br/>note: for <c>day</c>, we will return items corresponding to all dates between and including <c>date_from</c> and <c>date_to</c>;
        /// <br/>for <c>week</c>/<c>month</c>/<c>year</c>, we will return items corresponding to full weeks/months/years, where each item will indicate the last day of the week/month/year
        /// <br/>for example, if you specify: 
        /// <br/><c>'group_range': 'month','date_from': '2022-03-23','date_to': '2022-05-13'</c>
        /// <br/>we will return items falling between 2022-03-01 and 2022-05-31, namely, three items corresponding to the following dates: <c>2022-03-31</c>, <c>2022-04-30</c>, <c>2022-05-31</c>
        /// <br/>if there is no data for a certain  <c>day</c>/<c>week</c>/<c>month</c>/<c>year</c>, we will return <c>0</c>
        /// </summary>
        [JsonProperty("group_range", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GroupRange { get; set; }

        /// <summary>
        /// indicates if the subdomains of the <c>target</c> will be included in the search
        /// <br/>optional field
        /// <br/>if set to <c>false</c>, the subdomains will be ignored
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("include_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
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