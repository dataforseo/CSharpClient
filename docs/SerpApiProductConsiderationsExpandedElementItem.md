# SerpApiProductConsiderationsExpandedElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the carousel item</em> |[optional]|
**FeaturedTitle** | **string** | <em>the title of the featured snippets source page</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb of the Ad element in SERP</em> |[optional]|
**Snippet** | **string** | <em>text alongside the link title</em> |[optional]|
**Domain** | **string** | <em>source domain</em> |[optional]|
**Url** | **string** | <em>relevant URL</em> |[optional]|
**Timestamp** | **string** | <em>date and time when the result was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**RelatedSearches** | **IEnumerable<string>** | <a name='related_searches'></a>((‘related_searches’ element in SERP|https://dataforseo.com/wp-content/uploads/2020/02/window-feature-related-searches.png)) |[optional]|
**AboutThisResult** | **AboutThisResultElement** | <em>contains information from the 'About this result' panel</em><br><strong>Note:</strong> this object is deprecated and always returns <code>null</null> |[optional]|