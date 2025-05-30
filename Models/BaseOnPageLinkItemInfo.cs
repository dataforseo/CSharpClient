using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{
    [JsonConverter(typeof(JsonInheritanceConverter), "type")]
    [JsonInheritance("anchor", typeof(AnchorLinkElementItem))]
    [JsonInheritance("image", typeof(ImageLinkElementItem))]
    [JsonInheritance("canonical", typeof(CanonicalLinkElementItem))]
    [JsonInheritance("alternate", typeof(AlternateLinkElementItem))]
    [JsonInheritance("link", typeof(LinkLinkElementItem))]
    [JsonInheritance("redirect", typeof(RedirectLinkElementItem))]
    [JsonInheritance("meta", typeof(MetaLinkElementItem))]

    public class BaseOnPageLinkItemInfo 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// referring domain
        /// <br/>the link was found on this domain
        /// </summary>
        [JsonProperty("domain_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DomainFrom { get; set; }

        /// <summary>
        /// referenced domain
        /// <br/>the link is pointing to this domain
        /// </summary>
        [JsonProperty("domain_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DomainTo { get; set; }

        /// <summary>
        /// referring page
        /// <br/>relative URL of the page on which the link was found
        /// </summary>
        [JsonProperty("page_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageFrom { get; set; }

        /// <summary>
        /// referenced page
        /// <br/>relative URL of the page to which the link is pointing
        /// </summary>
        [JsonProperty("page_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageTo { get; set; }

        /// <summary>
        /// referring page
        /// <br/>absolute URL of the page on which the link was found
        /// </summary>
        [JsonProperty("link_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LinkFrom { get; set; }

        /// <summary>
        /// referenced page
        /// <br/>absolute URL of the page to which the link is pointing
        /// </summary>
        [JsonProperty("link_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LinkTo { get; set; }

        /// <summary>
        /// indicates whether the link is dofollow
        /// <br/>if the value is true, the link doesn’t have a rel='nofollow' attribute
        /// </summary>
        [JsonProperty("dofollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dofollow { get; set; }

        /// <summary>
        /// url scheme of the referring page
        /// </summary>
        [JsonProperty("page_from_scheme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageFromScheme { get; set; }

        /// <summary>
        /// url scheme of the referenced page
        /// </summary>
        [JsonProperty("page_to_scheme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PageToScheme { get; set; }

        /// <summary>
        /// direction of the link
        /// <br/>possible values: internal, external
        /// </summary>
        [JsonProperty("direction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// link is broken
        /// <br/>indicates whether a link is directing to a broken page or resource
        /// </summary>
        [JsonProperty("is_broken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBroken { get; set; }

        /// <summary>
        /// indicates that the link may have a conflict with another link
        /// <br/>if true, at least one link pointing to link_to has a rel='nofollow' attribute and at least one is dofollow
        /// </summary>
        [JsonProperty("is_link_relation_conflict", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLinkRelationConflict { get; set; }

        /// <summary>
        /// status code of the referenced page
        /// <br/>status code of the page to which the link is pointing
        /// </summary>
        [JsonProperty("page_to_status_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PageToStatusCode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}