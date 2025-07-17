# KnowledgeGraphCarouselItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | reference page title |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>action:listen_artist |[optional]|
**Link** | **LinkElement** | link of the element |[optional]|
**Items** | **IEnumerable<KnowledgeGraphListElement>** | contains arrays of specific images |[optional]|