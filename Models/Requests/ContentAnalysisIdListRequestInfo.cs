using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class ContentAnalysisIdListRequestInfo 
    {

        /// <summary>
        /// start time for filtering results
        /// <br/>required field
        /// <br/>if <c>include_metadata</c> is set to <c>true</c>, maximum value: a month from current datetime;
        /// <br/>if <c>include_metadata</c> is set to <c>false</c>, maximum value: six months from current datetime;
        /// <br/>must be specified in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'
        /// <br/>example:
        /// <br/><c>2023-01-15 12:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("datetime_from", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DatetimeFrom { get; set; }

        /// <summary>
        /// finish time for filtering results
        /// <br/>required field
        /// <br/>maximum value: current datetime;
        /// <br/>must be specified in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'
        /// <br/>example:
        /// <br/><c>2023-01-31 13:57:46 +00:00</c>
        /// </summary>
        [JsonProperty("datetime_to", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DatetimeTo { get; set; }

        /// <summary>
        /// the maximum number of returned task IDs
        /// <br/>optional field
        /// <br/>default value: <c>1000</c>
        /// <br/>maximum value: <c>1000</c>
        /// </summary>
        [JsonProperty("limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned task IDs
        /// <br/>optional field
        /// <br/>default value: <c>0</c>
        /// <br/>if you specify the <c>10</c> value, the first ten tasks in the results array will be omitted
        /// </summary>
        [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// sorting by task execution time
        /// <br/>optional field
        /// <br/>possible values: <c>'asc'</c>, <c>'desc'</c>
        /// <br/>default value: <c>'asc'</c>
        /// </summary>
        [JsonProperty("sort", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// include task metadata in the respond
        /// <br/>optional field
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("include_metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeMetadata { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}