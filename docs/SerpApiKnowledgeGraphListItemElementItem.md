# SerpApiKnowledgeGraphListItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | title of the link element |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>ss:/webfacts:net_worth |[optional]|
**Link** | **LinkElement** | link of the element |[optional]|
**Items** | **IEnumerable<KnowledgeGraphListElement>** | additional items present in the element<br>if there are none, equals null |[optional]|