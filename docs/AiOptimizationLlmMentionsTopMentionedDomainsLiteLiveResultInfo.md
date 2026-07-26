# AiOptimizationLlmMentionsTopMentionedDomainsLiteLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total number of results</em> |[optional]|
**Offset** | **int?** | <em>offset in the results array of the returned mentions data</em><br><code>offset</code> specified in the reqest |[optional]|
**ItemsCount** | **long?** | <em>number of items in the results array</em> |[optional]|
**AggregatedMetrics** | **object** | <em>aggregated mentions metrics summary</em><br>contains overall aggregated LLM mention metrics across all found domains, grouped by various dimensions</br>in this case, the value will be <code>null</code> |[optional]|
**Items** | **IEnumerable<AiOptimizationLlmMentionsTopMentionedDomainsLiteLiveItem>** | <em>contains relevant mentions data</em> |[optional]|