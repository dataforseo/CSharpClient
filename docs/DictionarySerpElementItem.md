# DictionarySerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the result in SERP |[optional]|
**Url** | **string** | relevant URL of the Ad element in SERP |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb of the Ad element in SERP |[optional]|
**Keyword** | **string** | keyword highlighted in the result |[optional]|
**Snippet** | **string** | snippet of the element |[optional]|
**Text** | **string** | description of the results element in SERP |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of search results<br>if there are none, equals null |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>note: calculate_rectangles parameter is not yet available when setting tasks for Baidu search engine, that’s why rectangle always equals null |[optional]|