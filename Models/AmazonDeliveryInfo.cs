using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonDeliveryInfo 
    {

        /// <summary>
        /// message accompanying the delivery information as posted by the seller
        /// </summary>
        [JsonProperty("delivery_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryMessage { get; set; }

        /// <summary>
        /// the earliest date when the product can be shipped
        /// </summary>
        [JsonProperty("delivery_date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryDateFrom { get; set; }

        /// <summary>
        /// the latest date when the product can be delivered
        /// </summary>
        [JsonProperty("delivery_date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryDateTo { get; set; }

        /// <summary>
        /// the earliest date when the product can be delivered with a fast delivery option
        /// </summary>
        [JsonProperty("fastest_delivery_date_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FastestDeliveryDateFrom { get; set; }

        /// <summary>
        /// the latest date when the product can be delivered with a fast delivery option
        /// </summary>
        [JsonProperty("fastest_delivery_date_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FastestDeliveryDateTo { get; set; }

        /// <summary>
        /// price for the delivery
        /// <br/>price of the delivery based on the location you specified in the POST request;
        /// <br/>if free delivery is available, the value is null
        /// </summary>
        [JsonProperty("delivery_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo DeliveryPrice { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}