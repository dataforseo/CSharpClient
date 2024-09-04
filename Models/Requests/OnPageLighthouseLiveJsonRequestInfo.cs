using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageLighthouseLiveJsonRequestInfo
    {
        /// <summary>
        /// target URL
        /// <br/>required field
        /// <br/>target page should be specified with its absolute URL (including http:// or https://)
        /// <br/>example:
        /// <br/>https://dataforseo.com/
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// applies mobile emulation
        /// <br/>optional field
        /// <br/>if set to true, Lighthouse will use mobile device and screen emulation to test the page against mobile environment
        /// <br/>if set to false, the results will be provided for desktop
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("for_mobile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ForMobile { get; set; }

        /// <summary>
        /// categories of Lighthouse audits
        /// <br/>optional field
        /// <br/>each category is a collection of audits and audit groups that applies weighting and scoring to the section (see official definition)
        /// <br/>if you ignore this field, we will return data for all categories unless you specify audits
        /// <br/>use this field to get data for specific categories you indicate here
        /// <br/>possible values:
        /// <br/>seo, pwa, performance, best_practices, accessibility
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Categories { get; set; }

        /// <summary>
        /// Lighthouse audits
        /// <br/>optional field
        /// <br/>audits are individual tests Lighthouse runs for each specific feature/optimization/metric to produce a numeric score (see official definition)  
        /// <br/>if you ignore this field, we will return data for all audits
        /// <br/>use this field to get data for specific audits you indicate here
        /// <br/>note that some audits do not belong to a specific category and are stand-alone page quality measurements
        /// <br/>in general, there can be several use cases:
        /// <br/>1. if you ignore categories, you can use this field to get data for the specified audits only
        /// <br/>for example, if you ignore "categories" and specify "audits": ["metrics/cumulative-layout-shift","metrics/largest-contentful-paint","metrics/total-blocking-time"], you will get data only for these audits
        /// <br/>2. if you specify a category, you can use this field to additionally receive audits that do not belong to the category(-ies) you specified
        /// <br/>for example, if you specify "categories": ["seo"] and "audits": ["metrics/cumulative-layout-shift","metrics/largest-contentful-paint","metrics/total-blocking-time"], you will get only these audits under “performance” and all audits under “seo”
        /// <br/>you can get the full list of possible audits here
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Audits { get; set; }

        /// <summary>
        /// lighthouse version
        /// <br/>optional field
        /// <br/>you can obtain the results specific to a certain Lighthouse version by specifying its number
        /// <br/>the list of available versions is available through the Lighthouse Versions endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// lighthouse language name
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languages
        /// <br/>default value:
        /// <br/>English
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// lighthouse language code
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languages
        /// <br/>default value:
        /// <br/>en
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

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