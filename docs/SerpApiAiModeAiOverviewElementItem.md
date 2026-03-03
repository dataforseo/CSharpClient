# SerpApiAiModeAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the element |[optional]|
**Text** | **string** | text or description of the element in SERP |[optional]|
**Markdown** | **string** | content of the element in markdown format |[optional]|
**Links** | **IEnumerable<AiModeLinkElementInfo>** | website links featured in the elementif there are none, equals null |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the elementif there are none, equals null |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | references relevant to the elementincludes references to webpages that were used to generate the ai_overview_element |[optional]|