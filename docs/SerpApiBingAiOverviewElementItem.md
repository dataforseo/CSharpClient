# SerpApiBingAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**Text** | **string** | text or description of the element in SERP |[optional]|
**Markdown** | **string** | content of the element in markdown format |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some search results<br>if there are none, equals null |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the element |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|