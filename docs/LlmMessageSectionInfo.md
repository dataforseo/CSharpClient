# LlmMessageSectionInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Text** | **string** | AI-generated text content |[optional]|
**Annotations** | **IEnumerable<AnnotationInfo>** | array of references used to generate the response<br>equals null if the web_search parameter is not set to true<br>Note: annotations may return empty even when web_search is true, as the AI will attempt to retrieve web information but may not find relevant results |[optional]|