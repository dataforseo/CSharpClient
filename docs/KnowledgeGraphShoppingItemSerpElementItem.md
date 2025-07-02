# KnowledgeGraphShoppingItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Title** | **string** | title of the place |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>kc:/shopping/gpc:organic-offers |[optional]|
**Items** | **IEnumerable<KnowledgeGraphShoppingElement>** | additional items present in the element<br>if there are none, equals null |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|