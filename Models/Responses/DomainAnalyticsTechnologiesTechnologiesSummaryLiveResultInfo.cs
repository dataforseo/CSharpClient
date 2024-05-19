using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DomainAnalyticsTechnologiesTechnologiesSummaryLiveResultInfo
    {
        /// <summary>
        /// distribution of websites by country
        /// <br/>contains country codes and number of websites per country
        /// </summary>
        [Newtonsoft.Json.JsonProperty("countries", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> Countries { get; set; }

        /// <summary>
        /// distribution of websites by language
        /// <br/>contains language codes and number of websites per language
        /// </summary>
        [Newtonsoft.Json.JsonProperty("languages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> Languages { get; set; }

        /// <summary>
        /// distribution of websites by content language
        /// <br/>contains content language codes and number of websites per language
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_languages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ContentLanguages { get; set; }

        /// <summary>
        /// distribution of websites by keywords
        /// <br/>contains keywords found in the websites’ titles, descriptions or meta keywords, and number of websites using each keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keywords", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> Keywords { get; set; }

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