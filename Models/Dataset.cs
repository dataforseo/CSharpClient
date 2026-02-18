using Newtonsoft.Json;
using System.Collections.Generic;
using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models
{

    public class Dataset 
    {

        /// <summary>
        /// type of element
        /// </summary>
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [JsonProperty("rank_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [JsonProperty("rank_absolute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [JsonProperty("xpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// ID of the dataset
        /// </summary>
        [JsonProperty("dataset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatasetId { get; set; }

        /// <summary>
        /// title of the element
        /// </summary>
        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL of the image
        /// <br/>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available)
        /// </summary>
        [JsonProperty("image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// count of articles that refer to the dataset
        /// </summary>
        [JsonProperty("scholarly_citations_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ScholarlyCitationsCount { get; set; }

        /// <summary>
        /// url of scholarly articles
        /// <br/>link to the list of scholarly articles on Google Scholar
        /// <br/>example: https://scholar.google.com/scholar?q=%2210.6084%20m9%20figshare%207427933%20v1%22
        /// </summary>
        [JsonProperty("scholarly_articles_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ScholarlyArticlesUrl { get; set; }

        /// <summary>
        /// digital identifier of an object
        /// <br/>unique digital identifier of the dataset
        /// <br/>example: https://doi.org/10.5061/dryad.hmgqnk9m3
        /// </summary>
        [JsonProperty("unique_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// link to related article
        /// <br/>link to the published article that is related to the dataset
        /// </summary>
        [JsonProperty("related_article", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedArticle { get; set; }

        /// <summary>
        /// sitelinks
        /// <br/>the links shown below some of Google Dataset’s search results
        /// <br/>if there are none, equals null
        /// </summary>
        [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<LinkElement> Links { get; set; }

        /// <summary>
        /// the list of institutions that provided the dataset
        /// </summary>
        [JsonProperty("dataset_providers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AmazonLabelElement> DatasetProviders { get; set; }

        /// <summary>
        /// the list of file formats of the dataset
        /// </summary>
        [JsonProperty("formats", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<FormatsElement> Formats { get; set; }

        /// <summary>
        /// the list of authors of the dataset
        /// </summary>
        [JsonProperty("authors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AuthorsElement> Authors { get; set; }

        /// <summary>
        /// the list of licenses issued to the dataset
        /// </summary>
        [JsonProperty("licenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AmazonLabelElement> Licenses { get; set; }

        /// <summary>
        /// date and time when the result was last updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2022-11-27 02:00:00 +00:00
        /// </summary>
        [JsonProperty("updated_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedDate { get; set; }

        /// <summary>
        /// the list of areas covered in the dataset
        /// <br/>for example: Africa, Global
        /// </summary>
        [JsonProperty("area_covered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> AreaCovered { get; set; }

        /// <summary>
        /// period covered in the dataset
        /// </summary>
        [JsonProperty("period_covered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodCovered PeriodCovered { get; set; }

        /// <summary>
        /// description of the dataset
        /// </summary>
        [JsonProperty("dataset_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DatasetDescription DatasetDescription { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }
    }
}