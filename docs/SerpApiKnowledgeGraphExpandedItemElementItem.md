# SerpApiKnowledgeGraphExpandedItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | title of the link |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>kc:/local:place qa |[optional]|
**ExpandedElement** | **IEnumerable<KnowledgeGraphExpandedElement>** | link of the element |[optional]|