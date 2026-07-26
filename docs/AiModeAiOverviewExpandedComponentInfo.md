# AiModeAiOverviewExpandedComponentInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | <em>reference page title</em> |[optional]|
**Text** | **string** | <em>additional text of the element in SERP</em> |[optional]|
**Markdown** | **string** | <em>content of the element in markdown format</em> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the component</em><br>if there are none, equals <code>null</code> |[optional]|
**Links** | **IEnumerable<AiModeLinkElementInfo>** | <em>sitelinks</em><br>the links shown below some of Google's search results<br>if there are none, equals <code>null</code> |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | <em>references relevant to the element</em><br>includes references to webpages that were used to generate the <code>ai_overview_element</code> |[optional]|