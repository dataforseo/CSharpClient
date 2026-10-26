using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageTaskPostRequestInfo 
    {

        /// <summary>
        /// target domain
        /// <br/>required field
        /// <br/>domain name should be specified without <c>https://</c> and <c>www.</c>
        /// <br/>if you specify the page URL, the results will be returned for the domain included in the URL
        /// </summary>
        [JsonProperty("target", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// crawled pages limit
        /// <br/>required field
        /// <br/>the number of pages to crawl on the specified domain
        /// <br/>Note:
        /// <br/>if you set <c>max_crawl_pages</c> to 1 and do not specify <c>start_url</c> or set a homepage in it, the following sitewide checks will be disabled:
        /// <br/><c>test_canonicalization</c>, <c>enable_www_redirect_check</c>, <c>test_hidden_server_signature</c>, <c>test_page_not_found</c>, <c>test_directory_browsing</c>, <c>test_https_redirect</c>
        /// <br/>to enable them anyway, set <c>force_sitewide_checks</c> to <c>true</c>if you set <c>max_crawl_pages</c> to 1 and specify <c>start_url</c> other than a homepage, all sitewide checks will be disabled;
        /// <br/>to enable them anyway, set <c>force_sitewide_checks</c> to <c>true</c>
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// the first url to crawl 
        /// <br/>optional field
        /// <br/>Note: you should specify an absolute URL
        /// <br/>if you want to crawl a single page, specify its URL in this field and additionally set the <c>max_crawl_pages</c> parameter to <c>1</c>
        /// <br/>you can also use the <see href="/v3/on_page/instant_pages/?bash">live Instant Pages endpoint</see> to get page-specific data
        /// </summary>
        [JsonProperty("start_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string StartUrl { get; set; }

        /// <summary>
        /// enable sitewide checks when crawling a single page
        /// <br/>optional field
        /// <br/>set to <c>true</c> to get data on sitewide checks when crawling a single page;
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("force_sitewide_checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceSitewideChecks { get; set; }

        /// <summary>
        /// urls to be crawled bypassing the queue
        /// <br/>optional field
        /// <br/>URLs specified in this array will be crawled in the first instance, bypassing the crawling queue;
        /// <br/>Note: you should specify the absolute URL;
        /// <br/>you can specify up to 20 URLs;
        /// <br/>all URLs in the array must belong to the <c>target</c> domain;
        /// <br/>subdomains will be ignored unless the <c>allow_subdomains</c> parameter is set to <c>true</c>example:
        /// <br/>`'priority_urls': [
        /// <br/>'https://dataforseo.com/apis/serp-api',
        /// <br/>'https://dataforseo.com/contact'
        /// <br/>]`
        /// </summary>
        [JsonProperty("priority_urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> PriorityUrls { get; set; }

        /// <summary>
        /// crawl depth
        /// <br/>optional field
        /// <br/>the linking depth of the pages to crawl;
        /// <br/>for example, starting page of the crawl is level 0, pages that have links from that page are level 1, etc.
        /// </summary>
        [JsonProperty("max_crawl_depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlDepth { get; set; }

        /// <summary>
        /// delay between hits, ms
        /// <br/>optional field
        /// <br/>the custom delay between crawler hits to the server
        /// <br/>default value: <c>2000</c>
        /// </summary>
        [JsonProperty("crawl_delay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CrawlDelay { get; set; }

        /// <summary>
        /// store HTML of crawled pages
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to get the HTML of the page using the <see href="/v3/on_page/raw_html/">OnPage Raw HTML endpoint</see>
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("store_raw_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreRawHtml { get; set; }

        /// <summary>
        /// parse content on crawled pages
        /// <br/>optional field
        /// <br/>set to <c>true</c> to use the <see href="/v3/on_page/content_parsing/live/">OnPage Content Parsing endpoint</see>
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter <see href="https://dataforseo.com/help-center/cost-of-onpage-api-parameters">in our help article</see>; the cost can be calculated on the <see href="https://dataforseo.com/pricing/on-page/onpage-api">Pricing Page</see>
        /// </summary>
        [JsonProperty("enable_content_parsing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableContentParsing { get; set; }

        /// <summary>
        /// support cookies on crawled pages
        /// <br/>optional field
        /// <br/>set to <c>true</c> to support cookies when crawling the pages
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("support_cookies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportCookies { get; set; }

        /// <summary>
        /// language header for accessing the website
        /// <br/>optional field
        /// <br/>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
        /// <br/>Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the <c>'type':'broken</c> in the response array
        /// </summary>
        [JsonProperty("accept_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// custom robots.txt settings
        /// <br/>optional field
        /// <br/>example: <c>Disallow: /directory1/</c>
        /// </summary>
        [JsonProperty("custom_robots_txt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomRobotsTxt { get; set; }

        /// <summary>
        /// merge with or override robots.txt settings
        /// <br/>optional field
        /// <br/>possible values: <c>merge</c>, <c>override</c>;
        /// <br/>set to <c>override</c> if you want to ignore website crawling restrictions and other robots.txt settings
        /// <br/>default value: <c>merge</c>;
        /// <br/>Note: if set to <c>override</c>, specify the <c>custom_robots_txt</c> parameter
        /// </summary>
        [JsonProperty("robots_txt_merge_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RobotsTxtMergeMode { get; set; }

        /// <summary>
        /// custom user agent
        /// <br/>optional field
        /// <br/>custom user agent for crawling a website
        /// <br/>example: <c>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36</c>
        /// <br/>default value: <c>Mozilla/5.0 (compatible; RSiteAuditor)</c>
        /// </summary>
        [JsonProperty("custom_user_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomUserAgent { get; set; }

        /// <summary>
        /// preset for browser screen parameters
        /// <br/>optional field
        /// <br/>if you use this field, you don't need to indicate <c>browser_screen_width</c>, <c>browser_screen_height</c>, <c>browser_screen_scale_factor</c>possible values:
        /// <br/><c>desktop</c>, <c>mobile</c>, <c>tablet</c><c>desktop</c> preset will apply the following values:<c>browser_screen_width: 1920</c>
        /// <br/><c>browser_screen_height: 1080</c>
        /// <br/><c>browser_screen_scale_factor: 1</c><c>mobile</c> preset will apply the following values:<c>browser_screen_width: 390</c>
        /// <br/><c>browser_screen_height: 844</c>
        /// <br/><c>browser_screen_scale_factor: 3</c><c>tablet</c> preset will apply the following values:<c>browser_screen_width: 1024</c>
        /// <br/><c>browser_screen_height: 1366</c>
        /// <br/><c>browser_screen_scale_factor: 2</c>
        /// <br/>Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>
        /// </summary>
        [JsonProperty("browser_preset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BrowserPreset { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>minimum value, in pixels: <c>240</c>
        /// <br/>maximum value, in pixels: <c>9999</c>
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to perform an audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>minimum value, in pixels: <c>240</c>
        /// <br/>maximum value, in pixels: <c>9999</c>
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen scale factor
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to perform audit for a particular device;
        /// <br/>if you use this field, you don't need to indicate <c>browser_preset</c> as it will be ignored;
        /// <br/>Note: to use this parameter, set <c>enable_javascript</c> or <c>enable_browser_rendering</c> to <c>true</c>minimum value: <c>0.5</c>
        /// <br/>maximum value: <c>3</c>
        /// </summary>
        [JsonProperty("browser_screen_scale_factor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BrowserScreenScaleFactor { get; set; }

        /// <summary>
        /// respect sitemap when crawling
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to follow the order of pages indicated in the primary sitemap when crawling;
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if set to <c>true</c>, the <c>click_depth</c> value in the API response will equal <c>0</c>;
        /// <br/>the <c>max_crawl_depth</c> field of the request will be ignored, you can specify the number of pages to crawl using the <c>max_crawl_pages</c> parameter
        /// </summary>
        [JsonProperty("respect_sitemap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RespectSitemap { get; set; }

        /// <summary>
        /// custom sitemap url
        /// <br/>optional field
        /// <br/>the URL of the page where the alternative sitemap is located
        /// <br/>Note: if you want to use this parameter, <c>respect_sitemap</c> should be <c>true</c>
        /// </summary>
        [JsonProperty("custom_sitemap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomSitemap { get; set; }

        /// <summary>
        /// crawl only pages indicated in the sitemap
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to crawl only the pages indicated in the sitemap
        /// <br/>if you set this parameter to <c>true</c> and do not specify <c>custom_sitemap</c>, we will crawl the default sitemap
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if you want to use this parameter, <c>respect_sitemap</c> should be <c>true</c>
        /// </summary>
        [JsonProperty("crawl_sitemap_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CrawlSitemapOnly { get; set; }

        /// <summary>
        /// load resources
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to load image, stylesheets, scripts, and broken resources
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter <see href="https://dataforseo.com/help-center/cost-of-onpage-api-parameters">in our help article</see>; the cost can be calculated on the <see href="https://dataforseo.com/pricing/on-page/onpage-api">Pricing Page</see>
        /// </summary>
        [JsonProperty("load_resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadResources { get; set; }

        /// <summary>
        /// check if the domain implemented the www redirection
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to check if the requested domain implemented the www to non-www or non-www to www redirect;
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("enable_www_redirect_check", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWwwRedirectCheck { get; set; }

        /// <summary>
        /// load javascript on a page
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to load the scripts available on a page
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter <see href="https://dataforseo.com/help-center/cost-of-onpage-api-parameters">in our help article</see>; the cost can be calculated on the <see href="https://dataforseo.com/pricing/on-page/onpage-api">Pricing Page</see>
        /// </summary>
        [JsonProperty("enable_javascript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableJavascript { get; set; }

        /// <summary>
        /// enable XMLHttpRequest on a page
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want our crawler to request data from a web server using the XMLHttpRequest object
        /// <br/>default value: <c>false</c>;if you use this field, <c>enable_javascript</c> must be set to <c>true</c>;
        /// </summary>
        [JsonProperty("enable_xhr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableXhr { get; set; }

        /// <summary>
        /// emulate browser rendering to measure Core Web Vitals
        /// <br/>optional field
        /// <br/>by using this parameter you will be able to emulate a browser when loading a web page;
        /// <br/><c>enable_browser_rendering</c> loads styles, images, fonts, animations, videos, and other resources on a page;
        /// <br/>default value: <c>false</c>
        /// <br/>set to <c>true</c> to obtain Core Web Vitals (FID, CLS, LCP) metrics in the response;
        /// <br/>if you use this field, <c>enable_javascript</c>, and <c>load_resources</c> parameters must be set to <c>true</c>
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter <see href="https://dataforseo.com/help-center/cost-of-onpage-api-parameters">in our help article</see>; the cost can be calculated on the <see href="https://dataforseo.com/pricing/on-page/onpage-api">Pricing Page</see>
        /// </summary>
        [JsonProperty("enable_browser_rendering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBrowserRendering { get; set; }

        /// <summary>
        /// disable the cookie popup
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to disable the popup requesting cookie consent from the user;
        /// <br/>default value:
        /// <br/><c>false</c>
        /// </summary>
        [JsonProperty("disable_cookie_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableCookiePopup { get; set; }

        /// <summary>
        /// custom javascript
        /// <br/>optional field
        /// <br/>Note: that the execution time for the script you enter here should be 700 ms maximum, for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a <c>scr</c> attribute:
        /// <br/><c>let meta = { haveGoogleAnalytics: false, haveTagManager: false };rnfor (var i = 0; i = 0)rn      meta.haveGoogleAnalytics = true;rntif (src.indexOf('gtm.js') &gt;= 0)rn      meta.haveTagManager = true;rn  }rn}rnmeta;</c>the returned value depends on what you specified in this field. For instance, if you specify the following script:
        /// <br/>`meta = {}; meta.url = document.URL; meta.test = 'test'; meta;`
        /// <br/>as a response you will receive the following data:
        /// <br/>`'custom_js_response': {
        /// <br/>'url': 'https://dataforseo.com/',
        /// <br/>'test': 'test'
        /// <br/>}`
        /// <br/>Note #2: the length of the script you enter must be no more than 2000 characters
        /// <br/>Note #3: the serialized script response must be no more than 100000 characters. If it exceeds this limit, both `custom_js_response` and `custom_js_client_exception` will contain the following message: `your response was truncated because greater than 100000 symbols`
        /// </summary>
        [JsonProperty("custom_js", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomJs { get; set; }

        /// <summary>
        /// enable microdata validation
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to use the <see href="/v3/on_page/microdata/">OnPage API Microdata endpoint</see>
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("validate_micromarkup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateMicromarkup { get; set; }

        /// <summary>
        /// include pages on subdomains
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to crawl all subdomains of a target website
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("allow_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSubdomains { get; set; }

        /// <summary>
        /// subdomains to crawl
        /// <br/>optional field
        /// <br/>specify subdomains that you want to crawl
        /// <br/>example: <c>['blog.site.com', 'my.site.com', 'shop.site.com']</c>
        /// <br/>Note: to use this parameter, the <c>allow_subdomains</c> parameter should be set to <c>false</c>;
        /// <br/>otherwise, the content of <c>allowed_subdomains</c> field will be ignored and the results will be returned for all subdomains
        /// </summary>
        [JsonProperty("allowed_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AllowedSubdomains { get; set; }

        /// <summary>
        /// subdomains not to crawl
        /// <br/>optional field
        /// <br/>specify subdomains that you don't want to crawl
        /// <br/>example: <c>['status.site.com', 'docs.site.com']</c>
        /// <br/>Note: to use this parameter, the <c>allow_subdomains</c> parameter should be set to <c>true</c>
        /// </summary>
        [JsonProperty("disallowed_subdomains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DisallowedSubdomains { get; set; }

        /// <summary>
        /// check spelling
        /// <br/>optional field
        /// <br/>set to <c>true</c> to check spelling on a website using <see href="http://hunspell.github.io/">Hunspell</see> library
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("check_spell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckSpell { get; set; }

        /// <summary>
        /// language of the spell check
        /// <br/>optional field
        /// <br/>supported languages: 'hy', 'eu', 'bg', 'ca', 'hr', 'cs', 'da', 'nl', 'en', 'eo', 'et', 'fo', 'fa', 'fr', 'fy', 'gl', 'ka', 'de', 'el', 'he', 'hu', 'is', 'ia', 'ga', 'it', 'rw', 'la', 'lv', 'lt', 'mk', 'mn', 'ne', 'nb', 'nn', 'pl', 'pt', 'ro', 'gd', 'sr', 'sk', 'sl', 'es', 'sv', 'tr', 'tk', 'uk', 'vi'
        /// <br/>Note: if no language is specified, it will be set automatically based on page content
        /// </summary>
        [JsonProperty("check_spell_language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CheckSpellLanguage { get; set; }

        /// <summary>
        /// words excluded from spell check
        /// <br/>optional field
        /// <br/>specify the words that you want to exclude from spell check
        /// <br/>maximum word length: 100 characters
        /// <br/>maximum amount of words: 1000
        /// <br/>example: <c>'SERP', 'minifiers', 'JavaScript'</c>
        /// </summary>
        [JsonProperty("check_spell_exceptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> CheckSpellExceptions { get; set; }

        /// <summary>
        /// calculate keyword density for the target domain
        /// <br/>optional field
        /// <br/>set to <c>true</c> if you want to calculate keyword density for website pages
        /// <br/>default value: <c>false</c>
        /// <br/>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter <see href="https://dataforseo.com/help-center/cost-of-onpage-api-parameters">in our help article</see>
        /// <br/>once the crawl is completed, you can obtain keyword density values with <see href="/v3/on_page/keyword_density?bash">the Keyword Density endpoint</see>
        /// </summary>
        [JsonProperty("calculate_keyword_density", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CalculateKeywordDensity { get; set; }

        /// <summary>
        /// custom threshold values for checks
        /// <br/>optional field
        /// <br/>you can specify custom threshold values for the parameters included in the <c>checks</c> object of OnPage API responses;
        /// <br/>Note: only integer threshold values can be modified;
        /// <br/>for example, the <c>high_loading_time</c> and <c>large_page_size</c> parameters are set to 3 seconds and 1 megabyte respectively by default;
        /// <br/>if you want to change these thresholds to 1 second and 1000 kbytes, use the following snippet:
        /// <br/>`'checks_threshold': {
        /// <br/>'high_loading_time': 1,
        /// <br/>'large_page_size': 1000
        /// <br/>}`
        /// <br/>available customizable parameters with default values:
        /// <br/>`'title_too_short', default value: 30, type: 'int'
        /// <br/>'title_too_long', default value: 65, type: 'int'
        /// <br/>'small_page_size', default value: 1024, type: 'int'
        /// <br/>'large_page_size', default value: 1048576 (1024 * 1024), type: 'int'
        /// <br/>'low_character_count', default value: 1024, type: 'int'
        /// <br/>'high_character_count', default value: 256000 (250 * 1024), type: 'int'
        /// <br/>'low_content_rate', default value: 0.1, type: 'float'
        /// <br/>'high_content_rate', default value: 0.9, type: 'float'
        /// <br/>'high_loading_time', default value: 3000, type: 'int'
        /// <br/>'high_waiting_time', default value: 1500, type: 'int'
        /// <br/>'low_readability_rate', default value: 15.0, type: 'float'
        /// <br/>'irrelevant_description', default value: 0.2, type: 'float'
        /// <br/>'irrelevant_title', default value: 0.3, type: 'float'
        /// <br/>'irrelevant_meta_keywords', default value: 0.6, type: 'float'`
        /// </summary>
        [JsonProperty("checks_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, long?> ChecksThreshold { get; set; }

        /// <summary>
        /// prevent certain sitewide checks from running
        /// <br/>optional field
        /// <br/>specify the following <c>checks</c> to prevent them from running on the <c>target</c> website:
        /// <br/><c>'test_page_not_found'</c>
        /// <br/><c>'test_canonicalization'</c>
        /// <br/><c>'test_https_redirect'</c>
        /// <br/><c>'test_directory_browsing'</c>example:
        /// <br/><c>'disable_sitewide_checks': ['test_directory_browsing', 'test_page_not_found']</c>learn more on <see href="https://dataforseo.com/help-center/how-to-disable-sitewide-checks-in-onpage-api">our help center</see>
        /// </summary>
        [JsonProperty("disable_sitewide_checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DisableSitewideChecks { get; set; }

        /// <summary>
        /// prevent certain page checks from running
        /// <br/>optional field
        /// <br/>specify certain <c>checks</c> to prevent them from running and impacting the <c>onpage_score</c>example:
        /// <br/><c>'disable_page_checks': ['is_5xx_code', 'is_4xx_code']</c>
        /// </summary>
        [JsonProperty("disable_page_checks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> DisablePageChecks { get; set; }

        /// <summary>
        /// switch proxy pool
        /// <br/>optional field
        /// <br/>if <c>true</c>, additional proxy pools will be used to obtain the requested data;
        /// <br/>the parameter can be used if a multitude of tasks is set simultaneously, resulting in occasional <c>rate-limit</c> and/or <c>site_unreachable</c> errors
        /// </summary>
        [JsonProperty("switch_pool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchPool { get; set; }

        /// <summary>
        /// return data on pages despite the timeout error
        /// <br/>optional field
        /// <br/>if <c>true</c>, the data will be provided on pages that failed to load within 120 seconds and responded with a timeout error;
        /// <br/>default value: <c>false</c>
        /// </summary>
        [JsonProperty("return_despite_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnDespiteTimeout { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a <c>$id</c> variable and ‘$tag’ as urlencoded <c>$tag</c> variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/><c>http://your-server.com/pingscript?id=$id</c>
        /// <br/><c>http://your-server.com/pingscript?id=$id&amp;tag=$tag</c>
        /// <br/>Note: special characters in <c>pingback_url</c> will be urlencoded;
        /// <br/>i.a., the <c>#</c> character will be encoded into <c>%23</c>
        /// <br/>learn more on our <see href="https://dataforseo.com/help-center/pingbacks-postbacks-with-dataforseo-api">Help Center</see>
        /// </summary>
        [JsonProperty("pingback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}