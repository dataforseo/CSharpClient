# SerpApiAiOverviewElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of a given link element |[optional]|
**Text** | **string** | reference text<br>text snippet from the page that was used to generate the ai_overview_element |[optional]|
**Markdown** | **string** | text of the component in the markdwon format |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**Images** | **IEnumerable<AiModeImagesElement>** | images of the element<br>if there are none, equals null |[optional]|
**References** | **IEnumerable<AiAiOverviewReferenceInfo>** | additional references relevant to the item<br>includes references to webpages that may have been used to generate the product_considerations_ai_overview_expanded_element |[optional]|