# SerpApiProductConsiderationsExpandedElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the row |[optional]|
**FeaturedTitle** | **string** | the title of the featured snippets source page |[optional]|
**Breadcrumb** | **string** | breadcrumb of the Ad element in SERP |[optional]|
**Snippet** | **string** | text alongside the link title |[optional]|
**Domain** | **string** | domain where a link points |[optional]|
**Url** | **string** | URL of element |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**RelatedSearches** | **IEnumerable<string>** | search queries related to the elment |[optional]|
**AboutThisResult** | **AboutThisResultElement** | contains information from the ‘About this result’ panel<br>‘About this result’ panel provides additional context about why Google returned this result for the given query;<br>this feature appears after clicking on the three dots next to most results |[optional]|