# AiOptimizationLlmMentionsTopMentionedPagesLiteLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total number of results |[optional]|
**Offset** | **int?** | offset in the results array of the returned mentions data<br>offset specified in the request |[optional]|
**ItemsCount** | **long?** | number of items in the results array |[optional]|
**AggregatedMetrics** | **object** | aggregated mentions metrics summary<br>contains overall aggregated LLM mention metrics across all found domains, grouped by various dimensionsin this case, the value will be null |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsTopMentionedPagesLiteLiveItem>** | contains relevant mentions data |[optional]|