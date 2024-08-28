using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo : KeywordsDataTaskRequestInfo
    {
        /// <summary>
        /// target website
        /// <br/>optional field
        /// <br/>specify a website or URL to get a list of keywords relevant to it;
        /// <br/>Note: if a website url is specified, you will still get keywords relevant for the entire website
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }
    }
}