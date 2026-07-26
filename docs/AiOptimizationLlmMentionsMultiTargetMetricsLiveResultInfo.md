# AiOptimizationLlmMentionsMultiTargetMetricsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total number of results</em> |[optional]|
**Offset** | **int?** | <em>offset in the results array of the returned mentions data</em><br><code>offset</code> specified in the request |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**AggregatedMetrics** | **LlmMentionsAggregatedMetricsInfo** | <em>aggregated mentions metrics summary</em><br>contains overall aggregated LLM mention metrics across all LLM mentions that match at least one target specified in the request |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsMultiTargetMetricsLiveItem>** | <em>contains relevant mentions data</em> |[optional]|