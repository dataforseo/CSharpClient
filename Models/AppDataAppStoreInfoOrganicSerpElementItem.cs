namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AppDataAppStoreInfoOrganicSerpElementItem : BaseAppDataSerpElementItem
    {
        /// <summary>
        /// ID of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// URL to the app page on App Store
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL to the app icon
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// description of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// the total number of reviews of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviews_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// price of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Price Price { get; set; }

        /// <summary>
        /// indicates whether the app is free
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_free", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        /// <summary>
        /// main category/genre of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainCategory { get; set; }

        /// <summary>
        /// all relevant categories/genres of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Categories { get; set; }

        /// <summary>
        /// languages supported in the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("languages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Languages { get; set; }

        /// <summary>
        /// age rating and age-based content advisories
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advisories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Advisories { get; set; }

        /// <summary>
        /// name of the app developer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("developer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Developer { get; set; }

        /// <summary>
        /// ID of the app developer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("developer_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// URL to the developer page on App Store
        /// </summary>
        [Newtonsoft.Json.JsonProperty("developer_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeveloperUrl { get; set; }

        /// <summary>
        /// current version of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// minimum OS version required to install the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minimum_os_version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOsVersion { get; set; }

        /// <summary>
        /// size of the app
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// date and time when the app was released
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("released_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReleasedDate { get; set; }

        /// <summary>
        /// date and time when the app was last updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_update_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastUpdateDate { get; set; }

        /// <summary>
        /// update notes
        /// <br/>contains the latest update notes from the developer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UpdateNotes { get; set; }

        /// <summary>
        /// app images
        /// <br/>contains URLs to the images used on the app page on App Store
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Images { get; set; }

        /// <summary>
        /// similar apps
        /// <br/>displays apps similar to the app in a POST request
        /// </summary>
        [Newtonsoft.Json.JsonProperty("similar_apps", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppsInfo> SimilarApps { get; set; }

        /// <summary>
        /// similar apps
        /// <br/>information about apps built by the same developer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("more_apps_by_developer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AppsInfo> MoreAppsByDeveloper { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }
}