using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class OnPageLighthouseTaskPostRequestInfo 
    {

        /// <summary>
        /// target URL
        /// <br/>required field
        /// <br/>target page should be specified with its absolute URL (including http:// or https://)
        /// <br/>example:
        /// <br/>https://dataforseo.com/
        /// </summary>
        [JsonProperty("url", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// applies mobile emulation
        /// <br/>optional field
        /// <br/>if set to true, Lighthouse will use mobile device and screen emulation to test the page against mobile environment
        /// <br/>if set to false, the results will be provided for desktop
        /// <br/>default value: false
        /// </summary>
        [JsonProperty("for_mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForMobile { get; set; }

        /// <summary>
        /// categories of Lighthouse audits
        /// <br/>optional field
        /// <br/>each category is a collection of audits and audit groups that applies weighting and scoring to the section (see official definition)
        /// <br/>if you ignore this field, we will return data for all categories unless you specify audits
        /// <br/>use this field to get data for specific categories you indicate here
        /// <br/>possible values:
        /// <br/>seo, pwa, performance, best_practices, accessibility
        /// </summary>
        [JsonProperty("categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Lighthouse audits
        /// <br/>optional field
        /// <br/>audits are individual tests Lighthouse runs for each specific feature/optimization/metric to produce a numeric score (see official definition)  
        /// <br/>if you ignore this field, we will return data for all audits
        /// <br/>use this field to get data for specific audits you indicate here
        /// <br/>note that some audits do not belong to a specific category and are stand-alone page quality measurements
        /// <br/>in general, there can be several use cases:
        /// <br/>1. if you ignore categories, you can use this field to get data for the specified audits only
        /// <br/>for example, if you ignore 'categories' and specify 'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time'], you will get data only for these audits
        /// <br/>2. if you specify a category, you can use this field to additionally receive audits that do not belong to the category(-ies) you specified
        /// <br/>for example, if you specify 'categories': ['seo'] and 'audits': ['metrics/cumulative-layout-shift','metrics/largest-contentful-paint','metrics/total-blocking-time'], you will get only these audits under “performance” and all audits under “seo”
        /// <br/>you can get the full list of possible audits here
        /// </summary>
        [JsonProperty("audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Audits { get; set; }

        /// <summary>
        /// lighthouse version
        /// <br/>optional field
        /// <br/>you can obtain the results specific to a certain Lighthouse version by specifying its number
        /// <br/>the list of available versions is available through the Lighthouse Versions endpoint
        /// </summary>
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// lighthouse language name
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_name by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languages
        /// <br/>default value:
        /// <br/>English
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// lighthouse language code
        /// <br/>optional field
        /// <br/>you can receive the list of available languages of the search engine with their language_code by making a separate request to https://api.dataforseo.com/v3/on_page/lighthouse/languages
        /// <br/>default value:
        /// <br/>en
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [JsonProperty("tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// notification URL of a completed task
        /// <br/>optional field
        /// <br/>when a task is completed we will notify you by GET request sent to the URL you have specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/>http://your-server.com/pingscript?id=$id
        /// <br/>http://your-server.com/pingscript?id=$id&amp;tag=$tag
        /// <br/>Note: special characters in pingback_url will be urlencoded;
        /// <br/>i.a., the # character will be encoded into %23
        /// <br/>learn more on our Help Center
        /// </summary>
        [JsonProperty("pingback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PingbackUrl { get; set; }

        /// <summary>
        /// return URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request
        /// <br/>example:
        /// <br/>http://your-server.com/postbackscript?id=$id
        /// <br/>http://your-server.com/postbackscript?id=$id&amp;tag=$tag
        /// <br/>Note: special characters in postback_url will be urlencoded;
        /// <br/>i.a., the # character will be encoded into %23
        /// <br/>learn more on our Help Center
        /// </summary>
        [JsonProperty("postback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}