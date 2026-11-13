using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class SerpYahooOrganicLiveAdvancedRequestInfo 
    {

        /// <summary>
        /// direct URL of the search queryoptional fieldyou can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn’t recommend using this method.example:https://search.yahoo.com/search?p=rank+checker&amp;n=100&amp;vl=lang_en&amp;vc=us&amp;ei=UTF-8
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// keywordrequired fieldyou can specify up to 700 characters in the keyword fieldall %## will be decoded (plus character '+' will be decoded to a space character)if you need to use the '%' character for your keyword, please specify it as '%25';if you need to use the “+” character for your keyword, please specify it as “%2B”learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// full name of search engine locationrequired field if you don't specify location_code or location_coordinateif you use this field, you don't need to specify location_code or location_coordinateyou can receive the list of available locations of the search engine with their location_name by making a separate request to the https://api.dataforseo.com/v3/serp/yahoo/locationsexample:London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location coderequired field if you don't specify location_name_or location_coordinateif you use this field, you don't need to specify location_name or location_coordinateyou can receive the list of available locations of the search engines with their location_code by making a separate request to the https://api.dataforseo.com/v3/serp/yahoo/locationsexample:2840n
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a locationrequired field if you don't specify location_name_or location_codeif you use this field, you don't need to specify location_name or location_codelocation_coordinate parameter should be specified in the 'latitude,longitude,radius' formatthe maximum number of decimal digits for 'latitude' and 'longitude': 7the minimum value for 'radius': 199.9 (mm)the maximum value for 'radius': 199999 (mm)example:53.476225,-2.243572,200n
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine languagerequired field if you don't specify language_codeif you use this field, you don't need to specify language_codeyou can receive the list of available languages of the search engine with their language_name by making a separate request to the https://api.dataforseo.com/v3/serp/yahoo/languagesexample:English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language coderequired field if you don't specify language_nameif you use this field, you don't need to specify language_nameyou can receive the list of available languages of the search engine with their language_code_by making a separate request to the https://api.dataforseo.com/v3/serp/yahoo/languagesexample:enn
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// device typeoptional fieldreturn results for a specific device typecan take the values:desktop, mobiledefault value: desktop
        /// </summary>
        [JsonProperty("device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// device operating systemoptional fieldif you specify desktop in the device field, choose from the following values: windows, macosdefault value: windowsif you specify mobile in the device field, choose from the following values: android, iosdefault value: android
        /// </summary>
        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// search engine domainoptional fieldwe choose the relevant search engine domain automatically according to the location and language you specifyhowever, you can set a custom search engine domain in this fieldexample:au.search.yahoo.com, uk.search.yahoo.com, ca.search.yahoo.com, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// parsing depthoptional fieldnumber of results in SERPdefault value: 6max value: 200Your account will be billed per each SERP; Each Yahoo SERP can contain fewer than 10 results, so setting depth above the default value may result in additional charges ;The cost can be calculated on the Pricing page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// page crawl limitoptional fieldnumber of search results pages to crawldefault value: 1max value: 100Note: the max_crawl_pages and depth parameters complement each other;learn more at our help center
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// target domain, subdomain, or webpage to get results foroptional fielda domain or a subdomain should be specified without https:// and www.note that the results of target-specific tasks will only include SERP elements that contain a url string;you can also use a wildcard (‘’) character to specify the search pattern in SERP and narrow down the results;examples:example.com  - returns results for the website's home page with URLs, such as https://example.com, or https://www.example.com/, or https://example.com/;example.com - returns results for the domain, including all its pages;example.com - returns results for the entire domain, including all its pages and subdomains;example.com  - returns results for the home page regardless of the subdomain, such as https://en.example.com; example.com/example-page  - returns results for the exact URL;example.com/example-page  - returns results for all domain's URLs that start with the specified string
        /// </summary>
        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// additional parameters of the search queryoptional fieldget the list of available parameters and additional details here
        /// </summary>
        [JsonProperty("search_param", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchParam { get; set; }

        /// <summary>
        /// user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response
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