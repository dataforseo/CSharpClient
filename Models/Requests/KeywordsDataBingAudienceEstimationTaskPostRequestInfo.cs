using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{

    public class KeywordsDataBingAudienceEstimationTaskPostRequestInfo 
    {

        /// <summary>
        /// full name of search engine location
        /// <br/>required field if you don’t specify location_code or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_code or location_coordinate
        /// <br/>you can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/locations
        /// <br/>example:
        /// <br/>London,England,United Kingdom
        /// </summary>
        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationName { get; set; }

        /// <summary>
        /// search engine location code
        /// <br/>required field if you don’t specify location_name or location_coordinate
        /// <br/>if you use this field, you don’t need to specify location_name or location_coordinate
        /// <br/>you can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/keywords_data/bing/locations
        /// <br/>example:
        /// <br/>2840
        /// </summary>
        [JsonProperty("location_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LocationCode { get; set; }

        /// <summary>
        /// GPS coordinates of a location
        /// <br/>required field if you don’t specify location_name or location_code
        /// <br/>if you use this field, you don’t need to specify location_name or location_code
        /// <br/>location_coordinate parameter should be specified in the “latitude,longitude,radius (in km)” format
        /// <br/>the data will be provided for the country the specified coordinates belong to
        /// <br/>example:
        /// <br/>29.6821525,-82.4098881,100
        /// </summary>
        [JsonProperty("location_coordinate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LocationCoordinate { get; set; }

        /// <summary>
        /// selection of age ranges for targeting
        /// <br/>possible values: eighteen_to_twenty_four, fifty_to_sixty_four, sixty_five_and_above, thirteen_to_seventeen, thirty_five_to_forty_nine, twenty_five_to_thirty_four, unknown, zero_to_twelve
        /// </summary>
        [JsonProperty("age", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Age { get; set; }

        /// <summary>
        /// desired bid setting value in USD
        /// <br/>maximum value: 1000
        /// </summary>
        [JsonProperty("bid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Bid { get; set; }

        /// <summary>
        /// daily campaign budget value in USD
        /// <br/>maximum value: 10000
        /// </summary>
        [JsonProperty("daily_budget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DailyBudget { get; set; }

        /// <summary>
        /// gender to target
        /// <br/>possible values: male, female, unknown
        /// </summary>
        [JsonProperty("gender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Gender { get; set; }

        /// <summary>
        /// industry of LinkedIn profile targeting
        /// <br/>if you use this field, you can receive the list of available industry names  with industry_id by making a separate request to the https://api.dataforseo.com/v3/keywords_data/bing/audience_estimation/industries
        /// <br/>example: 806301758
        /// </summary>
        [JsonProperty("industry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Industry { get; set; }

        /// <summary>
        /// job function of LinkedIn profile targeting
        /// <br/>if you use this field, you can receive the list of available job function names  with job_function_id by making a separate request to the https://api.dataforseo.com/v3/keywords_data/bing/audience_estimation/job_functions
        /// <br/>example: 806300451
        /// </summary>
        [JsonProperty("job_function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> JobFunction { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}