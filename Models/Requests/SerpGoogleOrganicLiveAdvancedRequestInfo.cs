using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleOrganicLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in the <c>keyword</c> field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”;
        /// <br/>if you need to use the “+” character for your <c>keyword</c>, please specify it as “%2B”;
        /// <br/>if this field contains such parameters as ‘allinanchor:’, ‘allintext:’, ‘allintitle:’, ‘allinurl:’, ‘cache:’, ‘define:’, ‘definition:’, ‘filetype:’, ‘id:’, ‘inanchor:’, ‘info:’, ‘intext:’, ‘intitle:’, ‘inurl:’, ‘link:’, ‘site:’, the charge per task will be multiplied by 5
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engines with their <c>location_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/locations</c>
        /// <br/>example:
        /// <br/><c>2840</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>optional field if you specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_code</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/languages</c>
        /// <br/>example:
        /// <br/><c>en</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in SERP
        /// <br/>default value: <c>10</c>
        /// <br/>max value: <c>200</c>
        /// <br/>Your account will be billed per each SERP containing up to 10 results;
        /// <br/>Setting depth above 10 may result in additional charges <see href="https://dataforseo.com/help-center/how-many-results-scraped">if the search engine returns more than 10 results</see>;
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/serp/google-organic-serp-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// device type
        /// <br/>optional field
        /// <br/>return results for a specific device type
        /// <br/>can take the values:<c>desktop</c>, <c>mobile</c>
        /// <br/>default value: <c>desktop</c>
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// load asynchronous ai overview
        /// <br/>optional field
        /// <br/>set to <c>true</c> to obtain <c>ai_overview</c> items is SERPs even if they are loaded asynchronously;
        /// <br/>if set to <c>false</c>, you will only obtain <c>ai_overview</c> items from cache;
        /// <br/>default value: <c>false</c>
        /// <br/>Note: you will be charged extra $0.002 for using this parameter;
        /// <br/>if the element is absent or contains <c>'asynchronous_ai_overview': false</c>, all extra charges will be returned to your account balance
        /// </summary>
        [JsonProperty("load_async_ai_overview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadAsyncAiOverview { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations of the search engine with their <c>location_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/locations</c>
        /// <br/>example:
        /// <br/><c>London,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>optional field if you specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages of the search engine with their <c>language_name</c> by making a separate request to the <c>https://api.dataforseo.com/v3/serp/google/languages</c>
        /// <br/>example:
        /// <br/><c>English</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// device operating system
        /// <br/>optional field
        /// <br/>if you specify <c>desktop</c> in the <c>device</c> field, choose from the following values: <c>windows</c>, <c>macos</c>
        /// <br/>default value: <c>windows</c>
        /// <br/>if you specify <c>mobile</c> in the <c>device</c> field, choose from the following values: <c>android</c>, <c>ios</c>
        /// <br/>default value: <c>android</c>
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

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
        /// array of targets to stop crawling
        /// <br/>optional field
        /// <br/>if specified, the response will contain SERP results up to and including the specified match_value;
        /// <br/>you can specify up to 10 target values in this array
        /// <br/>example:
        /// <br/>'stop_crawl_on_match':[{'match_value':'dataforseo.com','match_type':'with_subdomains'}]
        /// <br/>learn more about this parameter on our Help Center - https://dataforseo.com/help-center/using-the-stop_crawl_on_match-parameter-in-serp-api
        /// <br/>Your account will be billed per each SERP crawled through the specified targets
        /// </summary>
        [JsonProperty("stop_crawl_on_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SerpApiStopCrawlOnMatchInfo> StopCrawlOnMatch { get; set; }

        /// <summary>
        /// target match type
        /// <br/>required field if <c>stop_crawl_on_match</c> is specified
        /// <br/>type of match for the <c>match_value</c>
        /// <br/>possible values:
        /// <br/><c>domain</c> – specific domain or subdomain
        /// <br/><c>with_subdomains</c> – main domain and subdomains
        /// <br/><c>wildcard</c> –  wildcard pattern
        /// </summary>
        [JsonProperty("match_type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// target domain, subdomain, or wildcard value
        /// <br/>required field if <c>stop_crawl_on_match</c> is specified
        /// <br/>specify a target domain, subdomain, or wildcard value;
        /// <br/>Note: domain or subdomain must be specified without a request protocol;
        /// <br/>example: <c>'match_value': 'dataforseo.com'</c>,
        /// <br/><c>'match_value': '/blog/post-*'</c>
        /// </summary>
        [JsonProperty("match_value", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchValue { get; set; }

        /// <summary>
        /// page crawl limit
        /// <br/>optional field
        /// <br/>number of search results pages to crawl
        /// <br/>max value: <c>100</c>
        /// <br/>Note: you will be charged for each page crawled (10 organic results per page);
        /// <br/>learn more about pricing on our <see href="https://dataforseo.com/pricing/serp/google-organic-serp-api">Pricing</see> page;
        /// <br/>Note#2: the <c>max_crawl_pages</c> and <c>depth</c> parameters complement each other;
        /// <br/>learn more at <see href="https://dataforseo.com/help-center/what-is-max-crawl-pages-and-how-does-it-work">our help center</see>
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// additional parameters of the search query
        /// <br/>optional field
        /// <br/><see href="https://dataforseo.com/help-center/google-search-engine-parameters-and-how-to-use-them">get the list of available parameters and additional details here</see>
        /// <br/>Note: the following search engine parameters are not supported and will be automatically unset if specified: <c>lr</c>, <c>cr</c>, <c>as_qdr</c>, <c>as_sitesearch</c>, <c>as_occt</c>, <c>as_filetype</c>.
        /// </summary>
        [JsonProperty("search_param", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchParam { get; set; }

        /// <summary>
        /// remove specific parameters from URLs
        /// <br/>optional field
        /// <br/>using this field, you can specify up to 10 parameters to remove from URLs in the result
        /// <br/>example:
        /// <br/><c>'remove_from_url': ['srsltid']</c>
        /// <br/>Note: if the <c>target</c> field is specified, the specified URL parameters will be removed before the search
        /// </summary>
        [JsonProperty("remove_from_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> RemoveFromUrl { get; set; }

        /// <summary>
        /// clicks on the corresponding element
        /// <br/>optional field
        /// <br/>specify the click depth on the <c>people_also_ask</c> element to get additional <c>people_also_ask_element</c> items;
        /// <br/>Note your account will be billed $0.00015 extra for each click;
        /// <br/>if the element is absent or we perform fewer clicks than you specified, all extra charges will be returned to your account balance
        /// <br/>possible values: from <c>1</c> to <c>4</c>
        /// </summary>
        [JsonProperty("people_also_ask_click_depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PeopleAlsoAskClickDepth { get; set; }

        /// <summary>
        /// display related results
        /// <br/>optional field
        /// <br/>if set to <c>true</c>, the <c>related_result</c> element in the response will be provided as a snippet of its parent organic result;
        /// <br/>if set to <c>false</c>, the <c>related_result</c> element will be provided as a separate organic result;
        /// <br/>default value: <c>true</c>
        /// </summary>
        [JsonProperty("group_organic_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupOrganicResults { get; set; }

        /// <summary>
        /// calcualte pixel rankings for SERP elements in advanced results
        /// <br/>optional field
        /// <br/>pixel ranking refers to the distance between the result snippet and top left corner of the screen;
        /// <br/><see href="https://dataforseo.com/help-center/pixel-ranking-in-serp-api">Visit Help Center to learn more&gt;&gt;</see>
        /// <br/>by default, the parameter is set to <c>false</c>;
        /// <br/>Note: you will be charged extra $0.002 for using this parameter
        /// </summary>
        [JsonProperty("calculate_rectangles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CalculateRectangles { get; set; }

        /// <summary>
        /// browser screen width
        /// <br/>optional field
        /// <br/>you can set a custom browser screen width to calculate pixel rankings for a particular device;
        /// <br/>can be specified within the following range: <c>240-9999</c>;
        /// <br/>by default, the parameter is set to:
        /// <br/><c>1920</c> for <c>desktop</c>;
        /// <br/><c>360</c> for <c>mobile</c> on <c>android</c>;
        /// <br/><c>375</c> for <c>mobile</c> on <c>iOS</c>;
        /// <br/>Note: to use this parameter, set <c>calculate_rectangles</c> to <c>true</c>
        /// </summary>
        [JsonProperty("browser_screen_width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? BrowserScreenWidth { get; set; }

        /// <summary>
        /// browser screen height
        /// <br/>optional field
        /// <br/>you can set a custom browser screen height to calculate pixel rankings for a particular device;
        /// <br/>can be specified within the following range: <c>240-9999</c>;
        /// <br/>by default, the parameter is set to:
        /// <br/><c>1080</c> for <c>desktop</c>;
        /// <br/><c>640</c> for <c>mobile</c> on <c>android</c>;
        /// <br/><c>812</c> for <c>mobile</c> on <c>iOS</c>;
        /// <br/>Note: to use this parameter, set <c>calculate_rectangles</c> to <c>true</c>
        /// </summary>
        [JsonProperty("browser_screen_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenHeight { get; set; }

        /// <summary>
        /// browser screen resolution ratio
        /// <br/>optional field
        /// <br/>you can set a custom browser screen resolution ratio to calculate pixel rankings for a particular device;
        /// <br/>can be specified within the following range: <c>0.5-3</c>;
        /// <br/>by default, the parameter is set to:
        /// <br/><c>1</c> for <c>desktop</c>;
        /// <br/><c>3</c> for <c>mobile</c> on <c>android</c>;
        /// <br/><c>3</c> for <c>mobile</c> on <c>iOS</c>;
        /// <br/>Note: to use this parameter, set <c>calculate_rectangles</c> to <c>true</c>
        /// </summary>
        [JsonProperty("browser_screen_resolution_ratio", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BrowserScreenResolutionRatio { get; set; }

        /// <summary>
        /// direct URL of the search query
        /// <br/>optional field
        /// <br/>you can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn’t recommend using this method.
        /// <br/>example:
        /// <br/><c>https://www.google.co.uk/search?q=%20rank%20tracker%20api&amp;hl=en&amp;gl=GB&amp;uule=w+CAIQIFISCXXeIa8LoNhHEZkq1d1aOpZS</c>
        /// <br/>Note: the following search engine parameters are not supported and will be automatically unset if specified in the URL: <c>lr</c>, <c>cr</c>, <c>as_qdr</c>, <c>as_sitesearch</c>, <c>as_occt</c>, <c>as_filetype</c>.
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>optional field if you specify <c>location_name</c> or <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude,radius' format
        /// <br/>the maximum number of decimal digits for 'latitude' and 'longitude': 7
        /// <br/>the minimum value for 'radius': 199 (mm)
        /// <br/>the maximum value for 'radius': 199999 (mm)
        /// <br/>example:
        /// <br/><c>53.476225,-2.243572,200</c>
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// search engine domain
        /// <br/>optional field
        /// <br/>we choose the relevant search engine domain automatically according to the location and language you specify
        /// <br/>however, you can set a custom search engine domain in this field
        /// <br/>example:
        /// <br/>google.co.uk, <c></c>google.com.au, <c></c>google.de, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// target domain, subdomain, or webpage to get results for
        /// <br/>optional field
        /// <br/>a domain or a subdomain should be specified without <c>https://</c> and <c>www.</c>
        /// <br/>note that the results of <c>target</c>-specific tasks will only include SERP elements that contain a <c>url</c> string;
        /// <br/>you can also use a wildcard (‘*’) character to specify the search pattern in SERP and narrow down the results;
        /// <br/>examples:
        /// <br/><c>example.com</c> - returns results for the website's home page with URLs, such as <c>https://example.com</c>, or <c>https://www.example.com/</c>, or <c>https://example.com/</c>;
        /// <br/><c>example.com*</c> - returns results for the domain, including all its pages;
        /// <br/><c>*example.com*</c> - returns results for the entire domain, including all its pages and subdomains;
        /// <br/><c>*example.com</c> - returns results for the home page regardless of the subdomain, such as <c>https://en.example.com</c>;
        /// <br/><c>example.com/example-page</c> - returns results for the exact URL;
        /// <br/><c>example.com/example-page*</c> - returns results for all domain's URLs that start with the specified string
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// target matching mode
        /// <br/>optional field
        /// <br/>to enable this parameter, <c>stop_crawl_on_match</c> must also be enabled
        /// <br/>defines how the crawl should stop when multiple targets are specified in <c>stop_crawl_on_match</c>
        /// <br/>possible values: <c>all</c>, <c>any</c>
        /// <br/><c>all</c> – the crawl stops only when all specified targets are found
        /// <br/><c>any</c> – the crawl stops when any single target is found
        /// <br/>default value: <c>any</c>
        /// <br/>learn more about this parameter on our <see href="https://dataforseo.com/help-center/how-to-use-new-crawl-control-parameters-in-google-organic-serp-api">Help Center</see>
        /// </summary>
        [JsonProperty("target_search_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSearchMode { get; set; }

        /// <summary>
        /// SERP element types to check for targets
        /// <br/>optional field
        /// <br/>to enable this parameter, <c>stop_crawl_on_match</c> must also be enabled
        /// <br/>specifies which SERP element types should be checked for target matches
        /// <br/>if not specified, all first-level elements with <c>url</c> and <c>domain</c> fields are checked for targets
        /// <br/>possible values: <c>organic</c>, <c>paid</c>, <c>local_pack</c>, <c>featured_snippet</c>, <c>events</c>, <c>google_flights</c>, <c>images</c>, <c>jobs</c>, <c>knowledge_graph</c>, <c>local_service</c>, <c>map</c>, <c>scholarly_articles</c>, <c>third_party_reviews</c>, <c>twitter</c>
        /// <br/>Note: cannot contain the same element types as <c>ignore_targets_in</c>
        /// <br/>example:
        /// <br/><c>'find_targets_in': ['organic', 'featured_snippet']</c>
        /// <br/>learn more about this parameter on our <see href="https://dataforseo.com/help-center/how-to-use-new-crawl-control-parameters-in-google-organic-serp-api">Help Center</see>
        /// </summary>
        [JsonProperty("find_targets_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> FindTargetsIn { get; set; }

        /// <summary>
        /// SERP element types to exclude from target search
        /// <br/>optional field
        /// <br/>to enable this parameter, <c>stop_crawl_on_match</c> must also be enabled
        /// <br/>specifies which SERP element types should be excluded when searching for target matches
        /// <br/>possible values: <c>organic</c>, <c>paid</c>, <c>local_pack</c>, <c>featured_snippet</c>, <c>events</c>, <c>google_flights</c>, <c>images</c>, <c>jobs</c>, <c>knowledge_graph</c>, <c>local_service</c>, <c>map</c>, <c>scholarly_articles</c>, <c>third_party_reviews</c>, <c>twitter</c>
        /// <br/>Note: cannot contain the same element types as <c>find_targets_in</c>
        /// <br/>example:
        /// <br/><c>'ignore_targets_in': ['paid', 'images']</c>
        /// <br/>learn more about this parameter on our <see href="https://dataforseo.com/help-center/how-to-use-new-crawl-control-parameters-in-google-organic-serp-api">Help Center</see>
        /// </summary>
        [JsonProperty("ignore_targets_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> IgnoreTargetsIn { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}