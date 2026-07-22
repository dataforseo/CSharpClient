# AiOptimizationLlmMentionsTopMentionedBrandCategoriesLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total amount of results relevant the request |[optional]|
**Offset** | **int?** | the number of mentions objects that are omitted in the items array |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**AggregatedMetrics** | **LlmMentionsAggregatedMetricsInfo** | aggregated mentions metrics<br>contains aggregated LLM mention metrics across all found brand categories, grouped by various dimensions |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsTopMentionedBrandCategoriesLiveItem>** | individual brand categories results<br>array containing detailed mention metrics for each of the found brand categories |[optional]|