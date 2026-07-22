# AiOptimizationLlmMentionsMultiTargetMetricsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Key** | **string** | grouping key<br>the specific identifier for the group dimension |[optional]|
**Location** | **IEnumerable<AggregatedMetricsItemInfo>** | location-based grouping<br>array of objects containing mention metrics segmented by geographical location |[optional]|
**Language** | **IEnumerable<AggregatedMetricsItemInfo>** | language-based grouping<br>array of objects containing mention metrics segmented by content language |[optional]|
**Platform** | **IEnumerable<AggregatedMetricsItemInfo>** | platform-based grouping<br>array of group elements containing mention metrics segmented by AI platform |[optional]|
**SourcesDomain** | **IEnumerable<AggregatedMetricsItemInfo>** | found top source domains relevant to the target<br>array of objects containing data on top domains that are cited as sources in LLM responses<br>learn more about the sources and how to retrieve LLM citation data at our Help Center |[optional]|
**SearchResultsDomain** | **IEnumerable<AggregatedMetricsItemInfo>** | found top search results domains relevant to the target<br>array of objects containing data on top domains that appear in search results related to LLM queries |[optional]|
**BrandEntitiesTitle** | **IEnumerable<AggregatedMetricsItemInfo>** | data on brand entities relevant to the target<br>array of objects containing data on brand entity titles that appear in search results related to LLM queries |[optional]|
**BrandEntitiesCategory** | **IEnumerable<AggregatedMetricsItemInfo>** | data on brand entities relevant to the target<br>array of objects containing data on brand entity categories that appear in search results related to LLM queries |[optional]|
**Total** | **AggregatedMetricsInfoTotalInfo** | data on total mentions and search volume for the target |[optional]|