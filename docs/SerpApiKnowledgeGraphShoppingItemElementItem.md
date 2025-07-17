# SerpApiKnowledgeGraphShoppingItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | title of the place |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>kc:/shopping/gpc:organic-offers |[optional]|
**Items** | **IEnumerable<KnowledgeGraphShoppingElement>** | additional items present in the element<br>if there are none, equals null |[optional]|