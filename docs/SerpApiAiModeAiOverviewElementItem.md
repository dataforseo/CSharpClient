# SerpApiAiModeAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the element |[optional]|
**Text** | **string** | text or description of the element in SERP |[optional]|
**Markdown** | **string** | content of the element in markdown format |[optional]|
**Links** | **IEnumerable<AiModeLinkElementInfo>** | website links featured in the element |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the element<br>if there are none, equals null |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|