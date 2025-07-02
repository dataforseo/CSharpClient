using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class PageContentInfo 
    {

        /// <summary>
        /// content of the header of the table
        /// </summary>
        [JsonProperty("header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageSectionContentInfo Header { get; set; }

        /// <summary>
        /// parsed content of the footer
        /// </summary>
        [JsonProperty("footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PageSectionContentInfo Footer { get; set; }

        /// <summary>
        /// main topic on the page
        /// <br/>you can find more information about topic priority calculation in this help center article
        /// </summary>
        [JsonProperty("main_topic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TopicInfo> MainTopic { get; set; }

        /// <summary>
        /// secondary topic on the page
        /// <br/>you can find more information about topic priority calculation in this help center article
        /// </summary>
        [JsonProperty("secondary_topic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<TopicInfo> SecondaryTopic { get; set; }

        /// <summary>
        /// contains objects with rating information for the products displayed on the page
        /// </summary>
        [JsonProperty("ratings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentRatingInfo> Ratings { get; set; }

        /// <summary>
        /// array of products displayed on the page
        /// <br/>contains objects with information on products displayed on the page
        /// </summary>
        [JsonProperty("offers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentOfferInfo> Offers { get; set; }

        /// <summary>
        /// array of comments displayed on the page
        /// <br/>contains objects with information on comments related to displayed products
        /// </summary>
        [JsonProperty("comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContentCommentInfo> Comments { get; set; }

        /// <summary>
        /// contact information
        /// <br/>contains contact information displayed on the page
        /// </summary>
        [JsonProperty("contacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Contacts Contacts { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}