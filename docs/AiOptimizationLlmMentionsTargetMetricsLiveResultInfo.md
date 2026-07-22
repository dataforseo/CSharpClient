# AiOptimizationLlmMentionsTargetMetricsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total amount of results relevant to the request<br>in this case, always equals 0 |[optional]|
**Offset** | **int?** | the number of mentions objects that are omitted in the items array<br>in this case, always equals 0 |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array<br>in this case, always equals 0 |[optional]|
**AggregatedMetrics** | **LlmMentionsAggregatedMetricsInfo** | aggregated mentions metrics<br>contains aggregated LLM mention metrics across all found domains, grouped by various dimensions |[optional]|
**Items** | **IEnumerable<object>** | individual target results<br>in this case, equals null |[optional]|