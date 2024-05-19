using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BusinessDataGoogleMyBusinessUpdatesTaskPostRequestInfo : BusinessDataTaskRequestInfo
    {
        /// <summary>
        /// parsing depth
        /// <br/>optional field
        /// <br/>number of updates in SERP
        /// <br/>we strongly recommend setting the parsing depth in the multiples of ten, because our systems processes ten updates in a row
        /// <br/>please note that Google returns 4490 updates maximum
        /// <br/>default value: 10
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Depth { get; set; }
    }
}