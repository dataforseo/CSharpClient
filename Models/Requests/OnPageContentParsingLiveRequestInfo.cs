using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageContentParsingLiveRequestInfo
    {
        /// <summary>
        /// URL of the content to parse
        /// <br/>required field
        /// <br/>URL of the page to parse
        /// <br/>example:
        /// <br/>https://www.fujielectric.com/
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

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
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_preset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
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
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
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
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
        /// <br/>minimum value: 0.5
        /// <br/>maximum value: 3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_scale_factor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// store HTML of a crawled page
        /// <br/>optional field
        /// <br/>set to true if you want to get the HTML of the page using the OnPage Raw HTML endpoint
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_raw_html", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? StoreRawHtml { get; set; }

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
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the "type":"broken in the response array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// load javascript on a page
        /// <br/>optional field
        /// <br/>set to true if you want to load the scripts available on a page
        /// <br/>default value: false
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_javascript", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnableJavascript { get; set; }

        /// <summary>
        /// emulate browser rendering to measure Core Web Vitals
        /// <br/>optional field
        /// <br/>by using this parameter you will be able to emulate a browser when loading a web page;
        /// <br/>enable_browser_rendering loads styles, images, fonts, animations, videos, and other resources on a page;
        /// <br/>default value: false
        /// <br/>set to true to obtain Core Web Vitals (FID, CLS, LCP) metrics in the response;
        /// <br/>if you use this field, enable_javascript, and load_resources parameters must be set to true
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_browser_rendering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnableBrowserRendering { get; set; }

        /// <summary>
        /// enable XMLHttpRequest on a page
        /// <br/>optional field
        /// <br/>set to true if you want our crawler to request data from a web server using the XMLHttpRequest object
        /// <br/>default value:
        /// <br/>false
        /// <br/>if you use this field, enable_javascript must be set to true;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_xhr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnableXhr { get; set; }

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