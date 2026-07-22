using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageLighthouseLiveJsonRequestInfo 
    {

        /// <summary>
        /// target URL
        /// <br/>required field
        /// <br/>target page should be specified with its absolute URL (including http:// or https://)
        /// <br/>example:
        /// <br/>https://dataforseo.com/
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// applies mobile emulation
        /// <br/>optional field
        /// <br/>if set to true, Lighthouse will use mobile device and screen emulation to test the page against mobile environment
        /// <br/>if set to false, the results will be provided for desktop
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("for_mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForMobile { get; set; }

        /// <summary>
        /// categories of Lighthouse audits
        /// <br/>optional field
        /// <br/>each category is a collection of audits and audit groups that applies weighting and scoring to the section (see official definition)if you ignore this field, we will return data for all categories unless you specify audits
        /// <br/>use this field to get data for specific categories you indicate herepossible values:
        /// <br/>seo, performance, best_practices, accessibility
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Lighthouse audits
        /// <br/>optional field
        /// <br/>audits are individual tests Lighthouse runs for each specific feature/optimization/metric to produce a numeric score (see official definition);  if you ignore this field, we will return data for all audits;
        /// <br/>use this field to get data for specific audits you indicate here;Note: that some audits do not belong to a specific category and are stand-alone page quality measurements;in general, there can be several use cases:1. if you ignore categories, you can use this field to get data for the specified audits only
        /// <br/>for example, if you ignore 'categories' and specify 'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time'], you will get data only for these audits2. if you specify a category, you can use this field to additionally receive audits that do not belong to the category(-ies) you specified
        /// <br/>for example, if you specify 'categories': ['seo'] and 'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time'], you will get only these audits under 'performance' and all audits under 'seo'you can get the full list of possible audits here
        /// </summary>
        [JsonProperty("audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Audits { get; set; }

        /// <summary>
        /// lighthouse version
        /// <br/>optional field
        /// <br/>you can obtain the results specific to a certain Lighthouse version by specifying its number
        /// <br/>the list of available versions is available through the Lighthouse Versions endpoint
        /// </summary>
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// lighthouse language name
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languages
        /// <br/>default value:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// lighthouse language code
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languages
        /// <br/>default value:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// custom user agent
        /// <br/>optional field
        /// <br/>specify the custom user agent used by the browser when running the Lighthouse audit;
        /// <br/>can be specified with up to 254 characters;
        /// </summary>
        [JsonProperty("custom_user_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomUserAgent { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>set the screen width of the browser used for the Lighthouse audit to emulate a specific device;
        /// <br/>can be specified within the following range: 240–9999;
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>set the screen height of the browser used for the Lighthouse audit to emulate a specific device;
        /// <br/>can be specified within the following range: 240–9999;
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>set the device pixel ratio of the browser used for the Lighthouse audit;
        /// <br/>can be specified within the following range: 0.5–3;
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// browser network throttling method
        /// <br/>optional field
        /// <br/>defines the method used to apply throttling during the Lighthouse audit;
        /// <br/>possible vaules:
        /// <br/>simulate - calculates estimated performance metrics without applying explicit throttling;
        /// <br/>devtools -  applies the throttling settings specified in browser_network_throttling and browser_cpu_throttling_multiplier;
        /// <br/>provided - uses the network conditions of the crawling environment;
        /// </summary>
        [JsonProperty("browser_network_throttling_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserNetworkThrottlingMethod { get; set; }

        /// <summary>
        /// browser CPU throttling multiplier
        /// <br/>required if browser_network_throttling_method is set to devtools;
        /// <br/>set the CPU throttling multiplier to simulate device performance conditions during the Lighthouse audit;
        /// <br/>can be specified within the following range: 1–4;
        /// <br/>Note: this parameter is applied only when browser_network_throttling_method is set to devtools;
        /// </summary>
        [JsonProperty("browser_cpu_throttling_multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserCpuThrottlingMultiplier { get; set; }

        /// <summary>
        /// browser network throttling
        /// <br/>required if browser_network_throttling_method is set to devtools;
        /// <br/>set the network throttling profile to simulate connection speed conditions during the Lighthouse audit;
        /// <br/>possible values: no_throttling, fast_4g, slow_4g, regular_3g, pc;
        /// <br/>Note: this parameter is applied only when browser_network_throttling_method is set to devtools;
        /// </summary>
        [JsonProperty("browser_network_throttling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserNetworkThrottling { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
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