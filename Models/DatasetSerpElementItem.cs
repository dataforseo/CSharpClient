namespace DataForSeo.Client.Models
{

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DatasetSerpElementItem : BaseSerpElementItem
    {
        /// <summary>
        /// group rank in SERP
        /// <br/>position within a group of elements with identical type values
        /// <br/>positions of elements with different type values are omitted from rank_group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankGroup { get; set; }

        /// <summary>
        /// absolute rank in SERP
        /// <br/>absolute position among all the elements in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_absolute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RankAbsolute { get; set; }

        /// <summary>
        /// the alignment of the element in SERP
        /// <br/>can take the following values:
        /// <br/>left, right
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// the XPath of the element
        /// </summary>
        [Newtonsoft.Json.JsonProperty("xpath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Xpath { get; set; }

        /// <summary>
        /// ID of the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataset_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatasetId { get; set; }

        /// <summary>
        /// title of the result in SERP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// URL of the image
        /// <br/>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// count of articles that refer to the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scholarly_citations_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ScholarlyCitationsCount { get; set; }

        /// <summary>
        /// url of scholarly articles
        /// <br/>link to the list of scholarly articles on Google Scholar
        /// <br/>example: https://scholar.google.com/scholar?q=%2210.6084%20m9%20figshare%207427933%20v1%22
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scholarly_articles_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScholarlyArticlesUrl { get; set; }

        /// <summary>
        /// digital identifier of an object
        /// <br/>unique digital identifier of the dataset
        /// <br/>example: https://doi.org/10.5061/dryad.hmgqnk9m3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unique_identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// link to related article
        /// <br/>link to the published article that is related to the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("related_article", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelatedArticle { get; set; }

        /// <summary>
        /// sitelinks
        /// <br/>the links shown below some of Google Dataset’s search results
        /// <br/>if there are none, equals null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LinkElement> Links { get; set; }

        /// <summary>
        /// the list of institutions that provided the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataset_providers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LicensesElement> DatasetProviders { get; set; }

        /// <summary>
        /// the list of file formats of the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("formats", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FormatsElement> Formats { get; set; }

        /// <summary>
        /// the list of authors of the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AuthorsElement> Authors { get; set; }

        /// <summary>
        /// the list of licenses issued to the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("licenses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LicensesElement> Licenses { get; set; }

        /// <summary>
        /// date and time when the result was last updated
        /// <br/>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
        /// <br/>example:
        /// <br/>2022-11-27 02:00:00 +00:00
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updated_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UpdatedDate { get; set; }

        /// <summary>
        /// the list of areas covered in the dataset
        /// <br/>for example: Africa, Global
        /// </summary>
        [Newtonsoft.Json.JsonProperty("area_covered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AreaCovered { get; set; }

        /// <summary>
        /// period covered in the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_covered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PeriodCovered PeriodCovered { get; set; }

        /// <summary>
        /// description of the dataset
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataset_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DatasetDescription DatasetDescription { get; set; }

    }
}