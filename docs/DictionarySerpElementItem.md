# DictionarySerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**Url** | **string** | relevant URL of the Ad element in SERP |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb of the Ad element in SERP |[optional]|
**Keyword** | **string** | keyword highlighted in the result |[optional]|
**Snippet** | **string** | snippet of the element |[optional]|
**Text** | **string** | description of the results element in SERP |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of search results<br>if there are none, equals null |[optional]|