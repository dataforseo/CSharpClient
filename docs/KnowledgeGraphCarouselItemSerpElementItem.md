# KnowledgeGraphCarouselItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>action:listen_artist |[optional]|
**Link** | **LinkElement** | link of the element |[optional]|
**Items** | **IEnumerable<KnowledgeGraphListElement>** | elements of search results found in SERP |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|