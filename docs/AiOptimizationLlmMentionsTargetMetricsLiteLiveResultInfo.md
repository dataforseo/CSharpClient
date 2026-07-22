# AiOptimizationLlmMentionsTargetMetricsLiteLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total amount of results relevant the request |[optional]|
**Offset** | **int?** | the number of mentions objects that are omitted in the items array |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**AggregatedMetrics** | **object** | aggregated mentions metrics<br>in this case, always returns null |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsTargetMetricsLiteLiveItem>** | array of aggregated mentions metrics<br>contains objects with aggregated mention metrics for the specified target |[optional]|