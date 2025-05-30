using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class EventItemSerpElementItem  : BaseSerpElementItem 
    {

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// description of the results element in SERP
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// search URL with refinement parameters
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL of the image featured in the element
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// dates when the event takes place
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("event_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EventDates EventDates { get; set; }

        /// <summary>
        /// information about the event’s venue
        /// </summary>
        [JsonProperty("location_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LocationInfo LocationInfo { get; set; }

        /// <summary>
        /// additional information and ticket purchase options
        /// </summary>
        [JsonProperty("information_and_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<InformationAndTicketsElement> InformationAndTickets { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}