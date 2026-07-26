# AiOptimizationLlmMentionsTargetMetricsLiteLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total amount of results relevant the request</em> |[optional]|
**Offset** | **int?** | <em>the number of mentions objects that are omitted in the <code>items</code> array</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**AggregatedMetrics** | **object** | <em>aggregated mentions metrics</em><br>in this case, always returns <code>null</code> |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsTargetMetricsLiteLiveItem>** | <em>array of aggregated mentions metrics</em><br>contains objects with aggregated mention metrics for the specified target |[optional]|