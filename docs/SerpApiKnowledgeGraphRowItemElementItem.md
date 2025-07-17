# SerpApiKnowledgeGraphRowItemElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | title of the item |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>kc:/common/topic:social media presence |[optional]|
**Text** | **string** | reference text<br>text snippet from the page that was used to generate the ai_overview_element |[optional]|
**Links** | **IEnumerable<LinkElement>** | links featured in the faq_box_element |[optional]|