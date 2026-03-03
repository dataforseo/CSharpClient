# AiModeAiOverviewInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERPposition within a group of elements with identical type valuespositions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERPabsolute position among all the elements in SERP |[optional]|
**Page** | **int?** | SERP pageSERP page on which the element ranks |[optional]|
**Position** | **string** | the alignment of the element in SERPcan take the following values:left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Markdown** | **string** | content of the element in markdown formatthe text of the ai_overview formatted in the markdown markup language |[optional]|
**Items** | **IEnumerable<BaseSerpApiAiModeAiOverviewElementItem>** | elements of search results found in SERP |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | additional references relevant to the itemincludes references to webpages that may have been used to generate the ai_overview |[optional]|
**Rectangle** | **AiModeRectangleInfo** | rectangle parameterscontains cartesian coordinates and pixel dimensions of the result's snippet in SERPequals null if calculate_rectangles in the POST request is not set to true |[optional]|