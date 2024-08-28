namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HtmlContentInfo
    {
        /// <summary>
        /// total size of the text on the page measured in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plain_text_size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PlainTextSize { get; set; }

        /// <summary>
        /// plaintext rate value
        /// <br/>plain_text_size to size ratio
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plain_text_rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PlainTextRate { get; set; }

        /// <summary>
        /// number of words on the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plain_text_word_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? PlainTextWordCount { get; set; }

        /// <summary>
        /// Automated Readability Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("automated_readability_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AutomatedReadabilityIndex { get; set; }

        /// <summary>
        /// Coleman–Liau Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coleman_liau_readability_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ColemanLiauReadabilityIndex { get; set; }

        /// <summary>
        /// Dale–Chall Readability Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dale_chall_readability_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? DaleChallReadabilityIndex { get; set; }

        /// <summary>
        /// Flesch–Kincaid Readability Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flesch_kincaid_readability_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? FleschKincaidReadabilityIndex { get; set; }

        /// <summary>
        /// SMOG Readability Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smog_readability_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? SmogReadabilityIndex { get; set; }

        /// <summary>
        /// consistency of the meta description tag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description_to_content_consistency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? DescriptionToContentConsistency { get; set; }

        /// <summary>
        /// consistency of the meta title tag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_to_content_consistency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? TitleToContentConsistency { get; set; }

        /// <summary>
        /// consistency of meta keywordstag with the page content
        /// <br/>measured from 0 to 1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meta_keywords_to_content_consistency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? MetaKeywordsToContentConsistency { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}