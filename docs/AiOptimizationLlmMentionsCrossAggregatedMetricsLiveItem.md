# AiOptimizationLlmMentionsCrossAggregatedMetricsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Key** | **string** | aggregation key received in a POST array |[optional]|
**Location** | **IEnumerable<GroupElement>** | location-based grouping<br>array of objects containing mention metrics segmented by geographical location |[optional]|
**Language** | **IEnumerable<GroupElement>** | language-based grouping<br>array of objects containing mention metrics segmented by content language |[optional]|
**Platform** | **IEnumerable<GroupElement>** | platform-based grouping<br>array of group elements containing mention metrics segmented by AI platform |[optional]|
**SourcesDomain** | **IEnumerable<GroupElement>** | found top source domains relevant to the target<br>array of objects containing data on top domains that are cited as sources in LLM responses |[optional]|
**SearchResultsDomain** | **IEnumerable<GroupElement>** | found top search results domains relevant to the target<br>array of objects containing data on top domains that appear in search results related to LLM queries |[optional]|