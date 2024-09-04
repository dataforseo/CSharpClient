using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleHotelSearchesTaskPostRequestInfo : BusinessDataTaskRequestInfo
    {
        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of results in Google Hotels
        /// <br/>default value: 20 organic results
        /// <br/>max value: 140
        /// <br/>Note: your account will be billed per each 20 organic results regardless of paid listings in the response;
        /// <br/>thus, setting a depth above 20 may result in additional charges if Google Hotels return more than 20 results;
        /// <br/>if the specified depth is higher than the number of results in the response, the difference will be refunded automatically to your account balance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }

        /// <summary>
        /// check-in date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, tomorrow’s date will be used by default;
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
        /// <br/>Note: the value cannot precede the today’s date
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_in", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckIn { get; set; }

        /// <summary>
        /// check-out date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, our system will apply the date of two days from now by default;
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
        /// <br/>Note: the value cannot be less than or equal to check_in;
        /// <br/>the range between check_in and check_out values cannot exceed 30 days
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_out", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckOut { get; set; }

        /// <summary>
        /// currency
        /// <br/>optional field
        /// <br/>example:
        /// <br/>"USD"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// number of adults
        /// <br/>optional field
        /// <br/>if you don’t specify this field, the default value of 2 will be applied;
        /// <br/>note that you can specify up to 6 persons including both adults and children
        /// <br/>example:
        /// <br/>1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adults", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Adults { get; set; }

        /// <summary>
        /// number and age of children
        /// <br/>optional field
        /// <br/>if you don’t specify this field, no children will be included in the search;
        /// <br/>age of child can be from 0 to 17;
        /// <br/>note that you can specify up to 6 persons including both adults and children
        /// <br/>set the following value if you want to include one 14-year-old child:
        /// <br/>[14]
        /// <br/>set the following value if you want to include one 13-year-old child and one 8-year-old child:
        /// <br/>[13,8]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("children", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Children { get; set; }

        /// <summary>
        /// hotel stars
        /// <br/>optional field
        /// <br/>set this field to [5] if you want to get the list of 5-star hotels only
        /// <br/>example:
        /// <br/>[3,4,5]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stars", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Stars { get; set; }

        /// <summary>
        /// minimum rating
        /// <br/>optional field
        /// <br/>you can use this field to specify guest rating higher than a certain value
        /// <br/>example:
        /// <br/>2.5
        /// </summary>
        [Newtonsoft.Json.JsonProperty("min_rating", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? MinRating { get; set; }

        /// <summary>
        /// results sorting parameters
        /// <br/>optional field
        /// <br/>you can use this field to sort the results
        /// <br/>possible types of sorting:
        /// <br/>relevance – sort by most relevant
        /// <br/>lowest_price – sort by the lowest price
        /// <br/>highest_rating – sort by highest rating
        /// <br/>most_reviewed – sort by most reviewed
        /// <br/>default value: relevance
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// minimum price per night
        /// <br/>optional field
        /// <br/>the currency of this value depends on the currency field
        /// <br/>example:
        /// <br/>100
        /// </summary>
        [Newtonsoft.Json.JsonProperty("min_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MinPrice { get; set; }

        /// <summary>
        /// maximum price per night
        /// <br/>optional field
        /// <br/>the currency of this value depends on the currency field
        /// <br/>example:
        /// <br/>600
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaxPrice { get; set; }

        /// <summary>
        /// hotels with a free cancellation
        /// <br/>optional field
        /// <br/>set this field to true if you want to get the list of hotels with free cancellation of reservations
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("free_cancellation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FreeCancellation { get; set; }

        /// <summary>
        /// search for vacation rentals
        /// <br/>optional field
        /// <br/>set this field to true if you want to get the list of vacation rentals instead of hotels
        /// <br/>default value: false
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_vacation_rentals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsVacationRentals { get; set; }

        /// <summary>
        /// hotel amenities
        /// <br/>optional field
        /// <br/>you can use this field to specify different hotel amenities
        /// <br/>example:
        /// <br/>  [
        /// <br/>            "free_parking",
        /// <br/>            "pets_allowed"
        /// <br/>        ]
        /// <br/>
        /// <br/>possible values:
        /// <br/>"air_conditioning",
        /// <br/>"all_inclusive_available",
        /// <br/>"bar",
        /// <br/>"free_breakfast",
        /// <br/>"fitness_center",
        /// <br/>"kid_friendly",
        /// <br/>"free_parking",
        /// <br/>"pets_allowed",
        /// <br/>"pool",
        /// <br/>"restaurant",
        /// <br/>"room_service",
        /// <br/>"spa",
        /// <br/>"free_wifi",
        /// <br/>"parking",
        /// <br/>"indoor_pool",
        /// <br/>"outdoor_pool",
        /// <br/>"wheelchair_accessible",
        /// <br/>"beach_access"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amenities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Amenities { get; set; }
    }
}