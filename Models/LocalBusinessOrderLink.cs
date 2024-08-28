namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LocalBusinessOrderLink : BaseLocalBusinessLink
    {
        /// <summary>
        /// lists available delivery services
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_services", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LocalBusinessDeliveryServiceInfo> DeliveryServices { get; set; }

    }
}