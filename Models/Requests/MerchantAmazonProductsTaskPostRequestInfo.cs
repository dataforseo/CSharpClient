using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class MerchantAmazonProductsTaskPostRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in this field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your keyword, please specify it as “%25”;
        /// <br/>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// direct URL of the search query
        /// <br/>optional field
        /// <br/>you can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn’t recommend using this method.
        /// <br/>example:
        /// <br/>https://www.amazon.com/s/?field-keywords=shoes&amp;language=en_US
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priority
        /// <br/>You will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the Pricing page.
        /// </summary>
        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations with their location_name parameters by making a separate request to the https://api.dataforseo.com/v3/merchant/amazon/locations
        /// <br/>example:
        /// <br/>HA1,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations with their location_code parameters by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/merchant/amazon/locations
        /// <br/>example:
        /// <br/>9045969
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don’t specify location_name or location_code
        /// <br/>if you use this field, you don’t need to specify location_name or location_code
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude,radius” format
        /// <br/>the maximum number of decimal digits for “latitude” and “longitude”: 7
        /// <br/>the minimum value for “radius”: 199.9
        /// <br/>example:
        /// <br/>53.476225,-2.243572,200
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don’t specify language_code
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages with their language_name parameters by making a separate request to the
        /// <br/>https://api.dataforseo.com/v3/merchant/amazon/languages
        /// <br/>example:
        /// <br/>English (United Kingdom)
        /// </summary>
        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages with their language_code parameters by making a separate request to the https://api.dataforseo.com/v3/merchant/amazon/languages
        /// <br/>example:
        /// <br/>en_GB
        /// </summary>
        [JsonProperty("language_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search engine domain
        /// <br/>optional field
        /// <br/>we choose the relevant search engine domain automatically according to the location and language you specify
        /// <br/>however, you can set a custom search engine domain in this field
        /// <br/>example:
        /// <br/>amazon.com, amazon.co.uk, amazon.fr, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results to be retrieved from the Amazon results page
        /// <br/>default value: 100
        /// <br/>max value: 700
        /// <br/>Your account will be billed per each SERP containing up to 100 results;
        /// <br/>Setting depth above 100 may result in additional charges if the search engine returns more than 100 results;
        /// <br/>The cost can be calculated on the Pricing page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// page crawl limit
        /// <br/>optional field
        /// <br/>number of search results pages to crawl
        /// <br/>max value: 7
        /// <br/>Note: the max_crawl_pages and depth parameters complement each other;
        /// <br/>learn more at our help center
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// amazon product department
        /// <br/>optional field
        /// <br/>specify one of the following amazon departments for extracting product listings:
        /// <br/>'Arts &amp; Crafts', 'Automotive', 'Baby', 'Beauty &amp; Personal Care', 'Books', 'Computers', 'Digital Music', 'Electronics', 'Kindle Store', 'Prime Video', 'Women's Fashion', 'Men's Fashion', 'Girls' Fashion', 'Boys' Fashion', 'Deals', 'Health &amp; Household', 'Home &amp; Kitchen', 'Industrial &amp; Scientific', 'Luggage', 'Movies &amp; TV', 'Music, CDs &amp; Vinyl', 'Pet Supplies', 'Software', 'Sports &amp; Outdoors', 'Tools &amp; Home Improvement', 'Toys &amp; Games', 'Video Games'
        /// </summary>
        [JsonProperty("department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Department { get; set; }

        /// <summary>
        /// additional parameters of the search query
        /// <br/>optional field
        /// <br/>you can use the following Amazon search URL parameters for customizing the search
        /// <br/>example:
        /// <br/>&amp;low-price=52 – search for products that cost more than 52 USD;
        /// <br/>&amp;high-price=45 – search for products that cost less than 45 USD;
        /// <br/>&amp;sort=relevancerank – sort results by relevance;
        /// <br/>&amp;sort=featured-rank – sort results by featured products;
        /// <br/>&amp;sort=price-asc-rank – sort by ascending price;
        /// <br/>&amp;sort=price-desc-rank – sort by descending price;
        /// <br/>&amp;sort=review-rank – sort by the average customer reviews value;
        /// <br/>&amp;sort=date-desc-rank – sort by the newest arrival
        /// <br/>Note that search_param values will be ignored if any of the following parameters is used: price_min, price_max, sort_by
        /// </summary>
        [JsonProperty("search_param", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchParam { get; set; }

        /// <summary>
        /// minimum product price
        /// <br/>optional field
        /// <br/>minimum price of the returned products listed on Amazon for the specified query
        /// <br/>example:
        /// <br/>5
        /// <br/>Note: if you specify price_min, the search_param parameter will be ignored
        /// </summary>
        [JsonProperty("price_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMin { get; set; }

        /// <summary>
        /// maximum product price
        /// <br/>optional field
        /// <br/>maximum price of the returned products listed on Amazon for the specified query
        /// <br/>example:
        /// <br/>100
        /// <br/>Note: if you specify price_max, the search_param parameter will be ignored
        /// </summary>
        [JsonProperty("price_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMax { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>the following sorting rules are supported:
        /// <br/>relevance, price_low_to_high, price_high_to_low, featured, avg_customer_review, newest_arrival
        /// <br/>example:
        /// <br/>sort_by:'relevance'
        /// <br/>Note: if you specify sort_by, the search_param parameter will be ignored
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

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
        /// return URL for sending task results
        /// <br/>optional field
        /// <br/>once the task is completed, we will send a POST request with its results compressed in the gzip format to the postback_url you specified
        /// <br/>you can use the ‘$id’ string as a $id variable and ‘$tag’ as urlencoded $tag variable. We will set the necessary values before sending the request.
        /// <br/>example:
        /// <br/>http://your-server.com/postbackscript?id=$id
        /// <br/>http://your-server.com/postbackscript?id=$id&amp;tag=$tag
        /// <br/>Note: special characters in postback_url will be urlencoded;
        /// <br/>i.a., the # character will be encoded into %23
        /// <br/>learn more on our Help Center
        /// </summary>
        [JsonProperty("postback_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// postback_url datatype
        /// <br/>required field if you specify postback_url
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible values:
        /// <br/>advanced, html
        /// </summary>
        [JsonProperty("postback_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PostbackData { get; set; }

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

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}