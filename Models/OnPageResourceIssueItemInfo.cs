namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageResourceIssueItemInfo
    {
        /// <summary>
        /// line where the error was found
        /// </summary>
        [Newtonsoft.Json.JsonProperty("line", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Line { get; set; }

        /// <summary>
        /// column where the error was found
        /// </summary>
        [Newtonsoft.Json.JsonProperty("column", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Column { get; set; }

        /// <summary>
        /// text message of the error
        /// <br/>the full list of possible HTML errors can be found here
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// status code of the error
        /// <br/>possible values:
        /// <br/>0 — Unidentified Error;
        /// <br/>501 — Html Parse Error;
        /// <br/>1501 — JS Parse Error;
        /// <br/>2501 — CSS Parse Error;
        /// <br/>3501 — Image Parse Error;
        /// <br/>3502 — Image Scale Is Zero;
        /// <br/>3503 — Image Size Is Zero;
        /// <br/>3504 — Image Format Invalid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}