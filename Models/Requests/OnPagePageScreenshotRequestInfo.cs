using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPagePageScreenshotRequestInfo
    {
        /// <summary>
        /// page url
        /// <br/>required field
        /// <br/>absolute URL of the page to snap
        /// <br/>note: if the URL you indicate here returns a 404 status code or the indicated value is not a valid URL, you will obtain "error_message":"Screenshot is empty" in the response array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>note: if you do not specify this parameter, some websites may deny access; in this case, you will obtain "error_message":"Screenshot is empty" in the response array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// custom user agent
        /// <br/>optional field
        /// <br/>custom user agent for crawling a website
        /// <br/>example: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36
        /// <br/>
        /// <br/>default value: Mozilla/5.0 (compatible; RSiteAuditor)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_user_agent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomUserAgent { get; set; }

        /// <summary>
        /// preset for browser screen parameters
        /// <br/>optional field
        /// <br/>if you use this field, you don’t need to indicate browser_screen_width, browser_screen_height, browser_screen_scale_factor
        /// <br/>possible values:
        /// <br/>desktop, mobile, tablet
        /// <br/>desktop preset will apply the following values:
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
        /// <br/>Note: in this endpoint, the enable_browser_rendering, enable_javascript, load_resources, and enable_xhr parameters are always enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_preset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>minimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>minimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_height", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>minimum value: 0.5
        /// <br/>maximum value: 3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_scale_factor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// take a screenshot of the full page
        /// <br/>optional field
        /// <br/>set to false if you want to capture only the part of the page displayed before scrolling
        /// <br/>default value: true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full_page_screenshot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FullPageScreenshot { get; set; }

        /// <summary>
        /// disable the cookie popup 
        /// <br/>optional field
        /// <br/>set to true if you want to disable the popup requesting cookie consent from the user;
        /// <br/>default value:
        /// <br/>false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disable_cookie_popup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DisableCookiePopup { get; set; }

        /// <summary>
        /// custom javascript
        /// <br/>optional field
        /// <br/>Note that the execution time for the script you enter here should be 700 ms maximum
        /// <br/>for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute:
        /// <br/>let meta = { haveGoogleAnalytics: false, haveTagManager: false };\r\nfor (var i = 0; i &lt; document.scripts.length; i++) {\r\n  let src = document.scripts[i].getAttribute(\"src\");\r\n  if (src != undefined) {\r\n    if (src.indexOf(\"analytics.js\") &gt;= 0)\r\n      meta.haveGoogleAnalytics = true;\r\n\tif (src.indexOf(\"gtm.js\") &gt;= 0)\r\n      meta.haveTagManager = true;\r\n  }\r\n}\r\nmeta;
        /// <br/>the returned value depends on what you specified in this field. For instance, if you specify the following script:
        /// <br/>meta = {}; meta.url = document.URL; meta.test = 'test'; meta;
        /// <br/>as a response you will receive the following data:
        /// <br/>"custom_js_response": {
        /// <br/>  "url": "https://dataforseo.com/",
        /// <br/>  "test": "test"
        /// <br/>}
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_js", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomJs { get; set; }

        /// <summary>
        /// switch proxy pool
        /// <br/>optional field
        /// <br/>if true, additional proxy pools will be used to obtain the requested data;
        /// <br/>the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors
        /// </summary>
        [Newtonsoft.Json.JsonProperty("switch_pool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SwitchPool { get; set; }

        /// <summary>
        /// proxy pool
        /// <br/>optional field
        /// <br/>you can choose a location of the proxy pool that will be used to obtain the requested data;
        /// <br/>the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional site_unreachable errors
        /// <br/>possible values: us, de
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_pool_for_scan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IpPoolForScan { get; set; }

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