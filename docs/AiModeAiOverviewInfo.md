# AiModeAiOverviewInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Markdown** | **string** | content of the element in markdown format<br>the text of the ai_overview formatted in the markdown markup language |[optional]|
**Items** | **IEnumerable<BaseSerpApiAiModeAiOverviewElementItem>** | items of the element |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | additional references relevant to the item<br>includes references to webpages that may have been used to generate the ai_overview |[optional]|
**Rectangle** | **AiModeRectangleInfo** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|