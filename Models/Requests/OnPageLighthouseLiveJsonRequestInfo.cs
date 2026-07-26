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
        /// <br/><c>https://dataforseo.com/</c>
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// applies mobile emulation
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, Lighthouse will use mobile device and screen emulation to test the page against mobile environment
        /// <br/>if set to <c>false</c>, the results will be provided for desktop
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("for_mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForMobile { get; set; }

        /// <summary>
        /// categories of Lighthouse audits
        /// <br/>optional field
        /// <br/>each category is a collection of audits and audit groups that applies weighting and scoring to the section (<see href="https://github.com/GoogleChrome/lighthouse/blob/master/docs/architecture.md#auditreport-terminology">see official definition</see>)
        /// <br/>if you ignore this field, we will return data for all categories unless you specify <c>audits</c>
        /// <br/>use this field to get data for specific categories you indicate here
        /// <br/>possible values:
        /// <br/><c>seo</c>, <c>performance</c>, <c>best_practices</c>, <c>accessibility</c>
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Lighthouse audits
        /// <br/>optional field
        /// <br/>audits are individual tests Lighthouse runs for each specific feature/optimization/metric to produce a numeric score (<see href="https://github.com/GoogleChrome/lighthouse/blob/master/docs/architecture.md#components--terminology">see official definition</see>);  
        /// <br/>if you ignore this field, we will return data for all audits;
        /// <br/>use this field to get data for specific audits you indicate here;
        /// <br/>Note: that some audits do not belong to a specific category and are stand-alone page quality measurements;
        /// <br/>in general, there can be several use cases:
        /// <br/>1. if you ignore <c>categories</c>, you can use this field to get data for the specified audits only
        /// <br/>for example, if you ignore <c>'categories'</c> and specify <c>'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time']</c>, you will get data only for these audits
        /// <br/>2. if you specify a category, you can use this field to additionally receive audits that do not belong to the category(-ies) you specified
        /// <br/>for example, if you specify <c>'categories': ['seo']</c> and <c>'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time']</c>, you will get only these audits under 'performance' and all audits under 'seo'
        /// <br/>you can get <see href="/v3/on_page/lighthouse/audits/">the full list of possible audits here</see>
        /// </summary>
        [JsonProperty("audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Audits { get; set; }

        /// <summary>
        /// lighthouse version
        /// <br/>optional field
        /// <br/>you can obtain the results specific to a certain Lighthouse version by specifying its number
        /// <br/>the list of available versions is available through the <see href="/v3/on_page/lighthouse/versions/">Lighthouse Versions endpoint</see>
        /// </summary>
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// lighthouse language name
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to <c>https://api.dataforseo.com/v3/on_page/lighthouse/languages</c>
        /// <br/>default value:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// lighthouse language code
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to <c>https://api.dataforseo.com/v3/on_page/lighthouse/languages</c>
        /// <br/>default value:
        /// <br/><c>en</c>
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
        /// <br/>can be specified within the following range: <c>240–9999</c>;
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>set the screen height of the browser used for the Lighthouse audit to emulate a specific device;
        /// <br/>can be specified within the following range: <c>240–9999</c>;
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>set the device pixel ratio of the browser used for the Lighthouse audit;
        /// <br/>can be specified within the following range: <c>0.5–3</c>;
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// browser network throttling method
        /// <br/>optional field
        /// <br/>defines the method used to apply throttling during the Lighthouse audit;
        /// <br/>possible vaules:
        /// <br/><c>simulate</c> - calculates estimated performance metrics without applying explicit throttling;
        /// <br/><c>devtools</c> -  applies the throttling settings specified in <c>browser_network_throttling</c> and <c>browser_cpu_throttling_multiplier</c>;
        /// <br/><c>provided</c> - uses the network conditions of the crawling environment;
        /// </summary>
        [JsonProperty("browser_network_throttling_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserNetworkThrottlingMethod { get; set; }

        /// <summary>
        /// browser CPU throttling multiplier
        /// <br/>required if <c>browser_network_throttling_method</c> is set to <c>devtools</c>;
        /// <br/>set the CPU throttling multiplier to simulate device performance conditions during the Lighthouse audit;
        /// <br/>can be specified within the following range: <c>1–4</c>;
        /// <br/>Note: this parameter is applied only when <c>browser_network_throttling_method</c> is set to <c>devtools</c>;
        /// </summary>
        [JsonProperty("browser_cpu_throttling_multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserCpuThrottlingMultiplier { get; set; }

        /// <summary>
        /// browser network throttling
        /// <br/>required if <c>browser_network_throttling_method</c> is set to <c>devtools</c>;
        /// <br/>set the network throttling profile to simulate connection speed conditions during the Lighthouse audit;
        /// <br/>possible values: <c>no_throttling</c>, <c>fast_4g</c>, <c>slow_4g</c>, <c>regular_3g</c>, <c>pc</c>;
        /// <br/>Note: this parameter is applied only when <c>browser_network_throttling_method</c> is set to <c>devtools</c>;
        /// </summary>
        [JsonProperty("browser_network_throttling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserNetworkThrottling { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
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