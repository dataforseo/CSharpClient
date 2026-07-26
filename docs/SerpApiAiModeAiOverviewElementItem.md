# SerpApiAiModeAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the element</em> |[optional]|
**Text** | **string** | <em>text or description of the element in SERP</em> |[optional]|
**Markdown** | **string** | <em>content of the element in markdown format</em> |[optional]|
**Links** | **IEnumerable<AiModeLinkElementInfo>** | <em>website links featured in the element</em><br>if there are none, equals <code>null</code> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the element</em><br>if there are none, equals <code>null</code> |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | <em>references relevant to the element</em><br>includes references to webpages that were used to generate the <code>ai_overview_element</code> |[optional]|