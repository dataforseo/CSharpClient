# SerpApiKnowledgeGraphDescriptionItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Text** | **string** | text or description of the element in SERP |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|