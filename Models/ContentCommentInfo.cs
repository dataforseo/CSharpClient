using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class ContentCommentInfo 
    {

        /// <summary>
        /// product’s rating
        /// <br/>contains information about the rating a customer has given to the product
        /// </summary>
        [JsonProperty("rating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContentRatingInfo Rating { get; set; }

        /// <summary>
        /// title of the customer’s comment
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// date when the comment was published
        /// </summary>
        [JsonProperty("publish_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDate { get; set; }

        /// <summary>
        /// author of the comment
        /// </summary>
        [JsonProperty("author", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("have_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaveForm { get; set; }

        /// <summary>
        /// primary content on the page
        /// <br/>you can find more information about content priority calculation in this help center article
        /// </summary>
        [JsonProperty("primary_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SectionContentItemInfo> PrimaryContent { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}