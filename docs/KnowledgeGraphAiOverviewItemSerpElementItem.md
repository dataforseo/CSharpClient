# KnowledgeGraphAiOverviewItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AsynchronousAiOverview** | **bool?** | indicates whether the element is loaded asynchronically<br>if true, the ai_overview element is loaded asynchronically;<br>if false, the ai_overview element is loaded from cache |[optional]|
**Items** | **IEnumerable<BaseSerpApiKnowledgeGraphAiOverviewElementItem>** | contains arrays of specific images |[optional]|
**References** | **IEnumerable<AiAiOverviewReferenceInfo>** | references relevant to the element<br>includes references to webpages that were used to generate the ai_overview_element |[optional]|