# AiModeAiOverview


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Markdown** | **string** | content of the element in markdown format<br>the text of the ai_overview formatted in the markdown markup language |[optional]|
**Items** | **IEnumerable<AiModeAiOverviewElement>** | items of the element |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReference>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|