using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MerchantAmazonReviewsTaskPostRequestInfo
    {
        /// <summary>
        /// product ID
        /// <br/>required field
        /// <br/>unique product identifier (ASIN) on Amazon
        /// <br/>you can receive the asin parameter by making a separate request to the Amazon Products endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Asin { get; set; }

        /// <summary>
        /// task priority
        /// <br/>optional field
        /// <br/>can take the following values:
        /// <br/>1 – normal execution priority (set by default)
        /// <br/>2 – high execution priority
        /// <br/>You will be additionally charged for the tasks with high execution priority.
        /// <br/>The cost can be calculated on the Pricing page.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations with their location_name parameters by making a separate request to https://api.dataforseo.com/v3/merchant/amazon/locations
        /// <br/>example:
        /// <br/>HA1,England,United Kingdom
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations with their location_code parameters by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/merchant/amazon/locations
        /// <br/>example:
        /// <br/>9045969
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
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
        [Newtonsoft.Json.JsonProperty("location_coordinate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// full name of search engine language
        /// <br/>required field if you don’t specify language_code
        /// <br/>if you use this field, you don’t need to specify language_code
        /// <br/>you can receive the list of available languages with their language_name parameters by making a separate request to
        /// <br/>https://api.dataforseo.com/v3/merchant/amazon/languages
        /// <br/>example:
        /// <br/>English (United Kingdom)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        /// <summary>
        /// search engine language code
        /// <br/>required field if you don’t specify language_name
        /// <br/>if you use this field, you don’t need to specify language_name
        /// <br/>you can receive the list of available languages with their language_code parameters by making a separate request to https://api.dataforseo.com/v3/merchant/amazon/languages
        /// <br/>example:
        /// <br/>en_GB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// search engine domain
        /// <br/>optional field
        /// <br/>we choose the relevant search engine domain automatically according to the location and language you specify
        /// <br/>however, you can set a custom search engine domain in this field
        /// <br/>example:
        /// <br/>amazon.com, amazon.co.uk, amazon.fr, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("se_domain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeDomain { get; set; }

        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of reviews in SERP;
        /// <br/>we strongly recommend setting the parsing depth in the multiples of ten, because our system processes ten reviews in a row;
        /// <br/>maximum value: 50
        /// <br/>default value: 10
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>possible types of sorting:
        /// <br/>helpful — for now, the only available sorting value;
        /// <br/>default rule: helpful
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// filter reviews by reviewer type
        /// <br/>optional field
        /// <br/>you can use this field to filter the results;
        /// <br/>possible types of filtering:
        /// <br/>all_reviews — return reviews from all reviewers;
        /// <br/>avp_only_reviews — return reviews with the “Verified Purchase” mark only;
        /// <br/>default rule: all_reviews
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviewer_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReviewerType { get; set; }

        /// <summary>
        /// filter reviews by stars
        /// <br/>optional field
        /// <br/>you can use this field to filter the results;
        /// <br/>possible types of filtering:
        /// <br/>all_stars — return reviews with any number of stars;
        /// <br/>five_star — return five-star reviews only;
        /// <br/>four_star — return four-star reviews only;
        /// <br/>three_star — return three-star reviews only;
        /// <br/>two_star — return two-star reviews only;
        /// <br/>one_star — return one-star reviews only;
        /// <br/>positive — return positive reviews only;
        /// <br/>critical — return critical reviews only;
        /// <br/>default rule: all_stars
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_by_star", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FilterByStar { get; set; }

        /// <summary>
        /// filter reviews by specified keyword
        /// <br/>optional field
        /// <br/>you can specify up to 300 characters in this field;
        /// <br/>if you use this field, the response will only include reviews that contain the specified keyword
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_by_keyword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FilterByKeyword { get; set; }

        /// <summary>
        /// filter reviews by media type
        /// <br/>optional field
        /// <br/>you can use this field to filter the results;
        /// <br/>possible types of filtering:
        /// <br/>all_contents — return text, image, and video reviews;
        /// <br/>media_reviews_only — return image and video reviews only;
        /// <br/>default rule: all_contents
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MediaType { get; set; }

        /// <summary>
        /// filter reviews by product modification
        /// <br/>optional field
        /// <br/>you can use this field to filter the results;
        /// <br/>possible types of filtering:
        /// <br/>all_format — return reviews for all product modifications;
        /// <br/>current_format — return reviews for the current product modification only;
        /// <br/>default rule: all_format;
        /// <br/>Note: ASINs vary depending on a product modification. Thus, two modifications of the same product will have two different ASINs. Make sure to specify the right ASIN when setting a task with the current_format parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("format_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FormatType { get; set; }

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
        [Newtonsoft.Json.JsonProperty("postback_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostbackUrl { get; set; }

        /// <summary>
        /// postback_url datatype
        /// <br/>required field if you specify postback_url
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible values:
        /// <br/>advanced, html
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postback_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
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