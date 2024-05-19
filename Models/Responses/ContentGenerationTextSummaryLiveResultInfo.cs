using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContentGenerationTextSummaryLiveResultInfo
    {
        /// <summary>
        /// number of sentences found in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sentences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Sentences { get; set; }

        /// <summary>
        /// number of paragraphs found in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paragraphs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Paragraphs { get; set; }

        /// <summary>
        /// number of words found in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("words", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Words { get; set; }

        /// <summary>
        /// number of characters without spaces found in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("characters_without_spaces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CharactersWithoutSpaces { get; set; }

        /// <summary>
        /// number of characters with spaces found in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("characters_with_spaces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CharactersWithSpaces { get; set; }

        /// <summary>
        /// average number of words per sentence in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("words_per_sentence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? WordsPerSentence { get; set; }

        /// <summary>
        /// average number of characters per word in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("characters_per_word", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? CharactersPerWord { get; set; }

        /// <summary>
        /// vocabulary density of the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vocabulary_density", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? VocabularyDensity { get; set; }

        /// <summary>
        /// keyword density of the target text
        /// <br/>contains most common words and their count
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_density", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> KeywordDensity { get; set; }

        /// <summary>
        /// Automated Readability Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("automated_readability_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AutomatedReadabilityIndex { get; set; }

        /// <summary>
        /// Coleman–Liau Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coleman_liau_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ColemanLiauIndex { get; set; }

        /// <summary>
        /// Flesch–Kincaid Readability Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flesch_kincaid_grade_level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? FleschKincaidGradeLevel { get; set; }

        /// <summary>
        /// SMOG Readability Index
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smog_readability_index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? SmogReadabilityIndex { get; set; }

        /// <summary>
        /// number of spelling errors found in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spelling_errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SpellingErrors { get; set; }

        /// <summary>
        /// number of grammar errors found in the target text
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grammar_errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? GrammarErrors { get; set; }

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