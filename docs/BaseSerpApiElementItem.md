# BaseSerpApiElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Page** | **int?** | <em>search results page number</em><br>indicates the number of the SERP page on which the element is located |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Rectangle** | **AiModeRectangleInfo** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|