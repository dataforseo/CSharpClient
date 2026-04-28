# KnowledgeGraphSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**Subtitle** | **string** | subtitle of the item |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**CardId** | **string** | card id |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**ImageUrl** | **string** | URL of the image<br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**LogoUrl** | **string** | URL of the logo from knowledge graph |[optional]|
**Cid** | **string** | google-defined client id<br>unique id of a local establishment;<br>can be used with Google Reviews API to get a full list of reviews |[optional]|
**Items** | **IEnumerable<BaseSerpApiKnowledgeGraphElementItem>** | contains results featured in the ‘hotels_pack’ element of SERP |[optional]|