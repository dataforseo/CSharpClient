# FoundOnWebSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | reference page title |[optional]|
**RelatedSearches** | **IEnumerable<string>** | search queries related to the elment |[optional]|
**Items** | **IEnumerable<FoundOnWebElement>** | contains arrays of specific images |[optional]|