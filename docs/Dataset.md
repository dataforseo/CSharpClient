# Dataset


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values:<br><code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath' rel='noopener noreferrer' target='_blank'>XPath</a> of the element</em> |[optional]|
**DatasetId** | **string** | <em>ID of the dataset</em> |[optional]|
**Title** | **string** | <em>title of the element</em> |[optional]|
**ImageUrl** | **string** | <em>URL of the image</em><br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**ScholarlyCitationsCount** | **long?** | <em>count of articles that refer to the dataset</em> |[optional]|
**ScholarlyArticlesUrl** | **string** | <em>url of scholarly articles</em><br>link to the list of scholarly articles on Google Scholar <br>example: <code>https://scholar.google.com/scholar?q=%2210.6084%20m9%20figshare%207427933%20v1%22</code> |[optional]|
**UniqueIdentifier** | **string** | <em>digital identifier of an object</em><br>unique digital identifier of the dataset <br>example: <code>https://doi.org/10.5061/dryad.hmgqnk9m3</code> |[optional]|
**RelatedArticle** | **string** | <em>link to related article</em><br>link to the published article that is related to the dataset |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>sitelinks</em><br>the links shown below some of Google Dataset's search results<br>if there are none, equals <code>null</code> |[optional]|
**DatasetProviders** | **IEnumerable<AmazonLabelElement>** | <em>the list of institutions that provided the dataset</em> |[optional]|
**Formats** | **IEnumerable<FormatsElement>** | <em>the list of file formats of the dataset</em> |[optional]|
**Authors** | **IEnumerable<AuthorsElement>** | <em>the list of authors of the dataset</em> |[optional]|
**Licenses** | **IEnumerable<AmazonLabelElement>** | <em>the list of licenses issued to the dataset</em> |[optional]|
**UpdatedDate** | **string** | <em>date and time when the result was last updated</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2022-11-27 02:00:00 +00:00</code> |[optional]|
**AreaCovered** | **IEnumerable<string>** | <em>the list of areas covered in the dataset</em><br>for example: <code>Africa</code>, <code>Global</code> |[optional]|
**PeriodCovered** | **PeriodCovered** | <em>period covered in the dataset</em> |[optional]|
**DatasetDescription** | **DatasetDescription** | <em>description of the dataset</em> |[optional]|