namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsGoogleHistoricalSearchVolumeLiveItem
    {
        /// <summary>
        /// search engine type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeType { get; set; }

        /// <summary>
        /// keyword
        /// <br/>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// location code in a POST array
        /// <br/>if there is no data, then the value is null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// language code in a POST array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// indicates data for Google and partner sites
        /// <br/>if true, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;
        /// <br/>if false, the results are returned for Google search sites only
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_partners", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SearchPartners { get; set; }

        /// <summary>
        /// keyword data for the returned keyword idea
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeywordInfo KeywordInfo { get; set; }

        /// <summary>
        /// contains keyword search volume normalized with Bing search volume
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_info_normalized_with_bing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeywordInfoNormalizedWithInfo KeywordInfoNormalizedWithBing { get; set; }

        /// <summary>
        /// contains keyword search volume normalized with clickstream data
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_info_normalized_with_clickstream", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeywordInfoNormalizedWithInfo KeywordInfoNormalizedWithClickstream { get; set; }

        /// <summary>
        /// clickstream data for the returned keyword
        /// <br/>to retrieve results for this field, the parameter include_clickstream_data must be set to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clickstream_keyword_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ClickstreamKeywordInfo ClickstreamKeywordInfo { get; set; }

        /// <summary>
        /// additional information about the keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KeywordProperties KeywordProperties { get; set; }

        /// <summary>
        /// impressions data for the returned keyword idea
        /// <br/>Note that all data in the impressions_info object is deprecated and provided only as legacy to avoid maintenance issues
        /// <br/>daily_impressions values provide a more accurate alternative to Google search volume data;
        /// <br/>the 999 bid is used to mitigate account-specific factors Google considers when calculating impressions
        /// <br/>learn more about impressions in this help center article
        /// </summary>
        [Newtonsoft.Json.JsonProperty("impressions_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ImpressionsInfo ImpressionsInfo { get; set; }

        /// <summary>
        /// SERP data
        /// <br/>the value will be null if you didn’t set the field include_serp_info to true in the POST array or if there is no SERP data for this keyword in our database
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serp_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SerpInfo SerpInfo { get; set; }

        /// <summary>
        /// backlink data for the returned keyword
        /// <br/>this object provides the average number of backlinks, referring pages and domains, as well as the average rank values among the top-10 websites ranking organically for the keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avg_backlinks_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AvgBacklinksInfo AvgBacklinksInfo { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}