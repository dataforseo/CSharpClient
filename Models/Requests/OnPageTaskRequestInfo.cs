using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OnPageTaskRequestInfo
    {
        /// <summary>
        /// target domain
        /// <br/>required field
        /// <br/>domain name should be specified without https:// and www.
        /// <br/>if you specify the page URL, the results will be returned for the domain included in the URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// crawled pages limit
        /// <br/>required field
        /// <br/>the number of pages to crawl on the specified domain
        /// <br/>Note:
        /// <br/>if you set max_crawl_pages to 1 and do not specify start_url or set a homepage in it, the following sitewide checks will be disabled:
        /// <br/>test_canonicalization, enable_www_redirect_check, test_hidden_server_signature, test_page_not_found, test_directory_browsing, test_https_redirect
        /// <br/>to enable them anyway, set force_sitewide_checks to trueif you set max_crawl_pages to 1 and specify start_url other than a homepage, all sitewide checks will be disabled;
        /// <br/>to enable them anyway, set force_sitewide_checks to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_crawl_pages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// the first url to crawl 
        /// <br/>optional field
        /// <br/>Note: you should specify an absolute URL
        /// <br/>if you want to crawl a single page, specify its URL in this field and additionally set the max_crawl_pages parameter to 1
        /// <br/>you can also use the live Instant Pages endpoint to get page-specific data
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartUrl { get; set; }

        /// <summary>
        /// enable sitewide checks when crawling a single page
        /// <br/>optional field
        /// <br/>set to true to get data on sitewide checks when crawling a single page;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("force_sitewide_checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ForceSitewideChecks { get; set; }

        /// <summary>
        /// urls to be crawled bypassing the queue
        /// <br/>optional field
        /// <br/>URLs specified in this array will be crawled in the first instance, bypassing the crawling queue;
        /// <br/>Note: you should specify the absolute URL;
        /// <br/>you can specify up to 20 URLs;
        /// <br/>all URLs in the array must belong to the target domain;
        /// <br/>subdomains will be ignored unless the allow_subdomains parameter is set to trueexample:
        /// <br/>"priority_urls": [
        /// <br/>"https://dataforseo.com/apis/serp-api",
        /// <br/>"https://dataforseo.com/contact"
        /// <br/>]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority_urls", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> PriorityUrls { get; set; }

        /// <summary>
        /// crawl depth
        /// <br/>optional field
        /// <br/>the linking depth of the pages to crawl;
        /// <br/>for example, starting page of the crawl is level 0, pages that have links from that page are level 1, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_crawl_depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxCrawlDepth { get; set; }

        /// <summary>
        /// delay between hits, ms
        /// <br/>optional field
        /// <br/>the custom delay between crawler hits to the server
        /// <br/>default value: 2000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crawl_delay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CrawlDelay { get; set; }

        /// <summary>
        /// store HTML of crawled pages
        /// <br/>optional field
        /// <br/>set to true if you want to get the HTML of the page using the OnPage Raw HTML endpoint
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_raw_html", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? StoreRawHtml { get; set; }

        /// <summary>
        /// parse content on crawled pages
        /// <br/>optional field
        /// <br/>set to true to use the OnPage Content Parsing endpoint
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_content_parsing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnableContentParsing { get; set; }

        /// <summary>
        /// support cookies on crawled pages
        /// <br/>optional field
        /// <br/>set to true to support cookies when crawling the pages
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_cookies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SupportCookies { get; set; }

        /// <summary>
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the "type":"broken in the response array
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// custom robots.txt settings
        /// <br/>optional field
        /// <br/>example: Disallow: /directory1/
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_robots_txt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomRobotsTxt { get; set; }

        /// <summary>
        /// merge with or override robots.txt settings
        /// <br/>optional field
        /// <br/>possible values: merge, override;
        /// <br/>set to override if you want to ignore website crawling restrictions and other robots.txt settings
        /// <br/>default value: merge;
        /// <br/>Note: if set to override, specify the custom_robots_txt parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("robots_txt_merge_mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RobotsTxtMergeMode { get; set; }

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
        /// <br/>if you use this field, you don’t need to indicate browser_screen_width, browser_screen_height, browser_screen_scale_factorpossible values:
        /// <br/>desktop, mobile, tabletdesktop preset will apply the following values:browser_screen_width: 1920
        /// <br/>browser_screen_height: 1080
        /// <br/>browser_screen_scale_factor: 1mobile preset will apply the following values:browser_screen_width: 390
        /// <br/>browser_screen_height: 844
        /// <br/>browser_screen_scale_factor: 3tablet preset will apply the following values:browser_screen_width: 1024
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
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to perform an audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240
        /// <br/>maximum value, in pixels: 9999
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_height", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to perform audit for a particular device;
        /// <br/>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
        /// <br/>Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value: 0.5
        /// <br/>maximum value: 3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("browser_screen_scale_factor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// respect sitemap when crawling
        /// <br/>optional field
        /// <br/>set to true if you want to follow the order of pages indicated in the primary sitemap when crawling;
        /// <br/>default value: false
        /// <br/>Note: if set to true, the click_depth value in the API response will equal 0;
        /// <br/>the max_crawl_depth field of the request will be ignored, you can specify the number of pages to crawl using the max_crawl_pages parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("respect_sitemap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? RespectSitemap { get; set; }

        /// <summary>
        /// custom sitemap url
        /// <br/>optional field
        /// <br/>the URL of the page where the alternative sitemap is located
        /// <br/>Note: if you want to use this parameter, respect_sitemap should be true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_sitemap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomSitemap { get; set; }

        /// <summary>
        /// crawl only pages indicated in the sitemap
        /// <br/>optional field
        /// <br/>set to true if you want to crawl only the pages indicated in the sitemap
        /// <br/>if you set this parameter to true and do not specify custom_sitemap, we will crawl the default sitemap
        /// <br/>default value: false
        /// <br/>Note: if you want to use this parameter, respect_sitemap should be true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crawl_sitemap_only", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CrawlSitemapOnly { get; set; }

        /// <summary>
        /// load resources
        /// <br/>optional field
        /// <br/>set to true if you want to load image, stylesheets, scripts, and broken resources
        /// <br/>default value: false
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("load_resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? LoadResources { get; set; }

        /// <summary>
        /// check if the domain implemented the www redirection
        /// <br/>optional field
        /// <br/>set to true if you want to check if the requested domain implemented the www to non-www redirect;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_www_redirect_check", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnableWwwRedirectCheck { get; set; }

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
        /// enable XMLHttpRequest on a page
        /// <br/>optional field
        /// <br/>set to true if you want our crawler to request data from a web server using the XMLHttpRequest object
        /// <br/>default value: false;if you use this field, enable_javascript must be set to true;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_xhr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EnableXhr { get; set; }

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
        /// <br/>Note that the execution time for the script you enter here should be 700 ms maximum, for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute:
        /// <br/>let meta = { haveGoogleAnalytics: false, haveTagManager: false };\r\nfor (var i = 0; i &lt; document.scripts.length; i++) {\r\n let src = document.scripts[i].getAttribute(\"src\");\r\n if (src != undefined) {\r\n if (src.indexOf(\"analytics.js\") &gt;= 0)\r\n      meta.haveGoogleAnalytics = true;\r\n\tif (src.indexOf(\"gtm.js\") &gt;= 0)\r\n      meta.haveTagManager = true;\r\n  }\r\n}\r\nmeta;the returned value depends on what you specified in this field. For instance, if you specify the following script:
        /// <br/>meta = {}; meta.url = document.URL; meta.test = 'test'; meta;
        /// <br/>as a response you will receive the following data:
        /// <br/>"custom_js_response": {
        /// <br/>"url": "https://dataforseo.com/",
        /// <br/>"test": "test"
        /// <br/>}
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_js", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomJs { get; set; }

        /// <summary>
        /// enable microdata validation
        /// <br/>optional field
        /// <br/>set to true if you want to use the OnPage API Microdata endpoint
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("validate_micromarkup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ValidateMicromarkup { get; set; }

        /// <summary>
        /// include pages on subdomains
        /// <br/>optional field
        /// <br/>set to true if you want to crawl all subdomains of a target website
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_subdomains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AllowSubdomains { get; set; }

        /// <summary>
        /// subdomains to crawl
        /// <br/>optional field
        /// <br/>specify subdomains that you want to crawl
        /// <br/>example: ["blog.site.com", "my.site.com", "shop.site.com"]
        /// <br/>Note: to use this parameter, the allow_subdomains parameter should be set to false;
        /// <br/>otherwise, the content of allowed_subdomains field will be ignored and the results will be returned for all subdomains
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allowed_subdomains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AllowedSubdomains { get; set; }

        /// <summary>
        /// subdomains not to crawl
        /// <br/>optional field
        /// <br/>specify subdomains that you don’t want to crawl
        /// <br/>example: ["status.site.com", "docs.site.com"]
        /// <br/>Note: to use this parameter, the allow_subdomains parameter should be set to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disallowed_subdomains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DisallowedSubdomains { get; set; }

        /// <summary>
        /// check spelling
        /// <br/>optional field
        /// <br/>set to true to check spelling on a website using Hunspell library
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_spell", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CheckSpell { get; set; }

        /// <summary>
        /// language of the spell check
        /// <br/>optional field
        /// <br/>supported languages: ‘hy’, ‘eu’, ‘bg’, ‘ca’, ‘hr’, ‘cs’, ‘da’, ‘nl’, ‘en’, ‘eo’, ‘et’, ‘fo’, ‘fa’, ‘fr’, ‘fy’, ‘gl’, ‘ka’, ‘de’, ‘el’, ‘he’, ‘hu’, ‘is’, ‘ia’, ‘ga’, ‘it’, ‘rw’, ‘la’, ‘lv’, ‘lt’, ‘mk’, ‘mn’, ‘ne’, ‘nb’, ‘nn’, ‘pl’, ‘pt’, ‘ro’, ‘gd’, ‘sr’, ‘sk’, ‘sl’, ‘es’, ‘sv’, ‘tr’, ‘tk’, ‘uk’, ‘vi’
        /// <br/>Note: if no language is specified, it will be set automatically based on page content
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_spell_language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckSpellLanguage { get; set; }

        /// <summary>
        /// words excluded from spell check
        /// <br/>optional field
        /// <br/>specify the words that you want to exclude from spell check
        /// <br/>maximum word length: 100 characters
        /// <br/>maximum amount of words: 1000
        /// <br/>example: "SERP", "minifiers", "JavaScript"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_spell_exceptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> CheckSpellExceptions { get; set; }

        /// <summary>
        /// calculate keyword density for the target domain
        /// <br/>optional field
        /// <br/>set to true if you want to calculate keyword density for website pages
        /// <br/>default value: false
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article
        /// <br/>once the crawl is completed, you can obtain keyword density values with the Keyword Density endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("calculate_keyword_density", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? CalculateKeywordDensity { get; set; }

        /// <summary>
        /// custom threshold values for checks
        /// <br/>optional field
        /// <br/>you can specify custom threshold values for the parameters included in the checks object of OnPage API responses;
        /// <br/>Note: only integer threshold values can be modified;
        /// <br/>for example, the high_loading_time and large_page_size parameters are set to 3 seconds and 1 megabyte respectively by default;
        /// <br/>if you want to change these thresholds to 1 second and 1000 kbytes, use the following snippet:
        /// <br/>"checks_threshold": {
        /// <br/>"high_loading_time": 1,
        /// <br/>"large_page_size": 1000
        /// <br/>}available customizable parameters with default values:
        /// <br/>"title_too_short", default value: 30, type: "int"
        /// <br/>"title_too_long", default value: 65, type: "int"
        /// <br/>"small_page_size", default value: 1024, type: "int"
        /// <br/>"large_page_size", default value: 1048576 (1024 * 1024), type: "int"
        /// <br/>"low_character_count", default value: 1024, type: "int"
        /// <br/>"high_character_count", default value: 256000 (250 * 1024), type: "int"
        /// <br/>"low_content_rate", default value: 0.1, type: "float"
        /// <br/>"high_content_rate", default value: 0.9, type: "float"
        /// <br/>"high_loading_time", default value: 3000, type: "int"
        /// <br/>"high_waiting_time", default value: 1500, type: "int"
        /// <br/>"low_readability_rate", default value: 15.0, type: "float"
        /// <br/>"irrelevant_description", default value: 0.2, type: "float"
        /// <br/>"irrelevant_title", default value: 0.3, type: "float"
        /// <br/>"irrelevant_meta_keywords", default value: 0.6, type: "float"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checks_threshold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, long?> ChecksThreshold { get; set; }

        /// <summary>
        /// prevent certain sitewide checks from running
        /// <br/>optional field
        /// <br/>specify the following checks to prevent them from running on the target website:
        /// <br/>"test_page_not_found"
        /// <br/>"test_canonicalization"
        /// <br/>"test_https_redirect"
        /// <br/>"test_directory_browsing"example:
        /// <br/>"disable_sitewide_checks": ["test_directory_browsing", "test_page_not_found"]learn more on our help center
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disable_sitewide_checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DisableSitewideChecks { get; set; }

        /// <summary>
        /// prevent certain page checks from running
        /// <br/>optional field
        /// <br/>specify certain checks to prevent them from running and impacting the onpage_scoreexample:
        /// <br/>"disable_page_checks": ["is_5xx_code", "is_4xx_code"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disable_page_checks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DisablePageChecks { get; set; }

        /// <summary>
        /// switch proxy pool
        /// <br/>optional field
        /// <br/>if true, additional proxy pools will be used to obtain the requested data;
        /// <br/>the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional rate-limit and/or site_unreachable errors
        /// </summary>
        [Newtonsoft.Json.JsonProperty("switch_pool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SwitchPool { get; set; }

        /// <summary>
        /// return data on pages despite the timeout error
        /// <br/>optional field
        /// <br/>if true, the data will be provided on pages that failed to load within 120 seconds and responded with a timeout error;
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_despite_timeout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ReturnDespiteTimeout { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/>http://your-server.com/pingscript?id=$id
        /// <br/>http://your-server.com/pingscript?id=$id&amp;tag=$tag
        /// <br/>Note: special symbols in pingback_url will be urlencoded;
        /// <br/>i.a., the # symbol will be encoded into %23
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pingback_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

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