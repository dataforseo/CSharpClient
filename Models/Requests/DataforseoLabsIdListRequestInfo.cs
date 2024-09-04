using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsIdListRequestInfo
    {
        /// <summary>
        /// start time for filtering results
        /// <br/>required field
        /// <br/>if include_metadata is set to true, maximum value: a month from current datetime;
        /// <br/>if include_metadata is set to false, maximum value: six months from current datetime;
        /// <br/>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2023-01-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatetimeFrom { get; set; }

        /// <summary>
        /// finish time for filtering results
        /// <br/>required field
        /// <br/>maximum value: current datetime;
        /// <br/>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2023-01-31 13:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatetimeTo { get; set; }

        /// <summary>
        /// the maximum number of returned task IDs
        /// <br/>optional field
        /// <br/>default value: 1000
        /// <br/>maximum value: 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned task IDs
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten tasks in the results array will be omitted
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// sorting by task execution time
        /// <br/>optional field
        /// <br/>possible values: "asc", "desc"
        /// <br/>default value: "asc"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// include task metadata in the respond
        /// <br/>optional field
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeMetadata { get; set; }

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