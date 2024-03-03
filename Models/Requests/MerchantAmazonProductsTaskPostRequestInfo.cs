using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MerchantAmazonProductsTaskPostRequestInfo : MerchantTaskRequestInfo
    {
        /// <summary>
        /// amazon product department
        /// <br/>optional field
        /// <br/>specify one of the following amazon departments for extracting product listings:
        /// <br/>"Arts &amp; Crafts", "Automotive", "Baby", "Beauty &amp; Personal Care", "Books", "Computers", "Digital Music", "Electronics", "Kindle Store", "Prime Video", "Women's Fashion", "Men's Fashion", "Girls' Fashion", "Boys' Fashion", "Deals", "Health &amp; Household", "Home &amp; Kitchen", "Industrial &amp; Scientific", "Luggage", "Movies &amp; TV", "Music, CDs &amp; Vinyl", "Pet Supplies", "Software", "Sports &amp; Outdoors", "Tools &amp; Home Improvement", "Toys &amp; Games", "Video Games"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Department { get; set; }
    }
}