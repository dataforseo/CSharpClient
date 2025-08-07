# AiModeAiOverviewExpandedComponentInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | reference page title |[optional]|
**Text** | **string** | additional text of the element in SERP |[optional]|
**Markdown** | **string** | content of the element in markdown format |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the component<br>if there are none, equals null |[optional]|
**Links** | **IEnumerable<AiModeLinkElementInfo>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|