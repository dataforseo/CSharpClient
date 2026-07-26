using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class MerchantAmazonProductsLiveHtmlRequestInfo 
    {

        /// <summary>
        /// keyword
        /// <br/>required field
        /// <br/>you can specify up to 700 characters in this field
        /// <br/>all %## will be decoded (plus character ‘+’ will be decoded to a space character)
        /// <br/>if you need to use the “%” character for your <c>keyword</c>, please specify it as “%25”;
        /// <br/>learn more about rules and limitations of <c>keyword</c> and <c>keywords</c> fields in DataForSEO APIs in this <see href="https://dataforseo.com/help-center/rules-and-limitations-of-keyword-and-keywords-fields-in-dataforseo-apis">Help Center article</see>
        /// </summary>
        [JsonProperty("keyword", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// direct URL of the search query
        /// <br/>optional field
        /// <br/>you can specify a direct URL and we will sort it out to the necessary fields. Note that this method is the most difficult for our API to process and also requires you to specify the exact language and location in the URL. In most cases, we wouldn’t recommend using this method.
        /// <br/>example:
        /// <br/><c>https://www.amazon.com/s/?field-keywords=shoes&amp;language=en_US</c>
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don't specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_code</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations with their <c>location_name</c> parameters by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/amazon/locations</c>
        /// <br/>example:
        /// <br/><c>HA1,England,United Kingdom</c>
        /// </summary>
        [JsonProperty("location_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_coordinate</c>
        /// <br/>you can receive the list of available locations with their <c>location_code</c> parameters by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/merchant/amazon/locations</c>
        /// <br/>example:
        /// <br/><c>9045969</c>
        /// </summary>
        [JsonProperty("location_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don't specify <c>location_name</c> or <c>location_code</c>
        /// <br/>if you use this field, you don't need to specify <c>location_name</c> or <c>location_code</c>
        /// <br/><c>location_coordinate</c> parameter should be specified in the 'latitude,longitude,radius' format
        /// <br/>the maximum number of decimal digits for 'latitude' and 'longitude': 7
        /// <br/>the minimum value for 'radius': 199.9
        /// <br/>example:
        /// <br/><c>53.476225,-2.243572,200</c>
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don't specify <c>language_code</c>
        /// <br/>if you use this field, you don't need to specify <c>language_code</c>
        /// <br/>you can receive the list of available languages with their <c>language_name</c> parameters by making a separate request to the
        /// <br/><c>https://api.dataforseo.com/v3/merchant/amazon/languages</c>
        /// <br/>example:
        /// <br/><c>English (United Kingdom)</c>
        /// </summary>
        [JsonProperty("language_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don't specify <c>language_name</c>
        /// <br/>if you use this field, you don't need to specify <c>language_name</c>
        /// <br/>you can receive the list of available languages with their <c>language_code</c> parameters by making a separate request to the <c>https://api.dataforseo.com/v3/merchant/amazon/languages</c>
        /// <br/>example:
        /// <br/><c>en_GB</c>
        /// </summary>
        [JsonProperty("language_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search engine domain
        /// <br/>optional field
        /// <br/>we choose the relevant search engine domain automatically according to the location and language you specify
        /// <br/>however, you can set a custom search engine domain in this field
        /// <br/>example:
        /// <br/><c>amazon.com</c>, <c>amazon.co.uk</c>, <c>amazon.fr</c>, etc.
        /// </summary>
        [JsonProperty("se_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results to be retrieved from the Amazon results page
        /// <br/>default value: <c>100</c>
        /// <br/>max value: <c>700</c>
        /// <br/>Your account will be billed per each SERP containing up to 100 results; 
        /// <br/>Setting depth above 100 may result in additional charges if the search engine returns more than 100 results;
        /// <br/>The cost can be calculated on the <see href="https://dataforseo.com/pricing/merchant/amazon-api">Pricing</see> page.
        /// </summary>
        [JsonProperty("depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// page crawl limit
        /// <br/>optional field
        /// <br/>number of search results pages to crawl
        /// <br/>max value: <c>7</c>
        /// <br/>Note: the <c>max_crawl_pages</c> and <c>depth</c> parameters complement each other;
        /// <br/>learn more at <see href="https://dataforseo.com/help-center/what-is-max-crawl-pages-and-how-does-it-work">our help center</see>
        /// </summary>
        [JsonProperty("max_crawl_pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCrawlPages { get; set; }

        /// <summary>
        /// amazon product department
        /// <br/>optional field
        /// <br/>specify one of the following amazon departments for extracting product listings:
        /// <br/><c>'Arts &amp; Crafts'</c>, <c>'Automotive'</c>, <c>'Baby'</c>, <c>'Beauty &amp; Personal Care'</c>, <c>'Books'</c>, <c>'Computers'</c>, <c>'Digital Music'</c>, <c>'Electronics'</c>, <c>'Kindle Store'</c>, <c>'Prime Video'</c>, <c>'Women's Fashion'</c>, <c>'Men's Fashion'</c>, <c>'Girls' Fashion'</c>, <c>'Boys' Fashion'</c>, <c>'Deals'</c>, <c>'Health &amp; Household'</c>, <c>'Home &amp; Kitchen'</c>, <c>'Industrial &amp; Scientific'</c>, <c>'Luggage'</c>, <c>'Movies &amp; TV'</c>, <c>'Music, CDs &amp; Vinyl'</c>, <c>'Pet Supplies'</c>, <c>'Software'</c>, <c>'Sports &amp; Outdoors'</c>, <c>'Tools &amp; Home Improvement'</c>, <c>'Toys &amp; Games'</c>, <c>'Video Games'</c>
        /// </summary>
        [JsonProperty("department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Department { get; set; }

        /// <summary>
        /// additional parameters of the search query
        /// <br/>optional field
        /// <br/>you can use the following Amazon search URL parameters for customizing the search
        /// <br/>example:
        /// <br/><c>&amp;low-price=52</c> - search for products that cost more than 52 USD;
        /// <br/><c>&amp;high-price=45</c> - search for products that cost less than 45 USD;
        /// <br/><c>&amp;sort=relevancerank</c> - sort results by relevance;
        /// <br/><c>&amp;sort=featured-rank</c> - sort results by featured products;
        /// <br/><c>&amp;sort=price-asc-rank</c> - sort by ascending price;
        /// <br/><c>&amp;sort=price-desc-rank</c> - sort by descending price;
        /// <br/><c>&amp;sort=review-rank</c> - sort by the average customer reviews value;
        /// <br/><c>&amp;sort=date-desc-rank</c> - sort by the newest arrival
        /// <br/>Note that <c>search_param</c> values will be ignored if any of the following parameters is used: <c>price_min</c>, <c>price_max</c>, <c>sort_by</c>
        /// </summary>
        [JsonProperty("search_param", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SearchParam { get; set; }

        /// <summary>
        /// minimum product price
        /// <br/>optional field
        /// <br/>minimum price of the returned products listed on Amazon for the specified query
        /// <br/>example:
        /// <br/><c>5</c>
        /// <br/>Note: if you specify <c>price_min</c>, the <c>search_param</c> parameter will be ignored
        /// </summary>
        [JsonProperty("price_min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMin { get; set; }

        /// <summary>
        /// maximum product price
        /// <br/>optional field
        /// <br/>maximum price of the returned products listed on Amazon for the specified query
        /// <br/>example:
        /// <br/><c>100</c>
        /// <br/>Note: if you specify <c>price_max</c>, the <c>search_param</c> parameter will be ignored
        /// </summary>
        [JsonProperty("price_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMax { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>the following sorting rules are supported:
        /// <br/><c>relevance</c>, <c>price_low_to_high</c>, <c>price_high_to_low</c>, <c>featured</c>, <c>avg_customer_review</c>, <c>newest_arrival</c>
        /// <br/>example:
        /// <br/><c>sort_by:'relevance'</c>
        /// <br/>Note: if you specify <c>sort_by</c>, the <c>search_param</c> parameter will be ignored
        /// </summary>
        [JsonProperty("sort_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified <c>tag</c> value in the <c>data</c> object of the response
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