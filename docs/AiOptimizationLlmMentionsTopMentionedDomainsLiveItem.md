# AiOptimizationLlmMentionsTopMentionedDomainsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | <em>domain name</em><br>the domain name of the website found in LLM mentions for the specified target |[optional]|
**Location** | **IEnumerable<AggregatedMetricsItemInfo>** | <em>location-based grouping</em><br>array of objects containing mention metrics segmented by geographical location |[optional]|
**Language** | **IEnumerable<AggregatedMetricsItemInfo>** | <em>language-based grouping</em><br>array of objects containing mention metrics segmented by content language |[optional]|
**Platform** | **IEnumerable<AggregatedMetricsItemInfo>** | <em>platform-based grouping</em><br>array of group elements containing mention metrics segmented by AI platform |[optional]|
**SourcesDomain** | **IEnumerable<AggregatedMetricsItemInfo>** | <em>found top source domains relevant to the target</em><br>array of objects containing data on top domains that are cited as sources in LLM responses<br>learn more about the sources and how to retrieve LLM citation data at our <a href='https://dataforseo.com/help-center/how-to-get-llm-citation-data-with-llm-mentions-api' target='_blank'>Help Center</a> |[optional]|
**SearchResultsDomain** | **IEnumerable<AggregatedMetricsItemInfo>** | <em>found top search results domains relevant to the target</em><br>array of objects containing data on top domains that appear in search results related to LLM queries |[optional]|
**BrandEntitiesTitle** | **IEnumerable<AggregatedMetricsItemInfo>** | <em>data on brand entities relevant to the target</em><br>array of objects containing data on brand entity titles that appear in search results related to LLM queries |[optional]|
**BrandEntitiesCategory** | **IEnumerable<AggregatedMetricsItemInfo>** | <em>data on brand entities relevant to the target</em><br>array of objects containing data on brand entity categories that appear in search results related to LLM queries |[optional]|
**Total** | **AggregatedMetricsInfoTotalInfo** | <em>aggregated mentions metrics summary</em><br>contains overall aggregated LLM mention metrics across all dimensions |[optional]|