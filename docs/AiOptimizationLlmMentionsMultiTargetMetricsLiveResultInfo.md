# AiOptimizationLlmMentionsMultiTargetMetricsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total number of results |[optional]|
**Offset** | **int?** | offset in the results array of the returned mentions data<br>offset specified in the request |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**AggregatedMetrics** | **LlmMentionsAggregatedMetricsInfo** | aggregated mentions metrics summary<br>contains overall aggregated LLM mention metrics across all LLM mentions that match at least one target specified in the request |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsMultiTargetMetricsLiveItem>** | contains relevant mentions data |[optional]|