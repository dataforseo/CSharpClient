# KnowledgeGraphExpandedItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the link |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>kc:/local:place qa |[optional]|
**ExpandedElement** | **IEnumerable<KnowledgeGraphExpandedElement>** | link of the element |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|