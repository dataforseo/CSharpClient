namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RedirectLinkElementItem : BaseOnPageLinkItemInfo
    {
        /// <summary>
        /// referring domain
        /// <br/>the link was found on this domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainFrom { get; set; }

        /// <summary>
        /// referenced domain
        /// <br/>the link is pointing to this domain
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomainTo { get; set; }

        /// <summary>
        /// referring page
        /// <br/>relative URL of the page on which the link was found
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageFrom { get; set; }

        /// <summary>
        /// referenced page
        /// <br/>relative URL of the page to which the link is pointing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageTo { get; set; }

        /// <summary>
        /// referring page
        /// <br/>absolute URL of the page on which the link was found
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LinkFrom { get; set; }

        /// <summary>
        /// referenced page
        /// <br/>absolute URL of the page to which the link is pointing
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LinkTo { get; set; }

        /// <summary>
        /// indicates whether the link is dofollow
        /// <br/>if the value is true, the link doesn’t have a rel="nofollow" attribute
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dofollow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Dofollow { get; set; }

        /// <summary>
        /// url scheme of the referring page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_from_scheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageFromScheme { get; set; }

        /// <summary>
        /// url scheme of the referenced page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_to_scheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PageToScheme { get; set; }

        /// <summary>
        /// direction of the link
        /// <br/>possible values: internal, external
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// link is broken
        /// <br/>indicates whether a link is directing to a broken page or resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_broken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsBroken { get; set; }

        /// <summary>
        /// indicates that the link may have a conflict with another link
        /// <br/>if true, at least one link pointing to the URL in link_to has a rel="nofollow" attribute and at least one is dofollow
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_link_relation_conflict", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsLinkRelationConflict { get; set; }

    }
}