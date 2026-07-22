# SerpApiProductConsiderationsExpandedElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the carousel item |[optional]|
**FeaturedTitle** | **string** | the title of the featured snippets source page |[optional]|
**Breadcrumb** | **string** | breadcrumb of the Ad element in SERP |[optional]|
**Snippet** | **string** | text alongside the link title |[optional]|
**Domain** | **string** | source domain |[optional]|
**Url** | **string** | relevant URL |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**RelatedSearches** | **IEnumerable<string>** | search queries related to the elment |[optional]|
**AboutThisResult** | **AboutThisResultElement** | contains information from the ‘About this result’ panel<br>Note: element no longer appears in SERP and has been deprecated in SERP API |[optional]|