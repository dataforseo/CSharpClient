# Total


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Location** | **IEnumerable<GroupElement>** | location-based grouping<br>array of objects containing mention metrics segmented by geographical location |[optional]|
**Language** | **IEnumerable<GroupElement>** | language-based grouping<br>array of objects containing mention metrics segmented by content language |[optional]|
**Platform** | **IEnumerable<GroupElement>** | platform-based grouping<br>array of group elements containing mention metrics segmented by AI platform |[optional]|
**SourcesDomain** | **IEnumerable<GroupElement>** | found source domains relevant to the target<br>array of objects containing data on top domains that are cited as sources in LLM responses |[optional]|
**SearchResultsDomain** | **IEnumerable<GroupElement>** | found search results domains relevant to the target<br>array of objects containing data on top domains that appear in search results related to LLM queries |[optional]|
**BrandEntitiesTitle** | **IEnumerable<GroupElement>** | data on brand entities relevant to the target<br>array of objects containing data on brand entity titles that appear in search results related to LLM queries |[optional]|
**BrandEntitiesCategory** | **IEnumerable<GroupElement>** | data on brand entities relevant to the target<br>array of objects containing data on brand entity categories that appear in search results related to LLM queries |[optional]|