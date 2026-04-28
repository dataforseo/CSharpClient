using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageLighthouseLiveJsonRequestInfo 
    {

        /// <summary>
        /// target URLrequired fieldtarget page should be specified with its absolute URL (including http:// or https://)example:https://dataforseo.com/
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// applies mobile emulationoptional fieldif set to true, Lighthouse will use mobile device and screen emulation to test the page against mobile environmentif set to false, the results will be provided for desktopdefault value: false
        /// </summary>
        [JsonProperty("for_mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForMobile { get; set; }

        /// <summary>
        /// categories of Lighthouse auditsoptional fieldeach category is a collection of audits and audit groups that applies weighting and scoring to the section (see official definition)if you ignore this field, we will return data for all categories unless you specify auditsuse this field to get data for specific categories you indicate herepossible values:seo, performance, best_practices, accessibility
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Lighthouse auditsoptional fieldaudits are individual tests Lighthouse runs for each specific feature/optimization/metric to produce a numeric score (see official definition);  if you ignore this field, we will return data for all audits;use this field to get data for specific audits you indicate here;Note: that some audits do not belong to a specific category and are stand-alone page quality measurements;in general, there can be several use cases:1. if you ignore categories, you can use this field to get data for the specified audits onlyfor example, if you ignore 'categories' and specify 'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time'], you will get data only for these audits2. if you specify a category, you can use this field to additionally receive audits that do not belong to the category(-ies) you specifiedfor example, if you specify 'categories': ['seo'] and 'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time'], you will get only these audits under 'performance' and all audits under 'seo'you can get the full list of possible audits here
        /// </summary>
        [JsonProperty("audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Audits { get; set; }

        /// <summary>
        /// lighthouse versionoptional fieldyou can obtain the results specific to a certain Lighthouse version by specifying its numberthe list of available versions is available through the Lighthouse Versions endpoint
        /// </summary>
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// lighthouse language nameoptional fieldyou can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languagesdefault value:English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// lighthouse language codeoptional fieldyou can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languagesdefault value:en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// custom user agentoptional fieldspecify the custom user agent used by the browser when running the Lighthouse audit;can be specified with up to 254 characters;
        /// </summary>
        [JsonProperty("custom_user_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomUserAgent { get; set; }

        /// <summary>
        /// browser screen widthoptional fieldset the screen width of the browser used for the Lighthouse audit to emulate a specific device;can be specified within the following range: 240–9999;
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen heightoptional fieldset the screen height of the browser used for the Lighthouse audit to emulate a specific device;can be specified within the following range: 240–9999;
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factoroptional fieldset the device pixel ratio of the browser used for the Lighthouse audit;can be specified within the following range: 0.5–3;
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// browser network throttling methodoptional fielddefines the method used to apply throttling during the Lighthouse audit;possible vaules:simulate - calculates estimated performance metrics without applying explicit throttling;devtools -  applies the throttling settings specified in browser_network_throttling and browser_cpu_throttling_multiplier;provided - uses the network conditions of the crawling environment;
        /// </summary>
        [JsonProperty("browser_network_throttling_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserNetworkThrottlingMethod { get; set; }

        /// <summary>
        /// browser CPU throttling multiplierrequired if browser_network_throttling_method is set to devtools;set the CPU throttling multiplier to simulate device performance conditions during the Lighthouse audit;can be specified within the following range: 1–4;Note: this parameter is applied only when browser_network_throttling_method is set to devtools;
        /// </summary>
        [JsonProperty("browser_cpu_throttling_multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserCpuThrottlingMultiplier { get; set; }

        /// <summary>
        /// browser network throttlingrequired if browser_network_throttling_method is set to devtools;set the network throttling profile to simulate connection speed conditions during the Lighthouse audit;possible values: no_throttling, fast_4g, slow_4g, regular_3g, pc;Note: this parameter is applied only when browser_network_throttling_method is set to devtools;
        /// </summary>
        [JsonProperty("browser_network_throttling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserNetworkThrottling { get; set; }

        /// <summary>
        /// user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}