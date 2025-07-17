using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPagePageScreenshotRequestInfo 
    {

        /// <summary>
        /// page url
        /// <br/>required field
        /// <br/>absolute URL of the page to snap
        /// <br/>note: if the URL you indicate here returns a 404 status code or the indicated value is not a valid URL, you will obtain 'error_message':'Screenshot is empty' in the response array
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>note: if you do not specify this parameter, some websites may deny access; in this case, you will obtain 'error_message':'Screenshot is empty' in the response array
        /// </summary>
        [JsonProperty("accept_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

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
        [JsonProperty("browser_preset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>minimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>minimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>minimum value: 0.5
        /// <br/>maximum value: 3
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// take a screenshot of the full page
        /// <br/>optional field
        /// <br/>set to false if you want to capture only the part of the page displayed before scrolling
        /// <br/>default value: true
        /// </summary>
        [JsonProperty("full_page_screenshot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FullPageScreenshot { get; set; }

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