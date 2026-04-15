using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpGoogleOrganicLiveRegularRequestInfo 
    {

        /// <summary>
        /// keywordrequired fieldyou can specify up to 700 characters in the keyword fieldall %## will be decoded (plus character '+' will be decoded to a space character)if you need to use the '%' character for your keyword, please specify it as '%25';if you need to use the “+” character for your keyword, please specify it as “%2B”;if this field contains such parameters as 'allinanchor:', 'allintext:', 'allintitle:', 'allinurl:', 'define:', 'filetype:', 'id:', 'inanchor:', 'info:', 'intext:', 'intitle:', 'inurl:', 'link:', 'site:', the charge per task will be multiplied by 5Note: queries containing the ‘cache:’ parameter are not supported and will return a validation error
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// search engine location coderequired field if you don't specify location_name or location_coordinateif you use this field, you don't need to specify location_name or location_coordinateyou can receive the list of available locations of the search engines with their location_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/locationsexample:2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// search engine language coderequired field if you don't specify language_nameif you use this field, you don't need to specify language_nameyou can receive the list of available languages of the search engine with their language_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/languagesexample:en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// parsing depthoptional fieldnumber of results in SERPdefault value: 10max value: 200Your account will be billed per each SERP containing up to 10 results;Setting depth above 10 may result in additional charges if the search engine returns more than 10 results;The cost can be calculated on the Pricing page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// device typeoptional fieldreturn results for a specific device typecan take the values:desktop, mobiledefault value: desktop
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// full name of search engine locationrequired field if you don't specify location_code or location_coordinateif you use this field, you don't need to specify location_code or location_coordinateyou can receive the list of available locations of the search engine with their location_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/locationsexample:London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// full name of search engine languagerequired field if you don't specify language_codeif you use this field, you don't need to specify language_codeyou can receive the list of available languages of the search engine with their language_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/languagesexample:English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// device operating systemoptional fieldif you specify desktop in the device field, choose from the following values: windows, macosdefault value: windowsif you specify mobile in the device field, choose from the following values: android, iosdefault value: android
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response
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
        /// target match typerequired field if stop_crawl_on_match is specifiedtype of match for the match_valuepossible values:domain – specific domain or subdomainwith_subdomains – main domain and subdomainswildcard –  wildcard pattern
        /// </summary>
        [JsonProperty("match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// target domain, subdomain, or wildcard valuerequired field if stop_crawl_on_match is specifiedspecify a target domain, subdomain, or wildcard value;Note: domain or subdomain must be specified without a request protocol;example: 'match_value': 'dataforseo.com','match_value': '/blog/post-*'
        /// </summary>
        [JsonProperty("match_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MatchValue { get; set; }

        /// <summary>
        /// page crawl limitoptional fieldnumber of search results pages to crawlmax value: 100Note: you will be charged for each page crawled (10 organic results per page);learn more about pricing on our Pricing page;Note#2: the max_crawl_pages and depth parameters complement each other;learn more at our help center
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// additional parameters of the search queryoptional fieldget the list of available parameters and additional details here
        /// </summary>
        [JsonProperty("search_param", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchParam { get; set; }

        /// <summary>
        /// display related resultsoptional fieldif set to true, the related_result element in the response will be provided as a snippet of its parent organic result;if set to false, the related_result element will be provided as a separate organic result;default value: true
        /// </summary>
        [JsonProperty("group_organic_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupOrganicResults { get; set; }

        /// <summary>
        /// direct URL of the search queryoptional fieldyou can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn’t recommend using this method.example:https://www.google.co.uk/search?q=%20rank%20tracker%20api&amp;hl=en&amp;gl=GB&amp;uule=w+CAIQIFISCXXeIa8LoNhHEZkq1d1aOpZS
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// GPS coordinates of a locationrequired field if you don't specify location_name or location_codeif you use this field, you don't need to specify location_name or location_codelocation_coordinate parameter should be specified in the 'latitude,longitude,radius' formatthe maximum number of decimal digits for 'latitude' and 'longitude': 7the minimum value for 'radius': 199 (mm)the maximum value for 'radius': 199999 (mm)example:53.476225,-2.243572,200
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// search engine domainoptional fieldwe choose the relevant search engine domain automatically according to the location and language you specifyhowever, you can set a custom search engine domain in this fieldexample:google.co.uk, google.com.au, google.de, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// target domain, subdomain, or webpage to get results foroptional fielda domain or a subdomain should be specified without https:// and www.note that the results of target-specific tasks will only include SERP elements that contain a url string;you can also use a wildcard (‘*’) character to specify the search pattern in SERP and narrow down the results;examples:example.com  - returns results for the website's home page with URLs, such as https://example.com, or https://www.example.com/, or https://example.com/;example.com* - returns results for the domain, including all its pages;*example.com* - returns results for the entire domain, including all its pages and subdomains;*example.com  - returns results for the home page regardless of the subdomain, such as https://en.example.com;example.com/example-page  - returns results for the exact URL;example.com/example-page*  - returns results for all domain's URLs that start with the specified string
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// target matching modeoptional fieldto enable this parameter, stop_crawl_on_match must also be enableddefines how the crawl should stop when multiple targets are specified in stop_crawl_on_matchpossible values: all, anyall – the crawl stops only when all specified targets are foundany – the crawl stops when any single target is founddefault value: anylearn more about this parameter on our Help Center
        /// </summary>
        [JsonProperty("target_search_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSearchMode { get; set; }

        /// <summary>
        /// SERP element types to check for targetsoptional fieldto enable this parameter, stop_crawl_on_match must also be enabledspecifies which SERP element types should be checked for target matchesif not specified, all first-level elements with url and domain fields are checked for targetspossible values: organic, paid, local_pack, featured_snippet, events, google_flights, images, jobs, knowledge_graph, local_service, map, scholarly_articles, third_party_reviews, twitterNote: cannot contain the same element types as ignore_targets_inexample:'find_targets_in': ['organic', 'featured_snippet']learn more about this parameter on our Help Center
        /// </summary>
        [JsonProperty("find_targets_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> FindTargetsIn { get; set; }

        /// <summary>
        /// SERP element types to exclude from target searchoptional fieldto enable this parameter, stop_crawl_on_match must also be enabledspecifies which SERP element types should be excluded when searching for target matchespossible values: organic, paid, local_pack, featured_snippet, events, google_flights, images, jobs, knowledge_graph, local_service, map, scholarly_articles, third_party_reviews, twitterNote: cannot contain the same element types as find_targets_inexample:'ignore_targets_in': ['paid', 'images']learn more about this parameter on our Help Center
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