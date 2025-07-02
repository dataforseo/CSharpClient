# AiModeAiOverviewExpandedComponent


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | reference page title |[optional]|
**Text** | **string** | text or description of the element in SERP |[optional]|
**Markdown** | **string** | content of the element in markdown format<br>the text of the ai_overview formatted in the markdown markup language |[optional]|
**Images** | **IEnumerable<ImagesElement>** | images of the element<br>if there are none, equals null |[optional]|
**Links** | **IEnumerable<AiModeLinkElement>** | website links featured in the element |[optional]|
**References** | **IEnumerable<AiModeReferences>** | additional references relevant to the item<br>includes references to webpages that may have been used to generate the ai_overview |[optional]|