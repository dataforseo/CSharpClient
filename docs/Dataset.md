# Dataset


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**DatasetId** | **string** | ID of the dataset |[optional]|
**Title** | **string** | title of the element |[optional]|
**ImageUrl** | **string** | URL of the image<br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**ScholarlyCitationsCount** | **long?** | count of articles that refer to the dataset |[optional]|
**ScholarlyArticlesUrl** | **string** | url of scholarly articles<br>link to the list of scholarly articles on Google Scholar<br>example: https://scholar.google.com/scholar?q=%2210.6084%20m9%20figshare%207427933%20v1%22 |[optional]|
**UniqueIdentifier** | **string** | digital identifier of an object<br>unique digital identifier of the dataset<br>example: https://doi.org/10.5061/dryad.hmgqnk9m3 |[optional]|
**RelatedArticle** | **string** | link to related article<br>link to the published article that is related to the dataset |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of Google Dataset’s search results<br>if there are none, equals null |[optional]|
**DatasetProviders** | **IEnumerable<LicensesElement>** | the list of institutions that provided the dataset |[optional]|
**Formats** | **IEnumerable<FormatsElement>** | the list of file formats of the dataset |[optional]|
**Authors** | **IEnumerable<AuthorsElement>** | the list of authors of the dataset |[optional]|
**Licenses** | **IEnumerable<LicensesElement>** | the list of licenses issued to the dataset |[optional]|
**UpdatedDate** | **string** | date and time when the result was last updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2022-11-27 02:00:00 +00:00 |[optional]|
**AreaCovered** | **IEnumerable<string>** | the list of areas covered in the dataset<br>for example: Africa, Global |[optional]|
**PeriodCovered** | **PeriodCovered** | period covered in the dataset |[optional]|
**DatasetDescription** | **DatasetDescription** | description of the dataset |[optional]|