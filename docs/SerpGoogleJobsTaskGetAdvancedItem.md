# SerpGoogleJobsTaskGetAdvancedItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**JobId** | **string** | ID of the job on Google Jobs |[optional]|
**Title** | **string** | title of the element |[optional]|
**EmployerName** | **string** | name of the employer |[optional]|
**EmployerUrl** | **string** | URL to the employer’s website |[optional]|
**EmployerImageUrl** | **string** | URL to the image used in the job posting |[optional]|
**Location** | **string** | location for which the job vacancy is posted |[optional]|
**SourceName** | **string** | original source of the job vacancy |[optional]|
**SourceUrl** | **string** | URL to the original source of the job vacancy |[optional]|
**Salary** | **string** | the salary indicated in the job vacancy<br>if the salary isn’t indicated, this field will equal null |[optional]|
**ContractType** | **string** | employment contract type |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**TimeAgo** | **string** | indicates how long ago the job vacancy was posted |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP;<br>in this case, will equal null |[optional]|