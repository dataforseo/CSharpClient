using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageInstantPagesRequestInfo 
    {

        /// <summary>
        /// target page url
        /// <br/>required field
        /// <br/>absolute URL of the target page;
        /// <br/>Note #1: results will be returned for the specified URL only;
        /// <br/>Note #2: to prevent denial-of-service events, tasks that contain a duplicate crawl host will be returned with a 40501 error;
        /// <br/>to prevent this error from occurring, avoid setting tasks with the same domain if at least one of your previous tasks with this domain (including a page URL on the domain) is still in a crawling queue
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// custom user agent
        /// <br/>optional field
        /// <br/>custom user agent for crawling a website
        /// <br/>example: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36
        /// <br/>
        /// <br/>default value: Mozilla/5.0 (compatible; RSiteAuditor)
        /// </summary>
        [JsonProperty("custom_user_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomUserAgent { get; set; }

        /// <summary>
        /// preset for browser screen parameters
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to indicate browser_screen_width, browser_screen_height, browser_screen_scale_factorpossible values:
        /// <br/>desktop, mobile, tabletdesktop preset will apply the following values:
        /// <br/>browser_screen_width: 1920
        /// <br/>browser_screen_height: 1080
        /// <br/>browser_screen_scale_factor: 1
        /// <br/>mobile preset will apply the following values:
        /// <br/>browser_screen_width: 390
        /// <br/>browser_screen_height: 844
        /// <br/>browser_screen_scale_factor: 3
        /// <br/>tablet preset will apply the following values:
        /// <br/>browser_screen_width: 1024
        /// <br/>browser_screen_height: 1366
        /// <br/>browser_screen_scale_factor: 2
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
        /// </summary>
        [JsonProperty("browser_preset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value: 0.5
        /// <br/>maximum value: 3
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// store HTML of a crawled page
        /// <br/>optional field
        /// <br/>set to true if you want get the HTML of the page using the OnPage Raw HTML endpoint
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("store_raw_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreRawHtml { get; set; }

        /// <summary>
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the 'type':'broken in the response array
        /// </summary>
        [JsonProperty("accept_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// load resources
        /// <br/>optional field
        /// <br/>set to true if you want to load image, stylesheets, scripts, and broken resources
        /// <br/>default value: false
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [JsonProperty("load_resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadResources { get; set; }

        /// <summary>
        /// load javascript on a page
        /// <br/>optional field
        /// <br/>set to true if you want to load the scripts available on a page
        /// <br/>default value: false
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [JsonProperty("enable_javascript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableJavascript { get; set; }

        /// <summary>
        /// emulate browser rendering to measure Core Web Vitals
        /// <br/>optional field
        /// <br/>by using this parameter you will be able to emulate a browser when loading a web page;
        /// <br/>enable_browser_rendering loads styles, images, fonts, animations, videos, and other resources on a page;
        /// <br/>default value: false
        /// <br/>set to true to obtain Core Web Vitals (FID, CLS, LCP) metrics in the response;
        /// <br/>if you use this field, parameters enable_javascript, and load_resources are enabled automatically;
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [JsonProperty("enable_browser_rendering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBrowserRendering { get; set; }

        /// <summary>
        /// disable the cookie popup 
        /// <br/>optional field
        /// <br/>set to true if you want to disable the popup requesting cookie consent from the user;
        /// <br/>default value:
        /// <br/>false
        /// </summary>
        [JsonProperty("disable_cookie_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableCookiePopup { get; set; }

        /// <summary>
        /// return data on pages despite the timeout error
        /// <br/>optional field
        /// <br/>if true, the data will be provided on pages that failed to load within 120 seconds and responded with a timeout error;
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("return_despite_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnDespiteTimeout { get; set; }

        /// <summary>
        /// enable XMLHttpRequest on a page
        /// <br/>optional field
        /// <br/>set to true if you want our crawler to request data from a web server using the XMLHttpRequest object
        /// <br/>default value:
        /// <br/>falseif you use this field, enable_javascript must be set to true;
        /// </summary>
        [JsonProperty("enable_xhr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableXhr { get; set; }

        /// <summary>
        /// custom javascript
        /// <br/>optional fieldNote that the execution time for the script you enter here should be 700 ms maximum;
        /// <br/>for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute:
        /// <br/>let meta = { haveGoogleAnalytics: false, haveTagManager: false };\r\nfor (var i = 0; i &lt; document.scripts.length; i++) {\r\n let src = document.scripts[i].getAttribute(\'src\');\r\n if (src != undefined) {\r\n if (src.indexOf(\'analytics.js\') &gt;= 0)\r\n      meta.haveGoogleAnalytics = true;\r\n\tif (src.indexOf(\'gtm.js\') &gt;= 0)\r\n      meta.haveTagManager = true;\r\n  }\r\n}\r\nmeta;the returned value depends on what you specified in this field. For instance, if you specify the following script:
        /// <br/>meta = {}; meta.url = document.URL; meta.test = 'test'; meta;
        /// <br/>as a response you will receive the following data:
        /// <br/>'custom_js_response': {
        /// <br/>'url': 'https://dataforseo.com/',
        /// <br/>'test': 'test'
        /// <br/>}
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [JsonProperty("custom_js", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomJs { get; set; }

        /// <summary>
        /// enable microdata validation
        /// <br/>optional field
        /// <br/>if set to true, you can use the OnPage API Microdata endpoint with the id of the task;
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("validate_micromarkup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateMicromarkup { get; set; }

        /// <summary>
        /// check spelling
        /// <br/>optional field
        /// <br/>set to true to check spelling on a website using Hunspell library
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("check_spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckSpell { get; set; }

        /// <summary>
        /// custom threshold values for checks
        /// <br/>optional field
        /// <br/>you can specify custom threshold values for the parameters included in the checks array of OnPage API responses;
        /// <br/>Note: only integer threshold values can be modified;
        /// </summary>
        [JsonProperty("checks_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ChecksThreshold { get; set; }

        /// <summary>
        /// switch proxy pool
        /// <br/>optional field
        /// <br/>if true, additional proxy pools will be used to obtain the requested data;
        /// <br/>the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors
        /// </summary>
        [JsonProperty("switch_pool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchPool { get; set; }

        /// <summary>
        /// proxy pool
        /// <br/>optional field
        /// <br/>you can choose a location of the proxy pool that will be used to obtain the requested data;
        /// <br/>the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional site_unreachable errors
        /// <br/>possible values: us, de
        /// </summary>
        [JsonProperty("ip_pool_for_scan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string IpPoolForScan { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}