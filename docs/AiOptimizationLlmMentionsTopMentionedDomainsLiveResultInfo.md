# AiOptimizationLlmMentionsTopMentionedDomainsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total amount of results relevant the request</em> |[optional]|
**Offset** | **int?** | <em>the number of mentions objects that are omitted in the <code>items</code> array</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**AggregatedMetrics** | **LlmMentionsAggregatedMetricsInfo** | <em>aggregated mentions metrics</em><br>contains aggregated LLM mention metrics across all found domains, grouped by various dimensions |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsTopMentionedDomainsLiveItem>** | <em>individual domain results</em><br>array containing detailed mention metrics for each of the found top domains |[optional]|