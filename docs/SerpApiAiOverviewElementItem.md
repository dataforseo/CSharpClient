# SerpApiAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of a given link element |[optional]|
**Text** | **string** | reference text<br>text snippet from the page that was used to generate the ai_overview_element |[optional]|
**Markdown** | **string** | content of the element in markdown format |[optional]|
**Links** | **IEnumerable<LinkElement>** | website links featured in the element |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the component<br>if there are none, equals null |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|