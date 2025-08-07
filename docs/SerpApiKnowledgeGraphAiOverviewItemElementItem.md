# SerpApiKnowledgeGraphAiOverviewItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AsynchronousAiOverview** | **bool?** | indicates whether the element is loaded asynchronically<br>if true, the ai_overview element is loaded asynchronically;<br>if false, the ai_overview element is loaded from cache; |[optional]|
**Items** | **IEnumerable<BaseSerpApiKnowledgeGraphAiOverviewElementItem>** | additional items present in the element<br>if there are none, equals null |[optional]|
**References** | **IEnumerable<AiModeAiOverviewReferenceInfo>** | additional references relevant to the item<br>includes references to webpages that may have been used to generate the ai_overview |[optional]|