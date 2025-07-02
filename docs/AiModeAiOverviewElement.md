# AiModeAiOverviewElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Title** | **string** | title of the element |[optional]|
**Text** | **string** | text or description of the element in SERP |[optional]|
**Markdown** | **string** | content of the element in markdown format |[optional]|
**Links** | **IEnumerable<AiModeLinkElement>** | website links featured in the element |[optional]|
**Images** | **IEnumerable<ImagesElement>** | images of the element<br>if there are none, equals null |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReference>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|