# AiOptimizationLlmMentionssLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Key** | **string** | URL of a found page<br>the URL of a page found in LLM mentions for the specified target |[optional]|
**Location** | **IEnumerable<GroupElement>** | location-based grouping<br>array of objects containing page mention metrics segmented by geographical location |[optional]|
**Language** | **IEnumerable<GroupElement>** | language-based grouping<br>array of objects containing page mention metrics segmented by content language |[optional]|
**Platform** | **IEnumerable<GroupElement>** | platform-based grouping<br>array of group elements containing page mention metrics segmented by AI platform |[optional]|
**SourcesDomain** | **IEnumerable<GroupElement>** | source domains relevant to the specific page<br>array of objects containing data on domains that are cited as sources in LLM responses |[optional]|
**SearchResultsDomain** | **IEnumerable<GroupElement>** | search results domains relevant to the specific page<br>array of objects containing data on domains that appear in search results related to LLM queries |[optional]|
**BrandEntitiesTitle** | **IEnumerable<GroupElement>** | data on brand entities relevant to the target<br>array of objects containing data on brand entity titles that appear in search results related to LLM queries |[optional]|
**BrandEntitiesCategory** | **IEnumerable<GroupElement>** | data on brand entities relevant to the target<br>array of objects containing data on brand entity categories that appear in search results related to LLM queries |[optional]|