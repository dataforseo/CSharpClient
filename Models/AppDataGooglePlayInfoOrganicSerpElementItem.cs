using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class AppDataGooglePlayInfoOrganicSerpElementItem  : BaseAppDataSerpElementItem 
    {

        /// <summary>
        /// ID of the app
        /// </summary>
        [JsonProperty("app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// URL to the app page on Google Play
        /// </summary>
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// URL to the app icon
        /// </summary>
        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// description of the app
        /// </summary>
        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// the total number of reviews the app has
        /// </summary>
        [JsonProperty("reviews_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ReviewsCount { get; set; }

        /// <summary>
        /// price of the app
        /// </summary>
        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PriceInfo Price { get; set; }

        /// <summary>
        /// indicates whether the app is free
        /// </summary>
        [JsonProperty("is_free", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFree { get; set; }

        /// <summary>
        /// main category of the app
        /// </summary>
        [JsonProperty("main_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MainCategory { get; set; }

        /// <summary>
        /// number of installs of the app
        /// <br/>approximate number of installs as displayed on the app page
        /// </summary>
        [JsonProperty("installs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Installs { get; set; }

        /// <summary>
        /// number of installs of the app
        /// <br/>the exact number of installs of the app
        /// </summary>
        [JsonProperty("installs_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? InstallsCount { get; set; }

        /// <summary>
        /// name of the app developer
        /// </summary>
        [JsonProperty("developer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Developer { get; set; }

        /// <summary>
        /// ID of the app developer
        /// </summary>
        [JsonProperty("developer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// URL to the developer page on Google Play
        /// </summary>
        [JsonProperty("developer_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperUrl { get; set; }

        /// <summary>
        /// email address of the developer
        /// </summary>
        [JsonProperty("developer_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperEmail { get; set; }

        /// <summary>
        /// physical address of the developer
        /// </summary>
        [JsonProperty("developer_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperAddress { get; set; }

        /// <summary>
        /// official website of the developer
        /// </summary>
        [JsonProperty("developer_website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperWebsite { get; set; }

        /// <summary>
        /// current version of the app
        /// </summary>
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// minimum OS version required to install the app
        /// </summary>
        [JsonProperty("minimum_os_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MinimumOsVersion { get; set; }

        /// <summary>
        /// size of the app
        /// </summary>
        [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// date and time when the app was released
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("released_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ReleasedDate { get; set; }

        /// <summary>
        /// date and time when the app was last updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
        /// <br/>example:
        /// <br/>2019-11-15 12:57:46 +00:00
        /// </summary>
        [JsonProperty("last_update_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateDate { get; set; }

        /// <summary>
        /// update notes
        /// <br/>contains the latest update notes from the developer
        /// </summary>
        [JsonProperty("update_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateNotes { get; set; }

        /// <summary>
        /// app images
        /// <br/>contains URLs to the images published on the app page on Google Play
        /// </summary>
        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Images { get; set; }

        /// <summary>
        /// app videos
        /// <br/>contains URLs to the video published on the app page on Google Play
        /// </summary>
        [JsonProperty("videos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Videos { get; set; }

        /// <summary>
        /// similar apps
        /// <br/>displays apps similar to the app in a POST request
        /// </summary>
        [JsonProperty("similar_apps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AppsInfo> SimilarApps { get; set; }

        /// <summary>
        /// similar apps
        /// <br/>information about apps built by the same developer
        /// </summary>
        [JsonProperty("more_apps_by_developer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AppsInfo> MoreAppsByDeveloper { get; set; }

        /// <summary>
        /// app genres
        /// <br/>contains relevant app categories
        /// </summary>
        [JsonProperty("genres", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Genres { get; set; }

        /// <summary>
        /// app tags
        /// <br/>contains relevant app tags
        /// </summary>
        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Tags { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}