namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EventDates
    {
        /// <summary>
        /// date and time when the event starts
        /// <br/>if time zone is specified in the event, value will be returned in the UTC format:
        /// <br/>“yyyy-mm-ddThh-mm-ss+00:00”
        /// <br/>example:
        /// <br/>2019-11-15T12:57:46+00:00
        /// <br/>if time zone is not specified in the event, unspecified local time will be returned in the following format:
        /// <br/>“yyyy-mm-ddThh-mm-ss”
        /// <br/>example:
        /// <br/>2019-11-15T12:57:46
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartDatetime { get; set; }

        /// <summary>
        /// date and time when the event ends
        /// <br/>if time zone is specified in the event, value will be returned in the UTC format:
        /// <br/>“yyyy-mm-ddThh-mm-ss+00:00”
        /// <br/>example:
        /// <br/>2019-11-15T12:57:46+00:00
        /// <br/>if time zone is not specified in the event, unspecified local time will be returned in the following format:
        /// <br/>“yyyy-mm-ddThh-mm-ss”
        /// <br/>example:
        /// <br/>2019-11-15T12:57:46
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_datetime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndDatetime { get; set; }

        /// <summary>
        /// date or date range as it is displayed in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayed_dates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayedDates { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}