# AiOverviewExpandedComponent


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | title of the element |[optional]|
**Text** | **string** | reference text<br>text snippet from the page that was used to generate the ai_overview_element |[optional]|
**Markdown** | **string** | content of the element in markdown format |[optional]|
**Images** | **IEnumerable<AiModeImagesElement>** | images of the element |[optional]|
**Links** | **IEnumerable<LinkElement>** | website links featured in the element |[optional]|
**References** | **IEnumerable<AiAiOverviewReferenceInfo>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|