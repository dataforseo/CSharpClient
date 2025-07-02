using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AmazonAmazonSellerMainItemSerpElementItem  : BaseAmazonSerpElementItem 
    {

        /// <summary>
        /// alignment of the element in SERP
        /// <br/>possible values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// business name of the seller
        /// </summary>
        [JsonProperty("seller_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// url forwarding to the seller’s page on Amazon
        /// </summary>
        [JsonProperty("seller_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SellerUrl { get; set; }

        /// <summary>
        /// sender company name
        /// </summary>
        [JsonProperty("ships_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShipsFrom { get; set; }

        /// <summary>
        /// product pricing details
        /// <br/>if there are no details, the value will be null
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// seller rating details
        /// <br/>seller popularity rate based on customer reviews
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RatingElement Rating { get; set; }

        /// <summary>
        /// product condition
        /// <br/>condition of the product offered by the seller
        /// </summary>
        [JsonProperty("condition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// product condition details
        /// <br/>expanded details on the condition of the product offered by the seller
        /// </summary>
        [JsonProperty("condition_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionDescription { get; set; }

        /// <summary>
        /// delivery information
        /// <br/>delivery information including free and fast delivery date ranges
        /// </summary>
        [JsonProperty("delivery_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AmazonDeliveryInfo DeliveryInfo { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}