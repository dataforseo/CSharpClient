using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleHotelInfoTaskPostRequestInfo : BusinessDataTaskRequestInfo
    {
        /// <summary>
        /// unique hotel identifier
        /// <br/>required field if you don’t specify keyword
        /// <br/>if you use this field, you don’t need to specify keyword
        /// <br/>unique identifier of a hotel entity in Google search;
        /// <br/>you can obtain the value by making a request to Advanced Google SERP API (enclosed in the hotels_pack element of the response), or the Hotel Searches endpoint of Business Data API
        /// <br/>example:
        /// <br/>ChYIq6SB--i6p6cpGgovbS8wN2s5ODZfEAE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hotel_identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotelIdentifier { get; set; }

        /// <summary>
        /// check-in date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, tomorrow’s date will be used by default;
        /// <br/>the value must not be earlier than today’s date
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_in", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CheckIn { get; set; }

        /// <summary>
        /// check-out date
        /// <br/>optional field
        /// <br/>if you don’t specify this field, our system will apply the date of two days from now by default;
        /// <br/>Note: the value cannot be less than or equal to check_in;
        /// <br/>the range between check_in and check_out values cannot exceed 30 days
        /// <br/>date format: "yyyy-mm-dd"
        /// <br/>example:
        /// <br/>"2019-01-15"
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
        /// <br/>if you don’t specify this field, two adults will be used by default
        /// <br/>example:
        /// <br/>1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adults", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Adults { get; set; }

        /// <summary>
        /// number and age of children
        /// <br/>optional field
        /// <br/>if you don’t specify this field, no children will be included in the search;
        /// <br/>set the following value if you want to include one 14-years-old child:
        /// <br/>[14]
        /// <br/>set the following value if you want to include one 13-years-old child and one 8-years-old child:
        /// <br/>[13,8]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("children", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Children { get; set; }

        /// <summary>
        /// postback_url datatype
        /// <br/>required field if you specify postback_url
        /// <br/>corresponds to the datatype that will be sent to your server
        /// <br/>possible values:
        /// <br/>advanced, html
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postback_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostbackData { get; set; }
    }
}